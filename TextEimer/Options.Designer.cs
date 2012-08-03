namespace TextEimer
{
    partial class Options
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
            this.optionTab = new System.Windows.Forms.TabControl();
            this.settingsTab = new System.Windows.Forms.TabPage();
            this.labelTrackBarValue = new System.Windows.Forms.Label();
            this.groupBoxLogginOn = new System.Windows.Forms.GroupBox();
            this.checkBoxLoggingOn = new System.Windows.Forms.CheckBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxOrderDesc = new System.Windows.Forms.GroupBox();
            this.radioOrderDesc2 = new System.Windows.Forms.RadioButton();
            this.radioOrderDesc1 = new System.Windows.Forms.RadioButton();
            this.trackBarMenuItemAmount = new System.Windows.Forms.TrackBar();
            this.labelMenuItemAmount = new System.Windows.Forms.Label();
            this.tabAbout = new System.Windows.Forms.TabPage();
            this.tableLayoutAbout = new System.Windows.Forms.TableLayoutPanel();
            this.labelProgramName = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.pictureBoxAbout = new System.Windows.Forms.PictureBox();
            this.groupAutostart = new System.Windows.Forms.GroupBox();
            this.buttonAutostart = new System.Windows.Forms.Button();
            this.optionTab.SuspendLayout();
            this.settingsTab.SuspendLayout();
            this.groupBoxLogginOn.SuspendLayout();
            this.groupBoxOrderDesc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMenuItemAmount)).BeginInit();
            this.tabAbout.SuspendLayout();
            this.tableLayoutAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAbout)).BeginInit();
            this.groupAutostart.SuspendLayout();
            this.SuspendLayout();
            // 
            // optionTab
            // 
            this.optionTab.Controls.Add(this.settingsTab);
            this.optionTab.Controls.Add(this.tabAbout);
            this.optionTab.Location = new System.Drawing.Point(1, 1);
            this.optionTab.Name = "optionTab";
            this.optionTab.SelectedIndex = 0;
            this.optionTab.Size = new System.Drawing.Size(572, 361);
            this.optionTab.TabIndex = 0;
            // 
            // settingsTab
            // 
            this.settingsTab.BackColor = System.Drawing.SystemColors.Control;
            this.settingsTab.Controls.Add(this.groupAutostart);
            this.settingsTab.Controls.Add(this.labelTrackBarValue);
            this.settingsTab.Controls.Add(this.groupBoxLogginOn);
            this.settingsTab.Controls.Add(this.buttonSave);
            this.settingsTab.Controls.Add(this.buttonCancel);
            this.settingsTab.Controls.Add(this.groupBoxOrderDesc);
            this.settingsTab.Controls.Add(this.trackBarMenuItemAmount);
            this.settingsTab.Controls.Add(this.labelMenuItemAmount);
            this.settingsTab.Location = new System.Drawing.Point(4, 22);
            this.settingsTab.Name = "settingsTab";
            this.settingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.settingsTab.Size = new System.Drawing.Size(564, 335);
            this.settingsTab.TabIndex = 0;
            this.settingsTab.Text = "Einstellungen";
            // 
            // labelTrackBarValue
            // 
            this.labelTrackBarValue.AutoSize = true;
            this.labelTrackBarValue.Location = new System.Drawing.Point(257, 58);
            this.labelTrackBarValue.Name = "labelTrackBarValue";
            this.labelTrackBarValue.Size = new System.Drawing.Size(13, 13);
            this.labelTrackBarValue.TabIndex = 9;
            this.labelTrackBarValue.Text = "0";
            // 
            // groupBoxLogginOn
            // 
            this.groupBoxLogginOn.Controls.Add(this.checkBoxLoggingOn);
            this.groupBoxLogginOn.Location = new System.Drawing.Point(283, 82);
            this.groupBoxLogginOn.Name = "groupBoxLogginOn";
            this.groupBoxLogginOn.Size = new System.Drawing.Size(269, 48);
            this.groupBoxLogginOn.TabIndex = 8;
            this.groupBoxLogginOn.TabStop = false;
            this.groupBoxLogginOn.Text = "Logging";
            // 
            // checkBoxLoggingOn
            // 
            this.checkBoxLoggingOn.AutoSize = true;
            this.checkBoxLoggingOn.Location = new System.Drawing.Point(6, 18);
            this.checkBoxLoggingOn.Name = "checkBoxLoggingOn";
            this.checkBoxLoggingOn.Size = new System.Drawing.Size(138, 17);
            this.checkBoxLoggingOn.TabIndex = 0;
            this.checkBoxLoggingOn.Text = "Fehlerlogging aktivieren";
            this.checkBoxLoggingOn.UseVisualStyleBackColor = true;
            this.checkBoxLoggingOn.CheckedChanged += new System.EventHandler(this.checkBoxLoggingOn_CheckedChanged);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(344, 293);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(101, 32);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Speichern";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(451, 293);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(101, 32);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Abbrechen";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // groupBoxOrderDesc
            // 
            this.groupBoxOrderDesc.Controls.Add(this.radioOrderDesc2);
            this.groupBoxOrderDesc.Controls.Add(this.radioOrderDesc1);
            this.groupBoxOrderDesc.Location = new System.Drawing.Point(16, 82);
            this.groupBoxOrderDesc.Name = "groupBoxOrderDesc";
            this.groupBoxOrderDesc.Size = new System.Drawing.Size(245, 49);
            this.groupBoxOrderDesc.TabIndex = 5;
            this.groupBoxOrderDesc.TabStop = false;
            this.groupBoxOrderDesc.Text = "Sortierung";
            // 
            // radioOrderDesc2
            // 
            this.radioOrderDesc2.AutoSize = true;
            this.radioOrderDesc2.Location = new System.Drawing.Point(102, 19);
            this.radioOrderDesc2.Name = "radioOrderDesc2";
            this.radioOrderDesc2.Size = new System.Drawing.Size(81, 17);
            this.radioOrderDesc2.TabIndex = 6;
            this.radioOrderDesc2.Text = "Aufsteigend";
            this.radioOrderDesc2.UseVisualStyleBackColor = true;
            this.radioOrderDesc2.CheckedChanged += new System.EventHandler(this.radioOrderDesc2_CheckedChanged);
            // 
            // radioOrderDesc1
            // 
            this.radioOrderDesc1.AutoSize = true;
            this.radioOrderDesc1.Location = new System.Drawing.Point(6, 19);
            this.radioOrderDesc1.Name = "radioOrderDesc1";
            this.radioOrderDesc1.Size = new System.Drawing.Size(78, 17);
            this.radioOrderDesc1.TabIndex = 5;
            this.radioOrderDesc1.Text = "Absteigend";
            this.radioOrderDesc1.UseVisualStyleBackColor = true;
            this.radioOrderDesc1.CheckedChanged += new System.EventHandler(this.radioOrderDesc1_CheckedChanged);
            // 
            // trackBarMenuItemAmount
            // 
            this.trackBarMenuItemAmount.Location = new System.Drawing.Point(16, 31);
            this.trackBarMenuItemAmount.Maximum = 50;
            this.trackBarMenuItemAmount.Minimum = 1;
            this.trackBarMenuItemAmount.Name = "trackBarMenuItemAmount";
            this.trackBarMenuItemAmount.Size = new System.Drawing.Size(537, 45);
            this.trackBarMenuItemAmount.TabIndex = 1;
            this.trackBarMenuItemAmount.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBarMenuItemAmount.Value = 1;
            this.trackBarMenuItemAmount.Scroll += new System.EventHandler(this.trackBarMenuItemAmount_Scroll);
            // 
            // labelMenuItemAmount
            // 
            this.labelMenuItemAmount.AutoSize = true;
            this.labelMenuItemAmount.Location = new System.Drawing.Point(13, 15);
            this.labelMenuItemAmount.Name = "labelMenuItemAmount";
            this.labelMenuItemAmount.Size = new System.Drawing.Size(130, 13);
            this.labelMenuItemAmount.TabIndex = 0;
            this.labelMenuItemAmount.Text = "Anzahl der Clipboardwerte";
            // 
            // tabAbout
            // 
            this.tabAbout.BackColor = System.Drawing.SystemColors.Control;
            this.tabAbout.Controls.Add(this.tableLayoutAbout);
            this.tabAbout.Location = new System.Drawing.Point(4, 22);
            this.tabAbout.Name = "tabAbout";
            this.tabAbout.Padding = new System.Windows.Forms.Padding(3);
            this.tabAbout.Size = new System.Drawing.Size(564, 335);
            this.tabAbout.TabIndex = 1;
            this.tabAbout.Text = "TextEimer";
            // 
            // tableLayoutAbout
            // 
            this.tableLayoutAbout.ColumnCount = 2;
            this.tableLayoutAbout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.11807F));
            this.tableLayoutAbout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.88194F));
            this.tableLayoutAbout.Controls.Add(this.labelProgramName, 1, 0);
            this.tableLayoutAbout.Controls.Add(this.labelVersion, 1, 1);
            this.tableLayoutAbout.Controls.Add(this.labelAuthor, 1, 2);
            this.tableLayoutAbout.Controls.Add(this.labelDescription, 1, 3);
            this.tableLayoutAbout.Controls.Add(this.textBoxDescription, 1, 4);
            this.tableLayoutAbout.Controls.Add(this.pictureBoxAbout, 0, 4);
            this.tableLayoutAbout.Location = new System.Drawing.Point(7, 19);
            this.tableLayoutAbout.Name = "tableLayoutAbout";
            this.tableLayoutAbout.RowCount = 5;
            this.tableLayoutAbout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.01587F));
            this.tableLayoutAbout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.65079F));
            this.tableLayoutAbout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.33333F));
            this.tableLayoutAbout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.349206F));
            this.tableLayoutAbout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.60318F));
            this.tableLayoutAbout.Size = new System.Drawing.Size(551, 315);
            this.tableLayoutAbout.TabIndex = 0;
            // 
            // labelProgramName
            // 
            this.labelProgramName.AutoSize = true;
            this.labelProgramName.Location = new System.Drawing.Point(146, 0);
            this.labelProgramName.Name = "labelProgramName";
            this.labelProgramName.Size = new System.Drawing.Size(54, 13);
            this.labelProgramName.TabIndex = 0;
            this.labelProgramName.Text = "Programm";
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Location = new System.Drawing.Point(146, 40);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(42, 13);
            this.labelVersion.TabIndex = 1;
            this.labelVersion.Text = "Version";
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(146, 82);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(38, 13);
            this.labelAuthor.TabIndex = 2;
            this.labelAuthor.Text = "Author";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(146, 123);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(72, 13);
            this.labelDescription.TabIndex = 3;
            this.labelDescription.Text = "Beschreibung";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(146, 145);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            this.textBoxDescription.Size = new System.Drawing.Size(402, 167);
            this.textBoxDescription.TabIndex = 4;
            // 
            // pictureBoxAbout
            // 
            this.pictureBoxAbout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxAbout.Image = global::TextEimer.Properties.Resources.about;
            this.pictureBoxAbout.Location = new System.Drawing.Point(3, 145);
            this.pictureBoxAbout.Name = "pictureBoxAbout";
            this.pictureBoxAbout.Size = new System.Drawing.Size(137, 167);
            this.pictureBoxAbout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAbout.TabIndex = 5;
            this.pictureBoxAbout.TabStop = false;
            // 
            // groupAutostart
            // 
            this.groupAutostart.Controls.Add(this.buttonAutostart);
            this.groupAutostart.Location = new System.Drawing.Point(20, 147);
            this.groupAutostart.Name = "groupAutostart";
            this.groupAutostart.Size = new System.Drawing.Size(240, 62);
            this.groupAutostart.TabIndex = 10;
            this.groupAutostart.TabStop = false;
            this.groupAutostart.Text = "Autostart";
            // 
            // buttonAutostart
            // 
            this.buttonAutostart.Location = new System.Drawing.Point(6, 20);
            this.buttonAutostart.Name = "buttonAutostart";
            this.buttonAutostart.Size = new System.Drawing.Size(228, 29);
            this.buttonAutostart.TabIndex = 0;
            this.buttonAutostart.UseVisualStyleBackColor = true;
            this.buttonAutostart.Click += new System.EventHandler(this.buttonAutostart_Click);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 361);
            this.Controls.Add(this.optionTab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(578, 385);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(578, 385);
            this.Name = "Options";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Einstellungen";
            this.optionTab.ResumeLayout(false);
            this.settingsTab.ResumeLayout(false);
            this.settingsTab.PerformLayout();
            this.groupBoxLogginOn.ResumeLayout(false);
            this.groupBoxLogginOn.PerformLayout();
            this.groupBoxOrderDesc.ResumeLayout(false);
            this.groupBoxOrderDesc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMenuItemAmount)).EndInit();
            this.tabAbout.ResumeLayout(false);
            this.tableLayoutAbout.ResumeLayout(false);
            this.tableLayoutAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAbout)).EndInit();
            this.groupAutostart.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl optionTab;
        private System.Windows.Forms.TabPage settingsTab;
        private System.Windows.Forms.Label labelMenuItemAmount;
        private System.Windows.Forms.TrackBar trackBarMenuItemAmount;
        private System.Windows.Forms.GroupBox groupBoxOrderDesc;
        private System.Windows.Forms.RadioButton radioOrderDesc2;
        private System.Windows.Forms.RadioButton radioOrderDesc1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.GroupBox groupBoxLogginOn;
        private System.Windows.Forms.CheckBox checkBoxLoggingOn;
        private System.Windows.Forms.Label labelTrackBarValue;
        private System.Windows.Forms.TabPage tabAbout;
        private System.Windows.Forms.TableLayoutPanel tableLayoutAbout;
        private System.Windows.Forms.Label labelProgramName;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.PictureBox pictureBoxAbout;
        private System.Windows.Forms.GroupBox groupAutostart;
        private System.Windows.Forms.Button buttonAutostart;
    }
}