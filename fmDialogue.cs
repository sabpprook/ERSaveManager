using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERSaveManager
{
    public partial class fmDialogue : Form
    {
        public string InitTitle { get; set; }

        public fmDialogue()
        {
            InitializeComponent();
        }

        private void fmRename_Load(object sender, EventArgs e)
        {
            textBox1.Text = InitTitle;
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            InitTitle = textBox1.Text;
            DialogResult = DialogResult.OK;
        }
    }
}
