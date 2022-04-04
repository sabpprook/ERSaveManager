namespace ERSaveManager
{
    partial class fmGUI
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label_SteamID = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_QuickSave = new System.Windows.Forms.Button();
            this.btn_QuickLoad = new System.Windows.Forms.Button();
            this.btn_InitSave = new System.Windows.Forms.Button();
            this.radioBtn_ZH = new System.Windows.Forms.RadioButton();
            this.radioBtn_ENG = new System.Windows.Forms.RadioButton();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.recordSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgv_Cover = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Rename = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgv_Restore = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgv_Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label_Msg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label_SteamID
            // 
            this.label_SteamID.AutoSize = true;
            this.label_SteamID.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SteamID.ForeColor = System.Drawing.Color.Teal;
            this.label_SteamID.Location = new System.Drawing.Point(13, 18);
            this.label_SteamID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_SteamID.Name = "label_SteamID";
            this.label_SteamID.Size = new System.Drawing.Size(77, 20);
            this.label_SteamID.TabIndex = 1;
            this.label_SteamID.Text = "Steam ID:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_Cover,
            this.dataGridViewTextBoxColumn1,
            this.dgv_Rename,
            this.dgv_Restore,
            this.dgv_Delete});
            this.dataGridView1.DataSource = this.recordSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 62);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.RowTemplate.Height = 60;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(760, 315);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_QuickSave
            // 
            this.btn_QuickSave.Enabled = false;
            this.btn_QuickSave.Location = new System.Drawing.Point(400, 11);
            this.btn_QuickSave.Name = "btn_QuickSave";
            this.btn_QuickSave.Size = new System.Drawing.Size(120, 36);
            this.btn_QuickSave.TabIndex = 3;
            this.btn_QuickSave.TabStop = false;
            this.btn_QuickSave.Text = "快速備份 (&F5)";
            this.btn_QuickSave.UseVisualStyleBackColor = true;
            this.btn_QuickSave.Click += new System.EventHandler(this.btn_QuickSave_Click);
            // 
            // btn_QuickLoad
            // 
            this.btn_QuickLoad.Enabled = false;
            this.btn_QuickLoad.Location = new System.Drawing.Point(526, 11);
            this.btn_QuickLoad.Name = "btn_QuickLoad";
            this.btn_QuickLoad.Size = new System.Drawing.Size(120, 36);
            this.btn_QuickLoad.TabIndex = 4;
            this.btn_QuickLoad.TabStop = false;
            this.btn_QuickLoad.Text = "快速還原 (&F9)";
            this.btn_QuickLoad.UseVisualStyleBackColor = true;
            this.btn_QuickLoad.Click += new System.EventHandler(this.btn_QuickLoad_Click);
            // 
            // btn_InitSave
            // 
            this.btn_InitSave.Location = new System.Drawing.Point(652, 11);
            this.btn_InitSave.Name = "btn_InitSave";
            this.btn_InitSave.Size = new System.Drawing.Size(120, 36);
            this.btn_InitSave.TabIndex = 5;
            this.btn_InitSave.TabStop = false;
            this.btn_InitSave.Text = "設定初始存檔";
            this.btn_InitSave.UseVisualStyleBackColor = true;
            this.btn_InitSave.Click += new System.EventHandler(this.btn_InitSave_Click);
            // 
            // radioBtn_ZH
            // 
            this.radioBtn_ZH.AutoSize = true;
            this.radioBtn_ZH.Location = new System.Drawing.Point(269, 19);
            this.radioBtn_ZH.Name = "radioBtn_ZH";
            this.radioBtn_ZH.Size = new System.Drawing.Size(52, 21);
            this.radioBtn_ZH.TabIndex = 6;
            this.radioBtn_ZH.TabStop = true;
            this.radioBtn_ZH.Text = "中文";
            this.radioBtn_ZH.UseVisualStyleBackColor = true;
            this.radioBtn_ZH.CheckedChanged += new System.EventHandler(this.radioBtn_ZH_CheckedChanged);
            // 
            // radioBtn_ENG
            // 
            this.radioBtn_ENG.AutoSize = true;
            this.radioBtn_ENG.Location = new System.Drawing.Point(325, 19);
            this.radioBtn_ENG.Name = "radioBtn_ENG";
            this.radioBtn_ENG.Size = new System.Drawing.Size(69, 21);
            this.radioBtn_ENG.TabIndex = 7;
            this.radioBtn_ENG.TabStop = true;
            this.radioBtn_ENG.Text = "English";
            this.radioBtn_ENG.UseVisualStyleBackColor = true;
            this.radioBtn_ENG.CheckedChanged += new System.EventHandler(this.radioBtn_ENG_CheckedChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Teal;
            this.linkLabel1.Location = new System.Drawing.Point(528, 388);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(244, 20);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Github: sabpprook/ERSaveManager";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.DeepSkyBlue;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // recordSource
            // 
            this.recordSource.DataSource = typeof(ERSaveManager.SaveItem.Record);
            // 
            // dgv_Cover
            // 
            this.dgv_Cover.HeaderText = "Cover";
            this.dgv_Cover.MinimumWidth = 162;
            this.dgv_Cover.Name = "dgv_Cover";
            this.dgv_Cover.ReadOnly = true;
            this.dgv_Cover.Width = 162;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn1.HeaderText = "Title";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 200;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dgv_Rename
            // 
            this.dgv_Rename.HeaderText = "Rename";
            this.dgv_Rename.MinimumWidth = 90;
            this.dgv_Rename.Name = "dgv_Rename";
            this.dgv_Rename.ReadOnly = true;
            this.dgv_Rename.Text = "Rename";
            this.dgv_Rename.UseColumnTextForButtonValue = true;
            this.dgv_Rename.Width = 90;
            // 
            // dgv_Restore
            // 
            this.dgv_Restore.HeaderText = "Restore";
            this.dgv_Restore.MinimumWidth = 90;
            this.dgv_Restore.Name = "dgv_Restore";
            this.dgv_Restore.ReadOnly = true;
            this.dgv_Restore.Text = "Restore";
            this.dgv_Restore.UseColumnTextForButtonValue = true;
            this.dgv_Restore.Width = 90;
            // 
            // dgv_Delete
            // 
            this.dgv_Delete.HeaderText = "Delete";
            this.dgv_Delete.MinimumWidth = 90;
            this.dgv_Delete.Name = "dgv_Delete";
            this.dgv_Delete.ReadOnly = true;
            this.dgv_Delete.Text = "Delete";
            this.dgv_Delete.UseColumnTextForButtonValue = true;
            this.dgv_Delete.Width = 90;
            // 
            // label_Msg
            // 
            this.label_Msg.AutoSize = true;
            this.label_Msg.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Msg.ForeColor = System.Drawing.Color.Crimson;
            this.label_Msg.Location = new System.Drawing.Point(14, 389);
            this.label_Msg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Msg.Name = "label_Msg";
            this.label_Msg.Size = new System.Drawing.Size(0, 20);
            this.label_Msg.TabIndex = 9;
            // 
            // fmGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 421);
            this.Controls.Add(this.label_Msg);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.radioBtn_ENG);
            this.Controls.Add(this.radioBtn_ZH);
            this.Controls.Add(this.btn_InitSave);
            this.Controls.Add(this.btn_QuickLoad);
            this.Controls.Add(this.btn_QuickSave);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label_SteamID);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "fmGUI";
            this.Text = "ERSaveManager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fmGUI_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_SteamID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource recordSource;
        private System.Windows.Forms.Button btn_QuickSave;
        private System.Windows.Forms.Button btn_QuickLoad;
        private System.Windows.Forms.Button btn_InitSave;
        private System.Windows.Forms.RadioButton radioBtn_ZH;
        private System.Windows.Forms.RadioButton radioBtn_ENG;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.DataGridViewImageColumn dgv_Cover;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewButtonColumn dgv_Rename;
        private System.Windows.Forms.DataGridViewButtonColumn dgv_Restore;
        private System.Windows.Forms.DataGridViewButtonColumn dgv_Delete;
        private System.Windows.Forms.Label label_Msg;
    }
}

