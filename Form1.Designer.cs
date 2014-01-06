namespace EmptyMp3FolderNuker
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbExts = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbRootFolder = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lbFolders = new System.Windows.Forms.ListBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnNuke = new System.Windows.Forms.Button();
            this.dlgFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Music File Exts";
            // 
            // tbExts
            // 
            this.tbExts.Location = new System.Drawing.Point(101, 13);
            this.tbExts.Name = "tbExts";
            this.tbExts.Size = new System.Drawing.Size(538, 20);
            this.tbExts.TabIndex = 1;
            this.tbExts.Text = "mp3,wma,ogg,aac,m4a,mpc,ape,flac,vqf,wav";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Folder to Clean";
            // 
            // tbRootFolder
            // 
            this.tbRootFolder.Enabled = false;
            this.tbRootFolder.Location = new System.Drawing.Point(101, 40);
            this.tbRootFolder.Name = "tbRootFolder";
            this.tbRootFolder.Size = new System.Drawing.Size(455, 20);
            this.tbRootFolder.TabIndex = 3;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(564, 40);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lbFolders
            // 
            this.lbFolders.FormattingEnabled = true;
            this.lbFolders.Location = new System.Drawing.Point(13, 97);
            this.lbFolders.Name = "lbFolders";
            this.lbFolders.Size = new System.Drawing.Size(623, 303);
            this.lbFolders.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(13, 68);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnNuke
            // 
            this.btnNuke.Location = new System.Drawing.Point(94, 68);
            this.btnNuke.Name = "btnNuke";
            this.btnNuke.Size = new System.Drawing.Size(75, 23);
            this.btnNuke.TabIndex = 7;
            this.btnNuke.Text = "Nuke All";
            this.btnNuke.UseVisualStyleBackColor = true;
            this.btnNuke.Click += new System.EventHandler(this.btnNuke_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 414);
            this.Controls.Add(this.btnNuke);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lbFolders);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.tbRootFolder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbExts);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Empty MP3 Folder Nuker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbExts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbRootFolder;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.ListBox lbFolders;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnNuke;
        private System.Windows.Forms.FolderBrowserDialog dlgFolder;
    }
}

