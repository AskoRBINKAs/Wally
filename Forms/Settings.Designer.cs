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
            this.DefaultSettedArgsLabel = new System.Windows.Forms.Label();
            this.MPVArgsLabel = new System.Windows.Forms.Label();
            this.ArgsFieldBox = new System.Windows.Forms.TextBox();
            this.VolumePercentLabel = new System.Windows.Forms.Label();
            this.VolumeLabel = new System.Windows.Forms.Label();
            this.VolumeTrackBar = new System.Windows.Forms.TrackBar();
            this.LogCheckBox = new System.Windows.Forms.CheckBox();
            this.SelectFPSLabel = new System.Windows.Forms.Label();
            this.FPSBox = new System.Windows.Forms.ComboBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.VolumeTrackBar)).BeginInit();
            this.DebugPanel.SuspendLayout();
            this.InfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SettingsPanel
            // 
            this.SettingsPanel.Controls.Add(this.DefaultSettedArgsLabel);
            this.SettingsPanel.Controls.Add(this.MPVArgsLabel);
            this.SettingsPanel.Controls.Add(this.ArgsFieldBox);
            this.SettingsPanel.Controls.Add(this.VolumePercentLabel);
            this.SettingsPanel.Controls.Add(this.VolumeLabel);
            this.SettingsPanel.Controls.Add(this.VolumeTrackBar);
            this.SettingsPanel.Controls.Add(this.LogCheckBox);
            this.SettingsPanel.Controls.Add(this.SelectFPSLabel);
            this.SettingsPanel.Controls.Add(this.FPSBox);
            this.SettingsPanel.Controls.Add(this.LanguageLabel);
            this.SettingsPanel.Controls.Add(this.LanguageBox);
            this.SettingsPanel.Controls.Add(this.StartupBox);
            this.SettingsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SettingsPanel.Location = new System.Drawing.Point(0, 0);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.Size = new System.Drawing.Size(1268, 387);
            this.SettingsPanel.TabIndex = 0;
            // 
            // DefaultSettedArgsLabel
            // 
            this.DefaultSettedArgsLabel.AutoSize = true;
            this.DefaultSettedArgsLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.DefaultSettedArgsLabel.Location = new System.Drawing.Point(17, 336);
            this.DefaultSettedArgsLabel.Name = "DefaultSettedArgsLabel";
            this.DefaultSettedArgsLabel.Size = new System.Drawing.Size(68, 15);
            this.DefaultSettedArgsLabel.TabIndex = 11;
            this.DefaultSettedArgsLabel.Text = "Setted args:";
            // 
            // MPVArgsLabel
            // 
            this.MPVArgsLabel.AutoSize = true;
            this.MPVArgsLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.MPVArgsLabel.Location = new System.Drawing.Point(17, 292);
            this.MPVArgsLabel.Name = "MPVArgsLabel";
            this.MPVArgsLabel.Size = new System.Drawing.Size(234, 15);
            this.MPVArgsLabel.TabIndex = 10;
            this.MPVArgsLabel.Text = "MPV additional argumets (only for experts)";
            // 
            // ArgsFieldBox
            // 
            this.ArgsFieldBox.Location = new System.Drawing.Point(17, 310);
            this.ArgsFieldBox.Name = "ArgsFieldBox";
            this.ArgsFieldBox.Size = new System.Drawing.Size(664, 23);
            this.ArgsFieldBox.TabIndex = 9;
            this.ArgsFieldBox.TextChanged += new System.EventHandler(this.ArgsFieldBox_TextChanged);
            // 
            // VolumePercentLabel
            // 
            this.VolumePercentLabel.AutoSize = true;
            this.VolumePercentLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.VolumePercentLabel.Location = new System.Drawing.Point(119, 228);
            this.VolumePercentLabel.Name = "VolumePercentLabel";
            this.VolumePercentLabel.Size = new System.Drawing.Size(47, 15);
            this.VolumePercentLabel.TabIndex = 8;
            this.VolumePercentLabel.Text = "Volume";
            // 
            // VolumeLabel
            // 
            this.VolumeLabel.AutoSize = true;
            this.VolumeLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.VolumeLabel.Location = new System.Drawing.Point(13, 200);
            this.VolumeLabel.Name = "VolumeLabel";
            this.VolumeLabel.Size = new System.Drawing.Size(47, 15);
            this.VolumeLabel.TabIndex = 7;
            this.VolumeLabel.Text = "Volume";
            // 
            // VolumeTrackBar
            // 
            this.VolumeTrackBar.Location = new System.Drawing.Point(9, 218);
            this.VolumeTrackBar.Maximum = 100;
            this.VolumeTrackBar.Name = "VolumeTrackBar";
            this.VolumeTrackBar.Size = new System.Drawing.Size(104, 45);
            this.VolumeTrackBar.TabIndex = 6;
            this.VolumeTrackBar.Scroll += new System.EventHandler(this.VolumeTrackBar_Scroll);
            // 
            // LogCheckBox
            // 
            this.LogCheckBox.AutoSize = true;
            this.LogCheckBox.ForeColor = System.Drawing.SystemColors.Control;
            this.LogCheckBox.Location = new System.Drawing.Point(12, 39);
            this.LogCheckBox.Name = "LogCheckBox";
            this.LogCheckBox.Size = new System.Drawing.Size(105, 19);
            this.LogCheckBox.TabIndex = 5;
            this.LogCheckBox.Text = "Enable logging";
            this.LogCheckBox.UseVisualStyleBackColor = true;
            this.LogCheckBox.CheckedChanged += new System.EventHandler(this.LogCheckBox_CheckedChanged);
            // 
            // SelectFPSLabel
            // 
            this.SelectFPSLabel.AutoSize = true;
            this.SelectFPSLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.SelectFPSLabel.Location = new System.Drawing.Point(12, 134);
            this.SelectFPSLabel.Name = "SelectFPSLabel";
            this.SelectFPSLabel.Size = new System.Drawing.Size(26, 15);
            this.SelectFPSLabel.TabIndex = 4;
            this.SelectFPSLabel.Text = "FPS";
            // 
            // FPSBox
            // 
            this.FPSBox.FormattingEnabled = true;
            this.FPSBox.Location = new System.Drawing.Point(12, 162);
            this.FPSBox.Name = "FPSBox";
            this.FPSBox.Size = new System.Drawing.Size(121, 23);
            this.FPSBox.TabIndex = 3;
            this.FPSBox.SelectedIndexChanged += new System.EventHandler(this.FPSBox_SelectedIndexChanged);
            // 
            // LanguageLabel
            // 
            this.LanguageLabel.AutoSize = true;
            this.LanguageLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.LanguageLabel.Location = new System.Drawing.Point(12, 70);
            this.LanguageLabel.Name = "LanguageLabel";
            this.LanguageLabel.Size = new System.Drawing.Size(90, 15);
            this.LanguageLabel.TabIndex = 2;
            this.LanguageLabel.Text = "Select language";
            // 
            // LanguageBox
            // 
            this.LanguageBox.FormattingEnabled = true;
            this.LanguageBox.Location = new System.Drawing.Point(12, 94);
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
            this.DebugPanel.Location = new System.Drawing.Point(0, 387);
            this.DebugPanel.Name = "DebugPanel";
            this.DebugPanel.Size = new System.Drawing.Size(1268, 184);
            this.DebugPanel.TabIndex = 1;
            // 
            // LogLabel
            // 
            this.LogLabel.AutoSize = true;
            this.LogLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.LogLabel.Location = new System.Drawing.Point(12, 13);
            this.LogLabel.Name = "LogLabel";
            this.LogLabel.Size = new System.Drawing.Size(35, 15);
            this.LogLabel.TabIndex = 1;
            this.LogLabel.Text = "Logs:";
            // 
            // LoggingBox
            // 
            this.LoggingBox.Location = new System.Drawing.Point(12, 31);
            this.LoggingBox.Multiline = true;
            this.LoggingBox.Name = "LoggingBox";
            this.LoggingBox.ReadOnly = true;
            this.LoggingBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.LoggingBox.Size = new System.Drawing.Size(1244, 103);
            this.LoggingBox.TabIndex = 0;
            // 
            // InfoPanel
            // 
            this.InfoPanel.Controls.Add(this.VersionLabel);
            this.InfoPanel.Controls.Add(this.label2);
            this.InfoPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.InfoPanel.Location = new System.Drawing.Point(0, 537);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(1268, 34);
            this.InfoPanel.TabIndex = 2;
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VersionLabel.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.VersionLabel.Location = new System.Drawing.Point(1236, 10);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(29, 15);
            this.VersionLabel.TabIndex = 1;
            this.VersionLabel.Text = "V1.1";
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
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1268, 571);
            this.Controls.Add(this.InfoPanel);
            this.Controls.Add(this.DebugPanel);
            this.Controls.Add(this.SettingsPanel);
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.SettingsPanel.ResumeLayout(false);
            this.SettingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeTrackBar)).EndInit();
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
        private Label SelectFPSLabel;
        private ComboBox FPSBox;
        private CheckBox LogCheckBox;
        private Label VolumeLabel;
        private TrackBar VolumeTrackBar;
        private Label VolumePercentLabel;
        private Label DefaultSettedArgsLabel;
        private Label MPVArgsLabel;
        private TextBox ArgsFieldBox;
    }
}