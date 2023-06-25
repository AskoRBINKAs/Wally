namespace Wally.Forms
{
    partial class CreatorForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.IsWebBox = new System.Windows.Forms.CheckBox();
            this.CreateButton = new System.Windows.Forms.Button();
            this.AddPreviewPath = new System.Windows.Forms.Button();
            this.AddVideoButton = new System.Windows.Forms.Button();
            this.PreviewPathBox = new System.Windows.Forms.TextBox();
            this.PreviewLabel = new System.Windows.Forms.Label();
            this.VideoPathBox = new System.Windows.Forms.TextBox();
            this.VideoLabel = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.TitleCreatorForm = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.IsWebBox);
            this.panel1.Controls.Add(this.CreateButton);
            this.panel1.Controls.Add(this.AddPreviewPath);
            this.panel1.Controls.Add(this.AddVideoButton);
            this.panel1.Controls.Add(this.PreviewPathBox);
            this.panel1.Controls.Add(this.PreviewLabel);
            this.panel1.Controls.Add(this.VideoPathBox);
            this.panel1.Controls.Add(this.VideoLabel);
            this.panel1.Controls.Add(this.NameBox);
            this.panel1.Controls.Add(this.TitleCreatorForm);
            this.panel1.Controls.Add(this.NameLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1168, 571);
            this.panel1.TabIndex = 0;
            // 
            // IsWebBox
            // 
            this.IsWebBox.AutoSize = true;
            this.IsWebBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.IsWebBox.ForeColor = System.Drawing.SystemColors.Control;
            this.IsWebBox.Location = new System.Drawing.Point(599, 111);
            this.IsWebBox.Name = "IsWebBox";
            this.IsWebBox.Size = new System.Drawing.Size(104, 19);
            this.IsWebBox.TabIndex = 10;
            this.IsWebBox.Text = "WEB wallpaper";
            this.IsWebBox.UseVisualStyleBackColor = false;
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(85, 195);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(133, 23);
            this.CreateButton.TabIndex = 9;
            this.CreateButton.Text = "Create";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // AddPreviewPath
            // 
            this.AddPreviewPath.Location = new System.Drawing.Point(504, 149);
            this.AddPreviewPath.Name = "AddPreviewPath";
            this.AddPreviewPath.Size = new System.Drawing.Size(75, 23);
            this.AddPreviewPath.TabIndex = 8;
            this.AddPreviewPath.Text = "Add";
            this.AddPreviewPath.UseVisualStyleBackColor = true;
            this.AddPreviewPath.Click += new System.EventHandler(this.AddPreviewPath_Click);
            // 
            // AddVideoButton
            // 
            this.AddVideoButton.Location = new System.Drawing.Point(504, 109);
            this.AddVideoButton.Name = "AddVideoButton";
            this.AddVideoButton.Size = new System.Drawing.Size(75, 23);
            this.AddVideoButton.TabIndex = 7;
            this.AddVideoButton.Text = "Add";
            this.AddVideoButton.UseVisualStyleBackColor = true;
            this.AddVideoButton.Click += new System.EventHandler(this.AddVideoButton_Click);
            // 
            // PreviewPathBox
            // 
            this.PreviewPathBox.Location = new System.Drawing.Point(85, 148);
            this.PreviewPathBox.Name = "PreviewPathBox";
            this.PreviewPathBox.ReadOnly = true;
            this.PreviewPathBox.Size = new System.Drawing.Size(394, 23);
            this.PreviewPathBox.TabIndex = 6;
            // 
            // PreviewLabel
            // 
            this.PreviewLabel.AutoSize = true;
            this.PreviewLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PreviewLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PreviewLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.PreviewLabel.Location = new System.Drawing.Point(12, 148);
            this.PreviewLabel.Name = "PreviewLabel";
            this.PreviewLabel.Size = new System.Drawing.Size(65, 21);
            this.PreviewLabel.TabIndex = 5;
            this.PreviewLabel.Text = "Preview";
            // 
            // VideoPathBox
            // 
            this.VideoPathBox.Location = new System.Drawing.Point(85, 109);
            this.VideoPathBox.Name = "VideoPathBox";
            this.VideoPathBox.Size = new System.Drawing.Size(394, 23);
            this.VideoPathBox.TabIndex = 4;
            // 
            // VideoLabel
            // 
            this.VideoLabel.AutoSize = true;
            this.VideoLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.VideoLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VideoLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.VideoLabel.Location = new System.Drawing.Point(12, 108);
            this.VideoLabel.Name = "VideoLabel";
            this.VideoLabel.Size = new System.Drawing.Size(50, 21);
            this.VideoLabel.TabIndex = 3;
            this.VideoLabel.Text = "Video";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(85, 70);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(394, 23);
            this.NameBox.TabIndex = 2;
            // 
            // TitleCreatorForm
            // 
            this.TitleCreatorForm.AutoSize = true;
            this.TitleCreatorForm.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TitleCreatorForm.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TitleCreatorForm.ForeColor = System.Drawing.SystemColors.Control;
            this.TitleCreatorForm.Location = new System.Drawing.Point(12, 9);
            this.TitleCreatorForm.Name = "TitleCreatorForm";
            this.TitleCreatorForm.Size = new System.Drawing.Size(281, 40);
            this.TitleCreatorForm.TabIndex = 1;
            this.TitleCreatorForm.Text = "Add new wallpaper";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.NameLabel.Location = new System.Drawing.Point(12, 70);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(52, 21);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name";
            // 
            // CreatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 571);
            this.Controls.Add(this.panel1);
            this.Name = "CreatorForm";
            this.Text = "CreatorForm";
            this.Load += new System.EventHandler(this.CreatorForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label TitleCreatorForm;
        private Label NameLabel;
        private Button AddPreviewPath;
        private Button AddVideoButton;
        private TextBox PreviewPathBox;
        private Label PreviewLabel;
        private TextBox VideoPathBox;
        private Label VideoLabel;
        private TextBox NameBox;
        private Button CreateButton;
        private CheckBox IsWebBox;
    }
}