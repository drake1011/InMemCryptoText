namespace InMemCryptoText.SaveAll.WinForms
{
    partial class frmMain
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
            this.lblDecrypt = new System.Windows.Forms.Label();
            this.btnOpenEncryptedFile = new System.Windows.Forms.Button();
            this.txtEncryptedFileLocation = new System.Windows.Forms.TextBox();
            this.openFileDialogEnc = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogEnc = new System.Windows.Forms.SaveFileDialog();
            this.lblDecryptPassword = new System.Windows.Forms.Label();
            this.txtDecryptPassword = new System.Windows.Forms.TextBox();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.txtEncryptPassword = new System.Windows.Forms.TextBox();
            this.lblEncryptPassword = new System.Windows.Forms.Label();
            this.txtTextFileLocation = new System.Windows.Forms.TextBox();
            this.btnOpenTextFile = new System.Windows.Forms.Button();
            this.lblEncrypt = new System.Windows.Forms.Label();
            this.openFileDialogTxt = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogTxt = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // lblDecrypt
            // 
            this.lblDecrypt.AutoSize = true;
            this.lblDecrypt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecrypt.Location = new System.Drawing.Point(154, 24);
            this.lblDecrypt.Name = "lblDecrypt";
            this.lblDecrypt.Size = new System.Drawing.Size(48, 15);
            this.lblDecrypt.TabIndex = 0;
            this.lblDecrypt.Text = "Decrypt";
            // 
            // btnOpenEncryptedFile
            // 
            this.btnOpenEncryptedFile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenEncryptedFile.Location = new System.Drawing.Point(12, 51);
            this.btnOpenEncryptedFile.Name = "btnOpenEncryptedFile";
            this.btnOpenEncryptedFile.Size = new System.Drawing.Size(121, 23);
            this.btnOpenEncryptedFile.TabIndex = 1;
            this.btnOpenEncryptedFile.Text = "Open Encrypted File";
            this.btnOpenEncryptedFile.UseVisualStyleBackColor = true;
            this.btnOpenEncryptedFile.Click += new System.EventHandler(this.btnOpenEncryptedFile_Click);
            // 
            // txtEncryptedFileLocation
            // 
            this.txtEncryptedFileLocation.Enabled = false;
            this.txtEncryptedFileLocation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEncryptedFileLocation.Location = new System.Drawing.Point(139, 52);
            this.txtEncryptedFileLocation.Name = "txtEncryptedFileLocation";
            this.txtEncryptedFileLocation.Size = new System.Drawing.Size(308, 23);
            this.txtEncryptedFileLocation.TabIndex = 2;
            // 
            // lblDecryptPassword
            // 
            this.lblDecryptPassword.AutoSize = true;
            this.lblDecryptPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecryptPassword.Location = new System.Drawing.Point(80, 82);
            this.lblDecryptPassword.Name = "lblDecryptPassword";
            this.lblDecryptPassword.Size = new System.Drawing.Size(57, 15);
            this.lblDecryptPassword.TabIndex = 3;
            this.lblDecryptPassword.Text = "Password";
            // 
            // txtDecryptPassword
            // 
            this.txtDecryptPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDecryptPassword.Location = new System.Drawing.Point(139, 79);
            this.txtDecryptPassword.Name = "txtDecryptPassword";
            this.txtDecryptPassword.Size = new System.Drawing.Size(200, 23);
            this.txtDecryptPassword.TabIndex = 4;
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecrypt.Location = new System.Drawing.Point(344, 81);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(103, 23);
            this.btnDecrypt.TabIndex = 5;
            this.btnDecrypt.Text = "Decrypt + Save";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncrypt.Location = new System.Drawing.Point(344, 193);
            this.btnEncrypt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(103, 23);
            this.btnEncrypt.TabIndex = 11;
            this.btnEncrypt.Text = "Encrypt + Save";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // txtEncryptPassword
            // 
            this.txtEncryptPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEncryptPassword.Location = new System.Drawing.Point(139, 194);
            this.txtEncryptPassword.Name = "txtEncryptPassword";
            this.txtEncryptPassword.Size = new System.Drawing.Size(200, 23);
            this.txtEncryptPassword.TabIndex = 10;
            // 
            // lblEncryptPassword
            // 
            this.lblEncryptPassword.AutoSize = true;
            this.lblEncryptPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncryptPassword.Location = new System.Drawing.Point(80, 197);
            this.lblEncryptPassword.Name = "lblEncryptPassword";
            this.lblEncryptPassword.Size = new System.Drawing.Size(57, 15);
            this.lblEncryptPassword.TabIndex = 9;
            this.lblEncryptPassword.Text = "Password";
            // 
            // txtTextFileLocation
            // 
            this.txtTextFileLocation.Enabled = false;
            this.txtTextFileLocation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTextFileLocation.Location = new System.Drawing.Point(139, 167);
            this.txtTextFileLocation.Name = "txtTextFileLocation";
            this.txtTextFileLocation.Size = new System.Drawing.Size(308, 23);
            this.txtTextFileLocation.TabIndex = 8;
            // 
            // btnOpenTextFile
            // 
            this.btnOpenTextFile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenTextFile.Location = new System.Drawing.Point(12, 165);
            this.btnOpenTextFile.Name = "btnOpenTextFile";
            this.btnOpenTextFile.Size = new System.Drawing.Size(121, 23);
            this.btnOpenTextFile.TabIndex = 7;
            this.btnOpenTextFile.Text = "Open Text File";
            this.btnOpenTextFile.UseVisualStyleBackColor = true;
            this.btnOpenTextFile.Click += new System.EventHandler(this.btnOpenTextFile_Click);
            // 
            // lblEncrypt
            // 
            this.lblEncrypt.AutoSize = true;
            this.lblEncrypt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncrypt.Location = new System.Drawing.Point(154, 139);
            this.lblEncrypt.Name = "lblEncrypt";
            this.lblEncrypt.Size = new System.Drawing.Size(47, 15);
            this.lblEncrypt.TabIndex = 6;
            this.lblEncrypt.Text = "Encrypt";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 229);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.txtEncryptPassword);
            this.Controls.Add(this.lblEncryptPassword);
            this.Controls.Add(this.txtTextFileLocation);
            this.Controls.Add(this.btnOpenTextFile);
            this.Controls.Add(this.lblEncrypt);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.txtDecryptPassword);
            this.Controls.Add(this.lblDecryptPassword);
            this.Controls.Add(this.txtEncryptedFileLocation);
            this.Controls.Add(this.btnOpenEncryptedFile);
            this.Controls.Add(this.lblDecrypt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Encrypt / Decrypt Text Files";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDecrypt;
        private System.Windows.Forms.Button btnOpenEncryptedFile;
        private System.Windows.Forms.TextBox txtEncryptedFileLocation;
        private System.Windows.Forms.OpenFileDialog openFileDialogEnc;
        private System.Windows.Forms.SaveFileDialog saveFileDialogEnc;
        private System.Windows.Forms.Label lblDecryptPassword;
        private System.Windows.Forms.TextBox txtDecryptPassword;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.TextBox txtEncryptPassword;
        private System.Windows.Forms.Label lblEncryptPassword;
        private System.Windows.Forms.TextBox txtTextFileLocation;
        private System.Windows.Forms.Button btnOpenTextFile;
        private System.Windows.Forms.Label lblEncrypt;
        private System.Windows.Forms.OpenFileDialog openFileDialogTxt;
        private System.Windows.Forms.SaveFileDialog saveFileDialogTxt;
    }
}

