namespace Wally.Forms
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SettingsPanel = new System.Windows.Forms.Panel();
            this.LanguageLabel = new System.Windows.Forms.Label();
            this.LanguageBox = new System.Windows.Forms.ComboBox();
            this.StartupBox = new System.Windows.Forms.CheckBox();
            this.DebugPanel = new System.Windows.Forms.Panel();
            this.LogLabel = new System.Windows.Forms.Label();
            this.LoggingBox = new System.Windows.Forms.TextBox();
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SettingsPanel.SuspendLayout();
            this.DebugPanel.SuspendLayout();
            this.InfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SettingsPanel
            // 
            this.SettingsPanel.Controls.Add(this.LanguageLabel);
            this.SettingsPanel.Controls.Add(this.LanguageBox);
            this.SettingsPanel.Controls.Add(this.StartupBox);
            this.SettingsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SettingsPanel.Location = new System.Drawing.Point(0, 0);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.Size = new System.Drawing.Size(1168, 105);
            this.SettingsPanel.TabIndex = 0;
            // 
            // LanguageLabel
            // 
            this.LanguageLabel.AutoSize = true;
            this.LanguageLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.LanguageLabel.Location = new System.Drawing.Point(1035, 10);
            this.LanguageLabel.Name = "LanguageLabel";
            this.LanguageLabel.Size = new System.Drawing.Size(90, 15);
            this.LanguageLabel.TabIndex = 2;
            this.LanguageLabel.Text = "Select language";
            // 
            // LanguageBox
            // 
            this.LanguageBox.FormattingEnabled = true;
            this.LanguageBox.Location = new System.Drawing.Point(1035, 34);
            this.LanguageBox.Name = "LanguageBox";
            this.LanguageBox.Size = new System.Drawing.Size(121, 23);
            this.LanguageBox.TabIndex = 1;
            this.LanguageBox.SelectedIndexChanged += new System.EventHandler(this.LanguageBox_SelectedIndexChanged);
            // 
            // StartupBox
            // 
            this.StartupBox.AutoSize = true;
            this.StartupBox.ForeColor = System.Drawing.SystemColors.Control;
            this.StartupBox.Location = new System.Drawing.Point(12, 12);
            this.StartupBox.Name = "StartupBox";
            this.StartupBox.Size = new System.Drawing.Size(142, 19);
            this.StartupBox.TabIndex = 0;
            this.StartupBox.Text = "Startup with Windows";
            this.StartupBox.UseVisualStyleBackColor = true;
            this.StartupBox.CheckedChanged += new System.EventHandler(this.StartupBox_CheckedChanged);
            // 
            // DebugPanel
            // 
            this.DebugPanel.Controls.Add(this.LogLabel);
            this.DebugPanel.Controls.Add(this.LoggingBox);
            this.DebugPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DebugPanel.Location = new System.Drawing.Point(0, 105);
            this.DebugPanel.Name = "DebugPanel";
            this.DebugPanel.Size = new System.Drawing.Size(1168, 466);
            this.DebugPanel.TabIndex = 1;
            // 
            // LogLabel
            // 
            this.LogLabel.AutoSize = true;
            this.LogLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.LogLabel.Location = new System.Drawing.Point(12, 8);
            this.LogLabel.Name = "LogLabel";
            this.LogLabel.Size = new System.Drawing.Size(35, 15);
            this.LogLabel.TabIndex = 1;
            this.LogLabel.Text = "Logs:";
            // 
            // LoggingBox
            // 
            this.LoggingBox.Location = new System.Drawing.Point(12, 26);
            this.LoggingBox.Multiline = true;
            this.LoggingBox.Name = "LoggingBox";
            this.LoggingBox.ReadOnly = true;
            this.LoggingBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.LoggingBox.Size = new System.Drawing.Size(1144, 387);
            this.LoggingBox.TabIndex = 0;
            // 
            // InfoPanel
            // 
            this.InfoPanel.Controls.Add(this.VersionLabel);
            this.InfoPanel.Controls.Add(this.label2);
            this.InfoPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.InfoPanel.Location = new System.Drawing.Point(0, 537);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(1168, 34);
            this.InfoPanel.TabIndex = 2;
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VersionLabel.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.VersionLabel.Location = new System.Drawing.Point(1127, 10);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(38, 15);
            this.VersionLabel.TabIndex = 1;
            this.VersionLabel.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(9, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "https://github.com/AskoRBINKAs/Wally";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 571);
            this.Controls.Add(this.InfoPanel);
            this.Controls.Add(this.DebugPanel);
            this.Controls.Add(this.SettingsPanel);
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.SettingsPanel.ResumeLayout(false);
            this.SettingsPanel.PerformLayout();
            this.DebugPanel.ResumeLayout(false);
            this.DebugPanel.PerformLayout();
            this.InfoPanel.ResumeLayout(false);
            this.InfoPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel SettingsPanel;
        private Panel DebugPanel;
        private Panel InfoPanel;
        private CheckBox StartupBox;
        private Label LogLabel;
        private TextBox LoggingBox;
        private Label label2;
        private Label VersionLabel;
        private Label LanguageLabel;
        private ComboBox LanguageBox;
    }
}