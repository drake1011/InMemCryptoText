namespace InMemCryptoText.WinFormsCore
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSelectDecryptFile = new System.Windows.Forms.Button();
            this.lblDecrypt = new System.Windows.Forms.Label();
            this.txtEncryptedFileLocation = new System.Windows.Forms.TextBox();
            this.txtDecryptedText = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnSelectEncryptFile = new System.Windows.Forms.Button();
            this.lblEncrypt = new System.Windows.Forms.Label();
            this.lblEncryptPassword = new System.Windows.Forms.Label();
            this.txtEncryptPassword = new System.Windows.Forms.TextBox();
            this.txtSaveNewEncryptedFile = new System.Windows.Forms.TextBox();
            this.lblEncryptFile = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.msiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiClear = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelectDecryptFile
            // 
            this.btnSelectDecryptFile.Location = new System.Drawing.Point(472, 50);
            this.btnSelectDecryptFile.Name = "btnSelectDecryptFile";
            this.btnSelectDecryptFile.Size = new System.Drawing.Size(75, 23);
            this.btnSelectDecryptFile.TabIndex = 0;
            this.btnSelectDecryptFile.Text = "Select File";
            this.btnSelectDecryptFile.UseVisualStyleBackColor = true;
            this.btnSelectDecryptFile.Click += new System.EventHandler(this.btnSelectDecryptFile_Click);
            // 
            // lblDecrypt
            // 
            this.lblDecrypt.AutoSize = true;
            this.lblDecrypt.Location = new System.Drawing.Point(595, 29);
            this.lblDecrypt.Name = "lblDecrypt";
            this.lblDecrypt.Size = new System.Drawing.Size(48, 15);
            this.lblDecrypt.TabIndex = 1;
            this.lblDecrypt.Text = "Decrypt";
            // 
            // txtEncryptedFileLocation
            // 
            this.txtEncryptedFileLocation.Enabled = false;
            this.txtEncryptedFileLocation.Location = new System.Drawing.Point(553, 50);
            this.txtEncryptedFileLocation.Name = "txtEncryptedFileLocation";
            this.txtEncryptedFileLocation.Size = new System.Drawing.Size(429, 23);
            this.txtEncryptedFileLocation.TabIndex = 2;
            this.txtEncryptedFileLocation.TabStop = false;
            // 
            // txtDecryptedText
            // 
            this.txtDecryptedText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDecryptedText.Location = new System.Drawing.Point(0, 0);
            this.txtDecryptedText.Multiline = true;
            this.txtDecryptedText.Name = "txtDecryptedText";
            this.txtDecryptedText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDecryptedText.Size = new System.Drawing.Size(1393, 505);
            this.txtDecryptedText.TabIndex = 3;
            this.txtDecryptedText.WordWrap = false;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(490, 82);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(57, 15);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password";
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(907, 78);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(75, 23);
            this.btnDecrypt.TabIndex = 0;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(553, 79);
            this.txtPassword.MaxLength = 50;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '•';
            this.txtPassword.Size = new System.Drawing.Size(348, 23);
            this.txtPassword.TabIndex = 2;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnEncrypt.Location = new System.Drawing.Point(1393, 0);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(75, 505);
            this.btnEncrypt.TabIndex = 0;
            this.btnEncrypt.Text = "Enrypt \r\nand\r\nSave";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnSelectEncryptFile);
            this.splitContainer1.Panel1.Controls.Add(this.lblEncrypt);
            this.splitContainer1.Panel1.Controls.Add(this.lblEncryptPassword);
            this.splitContainer1.Panel1.Controls.Add(this.txtEncryptPassword);
            this.splitContainer1.Panel1.Controls.Add(this.txtSaveNewEncryptedFile);
            this.splitContainer1.Panel1.Controls.Add(this.lblEncryptFile);
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
            this.splitContainer1.Panel1.Controls.Add(this.lblPassword);
            this.splitContainer1.Panel1.Controls.Add(this.btnSelectDecryptFile);
            this.splitContainer1.Panel1.Controls.Add(this.lblDecrypt);
            this.splitContainer1.Panel1.Controls.Add(this.txtEncryptedFileLocation);
            this.splitContainer1.Panel1.Controls.Add(this.btnDecrypt);
            this.splitContainer1.Panel1.Controls.Add(this.txtPassword);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtDecryptedText);
            this.splitContainer1.Panel2.Controls.Add(this.btnEncrypt);
            this.splitContainer1.Size = new System.Drawing.Size(1468, 709);
            this.splitContainer1.SplitterDistance = 200;
            this.splitContainer1.TabIndex = 4;
            this.splitContainer1.Text = "splitContainer1";
            // 
            // btnSelectEncryptFile
            // 
            this.btnSelectEncryptFile.Location = new System.Drawing.Point(988, 139);
            this.btnSelectEncryptFile.Name = "btnSelectEncryptFile";
            this.btnSelectEncryptFile.Size = new System.Drawing.Size(104, 23);
            this.btnSelectEncryptFile.TabIndex = 0;
            this.btnSelectEncryptFile.Text = "Select New File";
            this.btnSelectEncryptFile.UseVisualStyleBackColor = true;
            this.btnSelectEncryptFile.Click += new System.EventHandler(this.btnSelectEncryptFile_Click);
            // 
            // lblEncrypt
            // 
            this.lblEncrypt.AutoSize = true;
            this.lblEncrypt.Location = new System.Drawing.Point(595, 122);
            this.lblEncrypt.Name = "lblEncrypt";
            this.lblEncrypt.Size = new System.Drawing.Size(47, 15);
            this.lblEncrypt.TabIndex = 1;
            this.lblEncrypt.Text = "Encrypt";
            // 
            // lblEncryptPassword
            // 
            this.lblEncryptPassword.AutoSize = true;
            this.lblEncryptPassword.Location = new System.Drawing.Point(490, 171);
            this.lblEncryptPassword.Name = "lblEncryptPassword";
            this.lblEncryptPassword.Size = new System.Drawing.Size(57, 15);
            this.lblEncryptPassword.TabIndex = 1;
            this.lblEncryptPassword.Text = "Password";
            // 
            // txtEncryptPassword
            // 
            this.txtEncryptPassword.Location = new System.Drawing.Point(553, 168);
            this.txtEncryptPassword.MaxLength = 50;
            this.txtEncryptPassword.Name = "txtEncryptPassword";
            this.txtEncryptPassword.PasswordChar = '•';
            this.txtEncryptPassword.Size = new System.Drawing.Size(348, 23);
            this.txtEncryptPassword.TabIndex = 2;
            // 
            // txtSaveNewEncryptedFile
            // 
            this.txtSaveNewEncryptedFile.Enabled = false;
            this.txtSaveNewEncryptedFile.Location = new System.Drawing.Point(553, 140);
            this.txtSaveNewEncryptedFile.Name = "txtSaveNewEncryptedFile";
            this.txtSaveNewEncryptedFile.Size = new System.Drawing.Size(429, 23);
            this.txtSaveNewEncryptedFile.TabIndex = 2;
            this.txtSaveNewEncryptedFile.TabStop = false;
            // 
            // lblEncryptFile
            // 
            this.lblEncryptFile.AutoSize = true;
            this.lblEncryptFile.Location = new System.Drawing.Point(466, 143);
            this.lblEncryptFile.Name = "lblEncryptFile";
            this.lblEncryptFile.Size = new System.Drawing.Size(81, 15);
            this.lblEncryptFile.TabIndex = 1;
            this.lblEncryptFile.Text = "Encrypted File";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1468, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // msiFile
            // 
            this.msiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiClear});
            this.msiFile.Name = "msiFile";
            this.msiFile.Size = new System.Drawing.Size(37, 20);
            this.msiFile.Text = "File";
            // 
            // tsmiClear
            // 
            this.tsmiClear.Name = "tsmiClear";
            this.tsmiClear.Size = new System.Drawing.Size(101, 22);
            this.tsmiClear.Text = "Clear";
            this.tsmiClear.Click += new System.EventHandler(this.tsmiClear_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1468, 709);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Encrypt / Decrypt Text In Mem";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSelectDecryptFile;
        private System.Windows.Forms.Label lblDecrypt;
        private System.Windows.Forms.TextBox txtEncryptedFileLocation;
        private System.Windows.Forms.TextBox txtDecryptedText;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem msiFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiClear;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblEncryptFile;
        private System.Windows.Forms.TextBox txtSaveNewEncryptedFile;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label lblEncryptPassword;
        private System.Windows.Forms.TextBox txtEncryptPassword;
        private System.Windows.Forms.Label lblEncrypt;
        private System.Windows.Forms.Button btnSelectEncryptFile;
    }
}

