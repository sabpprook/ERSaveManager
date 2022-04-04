using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using WK.Libraries.HotkeyListenerNS;

namespace ERSaveManager
{
    public partial class fmGUI : Form
    {
        private SaveItem ERSave { get; set; }
        private string ERSaveFile { get; set; }

        private HotkeyListener hotKey = new HotkeyListener();
        private JavaScriptSerializer jss = new JavaScriptSerializer { MaxJsonLength = int.MaxValue };
        Locale.ITranslate Locale { get; set; }
        Locale.ITranslate EN = new Locale.English();
        Locale.ITranslate ZH = new Locale.Chinese();

        public fmGUI()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var quickSave = new Hotkey(Keys.F5);
            var quickLoad = new Hotkey(Keys.F9);
            hotKey.Add(quickSave);
            hotKey.Add(quickLoad);
            hotKey.HotkeyPressed += (_s, _e) =>
            {
                if (_e.Hotkey == quickSave)
                    CreateNewRecord();

                if (_e.Hotkey == quickLoad)
                    Utils.RestoreSnapshot(ERSave, 0);
            };

            radioBtn_ZH.Checked = true;

            LoadData();
        }

        private void fmGUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (File.Exists(Utils.source_ersm))
            {
                e.Cancel = true;
                File.Delete(Utils.source_ersm);
                hotKey.RemoveAll();
                Environment.Exit(0);
            }
        }
        private void radioBtn_ENG_CheckedChanged(object sender, EventArgs e)
        {
            Locale = EN;
            ChangeText(radioBtn_ENG.Font);
        }

        private void radioBtn_ZH_CheckedChanged(object sender, EventArgs e)
        {
            Locale = ZH;
            ChangeText(radioBtn_ZH.Font);
        }

        private void ChangeText(Font font)
        {
            this.Text = Locale.STR_TITLE;
            btn_QuickSave.Text = Locale.STR_QUICKSAVE;
            btn_QuickLoad.Text = Locale.STR_QUICKLOAD;
            btn_InitSave.Text = Locale.STR_INITSAVE;
            (dataGridView1.Columns["dgv_Rename"] as DataGridViewButtonColumn).Text = Locale.STR_RECORD_RENAME;
            (dataGridView1.Columns["dgv_Restore"] as DataGridViewButtonColumn).Text = Locale.STR_RECORD_RESTORE;
            (dataGridView1.Columns["dgv_Delete"] as DataGridViewButtonColumn).Text = Locale.STR_RECORD_DELETE;

            GC.Collect();
        }

        private void btn_InitSave_Click(object sender, EventArgs e)
        {
            ERSave = new SaveItem();

            var ofd = new OpenFileDialog()
            {
                InitialDirectory = Environment.ExpandEnvironmentVariables("%APPDATA%\\EldenRing\\"),
                FileName = "ER0000.sl2",
                Filter = "Elden Ring savedata (*.sl2)|*.sl2"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ERSaveFile = ERSave.FileName = ofd.FileName;

                var path = Path.GetDirectoryName(ERSaveFile);
                ERSave.SteamID64 = path.Substring(path.LastIndexOf('\\') + 1);

                var data = GZip.compress(File.ReadAllBytes(ERSaveFile));
                ERSave.InitData = Convert.ToBase64String(data);
                File.WriteAllText(Utils.data_ersm, jss.Serialize(ERSave));
            }

            LoadData();
        }

        private void btn_QuickSave_Click(object sender, EventArgs e)
        {
            CreateNewRecord();
        }

        private void btn_QuickLoad_Click(object sender, EventArgs e)
        {
            var record = dataGridView1.Rows[0].DataBoundItem as SaveItem.Record;
            Save_Restore(record);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var record = dataGridView1.Rows[e.RowIndex].DataBoundItem as SaveItem.Record;

            switch (dataGridView1.Columns[e.ColumnIndex].Name)
            {
                case "dgv_Rename":
                    Save_Rename(record); break;
                case "dgv_Restore":
                    Save_Restore(record); break;
                case "dgv_Delete":
                    Save_Delete(record); break;
                default:
                    break;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/sabpprook/ERSaveManager");
        }

        private void LoadData()
        {
            ERSave = new SaveItem();

            if (File.Exists(Utils.data_ersm))
            {
                ERSave = jss.Deserialize<SaveItem>(File.ReadAllText(Utils.data_ersm));
                ERSaveFile = ERSave.FileName;

                btn_QuickSave.Enabled = true;
                btn_QuickLoad.Enabled = true;
            }
            else
            {
                btn_QuickSave.Enabled = false;
                btn_QuickLoad.Enabled = false;
            }

            label_SteamID.Text = "SteamID64: " + ERSave.SteamID64;
            UpdateDataGridView();
        }

        private void CreateNewRecord()
        {
            var data = Utils.CreateSnapshot(ERSave);
            if (string.IsNullOrEmpty(data))
                return;

            var record = new SaveItem.Record();
            var dt = DateTimeOffset.Now;
            record.Timestamp = dt.ToUnixTimeSeconds();
            record.Title = dt.ToString("yyyy-MM-dd HH:mm:ss");
            record.Hash = Utils.Sha1Sum(ERSaveFile);
            record.Data = data;
            record.Cover = Utils.ScreenShot();

            ERSave.Slots.Add(record);
            ERSave.Slots.Sort((x, y) => -x.Timestamp.CompareTo(y.Timestamp));

            File.WriteAllText(Utils.data_ersm, jss.Serialize(ERSave));
            UpdateDataGridView();
            ShowStateLabel(string.Format(Locale.STATE_RECORD_CREATE, record.Title));
        }

        private void UpdateDataGridView()
        {
            dataGridView1.Rows.Clear();
            foreach (var item in ERSave.Slots)
            {
                recordSource.Add(item);
                var ms = new MemoryStream(Convert.FromBase64String(item.Cover));
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0].Value = Image.FromStream(ms);
            }
        }

        private void Save_Rename(SaveItem.Record record)
        {
            using (var fm = new fmDialogue())
            {
                fm.InitTitle = record.Title;
                if (fm.ShowDialog() == DialogResult.OK)
                {
                    record.Title = fm.InitTitle;
                    File.WriteAllText(Utils.data_ersm, jss.Serialize(ERSave));
                    UpdateDataGridView();
                }
            }
        }

        private void Save_Restore(SaveItem.Record record)
        {
            var index = ERSave.Slots.IndexOf(record);
            Utils.RestoreSnapshot(ERSave, index);
            ShowStateLabel(string.Format(Locale.STATE_RECORD_RESTORE, record.Title));
        }

        private void Save_Delete(SaveItem.Record record)
        {
            var result = MessageBox.Show(Locale.MSG_DELETE_CONFIRM, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                ERSave.Slots.Remove(record);
                File.WriteAllText(Utils.data_ersm, jss.Serialize(ERSave));
                UpdateDataGridView();
                ShowStateLabel(string.Format(Locale.STATE_RECORD_DELETE, record.Title));
            }
        }

        private void ShowStateLabel(string text)
        {
            SystemSounds.Asterisk.Play();
            Task.Run(() =>
            {
                Invoke(new Action(() => label_Msg.Text = text));
                Invoke(new Action(() => label_Msg.Visible = true));
                Thread.Sleep(3000);
                Invoke(new Action(() => label_Msg.Visible = false));
            });
        }
    }
}
