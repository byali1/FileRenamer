namespace FileRenamer
{
    partial class FileRenamer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileRenamer));
            this.lblPath = new System.Windows.Forms.Label();
            this.txtBoxPath = new System.Windows.Forms.TextBox();
            this.btnGetPath = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnRun = new System.Windows.Forms.Button();
            this.txtBoxFileName = new System.Windows.Forms.TextBox();
            this.lblFileName = new System.Windows.Forms.Label();
            this.checkBoxSaveExtension = new System.Windows.Forms.CheckBox();
            this.lblAnnouncement = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPath.Location = new System.Drawing.Point(12, 96);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(39, 17);
            this.lblPath.TabIndex = 0;
            this.lblPath.Text = "Path:";
            // 
            // txtBoxPath
            // 
            this.txtBoxPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxPath.Location = new System.Drawing.Point(57, 94);
            this.txtBoxPath.Name = "txtBoxPath";
            this.txtBoxPath.ReadOnly = true;
            this.txtBoxPath.Size = new System.Drawing.Size(359, 21);
            this.txtBoxPath.TabIndex = 1;
            // 
            // btnGetPath
            // 
            this.btnGetPath.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGetPath.Location = new System.Drawing.Point(422, 92);
            this.btnGetPath.Name = "btnGetPath";
            this.btnGetPath.Size = new System.Drawing.Size(83, 25);
            this.btnGetPath.TabIndex = 2;
            this.btnGetPath.Text = "Select";
            this.btnGetPath.UseVisualStyleBackColor = true;
            this.btnGetPath.Click += new System.EventHandler(this.btnGetPath_Click);
            // 
            // btnRun
            // 
            this.btnRun.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRun.Location = new System.Drawing.Point(182, 134);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(126, 25);
            this.btnRun.TabIndex = 3;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // txtBoxFileName
            // 
            this.txtBoxFileName.Location = new System.Drawing.Point(160, 58);
            this.txtBoxFileName.Name = "txtBoxFileName";
            this.txtBoxFileName.Size = new System.Drawing.Size(218, 20);
            this.txtBoxFileName.TabIndex = 4;
            this.txtBoxFileName.TextChanged += new System.EventHandler(this.txtBoxFileName_TextChanged);
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileName.Location = new System.Drawing.Point(85, 58);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(69, 17);
            this.lblFileName.TabIndex = 5;
            this.lblFileName.Text = "File Name:";
            // 
            // checkBoxSaveExtension
            // 
            this.checkBoxSaveExtension.AutoSize = true;
            this.checkBoxSaveExtension.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxSaveExtension.Location = new System.Drawing.Point(171, 21);
            this.checkBoxSaveExtension.Name = "checkBoxSaveExtension";
            this.checkBoxSaveExtension.Size = new System.Drawing.Size(170, 19);
            this.checkBoxSaveExtension.TabIndex = 6;
            this.checkBoxSaveExtension.Text = "Protect the extension of file";
            this.checkBoxSaveExtension.UseVisualStyleBackColor = true;
            // 
            // lblAnnouncement
            // 
            this.lblAnnouncement.AutoSize = true;
            this.lblAnnouncement.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAnnouncement.Location = new System.Drawing.Point(42, 191);
            this.lblAnnouncement.Name = "lblAnnouncement";
            this.lblAnnouncement.Size = new System.Drawing.Size(435, 15);
            this.lblAnnouncement.TabIndex = 7;
            this.lblAnnouncement.Text = "If you dont select the check box, it will be changed to \'.jpg\' extension of your " +
    "files";
            // 
            // FileRenamer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 215);
            this.Controls.Add(this.lblAnnouncement);
            this.Controls.Add(this.checkBoxSaveExtension);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.txtBoxFileName);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.btnGetPath);
            this.Controls.Add(this.txtBoxPath);
            this.Controls.Add(this.lblPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FileRenamer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Renamer";
            this.Load += new System.EventHandler(this.FileRenamer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.TextBox txtBoxPath;
        private System.Windows.Forms.Button btnGetPath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.TextBox txtBoxFileName;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.CheckBox checkBoxSaveExtension;
        private System.Windows.Forms.Label lblAnnouncement;
    }
}

