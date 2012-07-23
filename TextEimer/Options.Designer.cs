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
            this.groupBoxLogginOn = new System.Windows.Forms.GroupBox();
            this.checkBoxLoggingOn = new System.Windows.Forms.CheckBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxOrderDesc = new System.Windows.Forms.GroupBox();
            this.radioOrderDesc2 = new System.Windows.Forms.RadioButton();
            this.radioOrderDesc1 = new System.Windows.Forms.RadioButton();
            this.trackBarMenuItemAmount = new System.Windows.Forms.TrackBar();
            this.labelMenuItemAmount = new System.Windows.Forms.Label();
            this.optionTab.SuspendLayout();
            this.settingsTab.SuspendLayout();
            this.groupBoxLogginOn.SuspendLayout();
            this.groupBoxOrderDesc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMenuItemAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // optionTab
            // 
            this.optionTab.Controls.Add(this.settingsTab);
            this.optionTab.Location = new System.Drawing.Point(1, 1);
            this.optionTab.Name = "optionTab";
            this.optionTab.SelectedIndex = 0;
            this.optionTab.Size = new System.Drawing.Size(572, 361);
            this.optionTab.TabIndex = 0;
            // 
            // settingsTab
            // 
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
            this.settingsTab.UseVisualStyleBackColor = true;
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
    }
}