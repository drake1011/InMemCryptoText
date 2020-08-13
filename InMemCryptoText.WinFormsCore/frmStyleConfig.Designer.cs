namespace InMemCryptoText.WinFormsCore
{
    partial class frmStyleConfig
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
            this.btnOpenFontDialog = new System.Windows.Forms.Button();
            this.btnOpenColorDialogForeColor = new System.Windows.Forms.Button();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.colorDialogForeColor = new System.Windows.Forms.ColorDialog();
            this.colorDialogBackColor = new System.Windows.Forms.ColorDialog();
            this.btnOpenColorDialogBackColor = new System.Windows.Forms.Button();
            this.pbForeColor = new System.Windows.Forms.PictureBox();
            this.pbBackColor = new System.Windows.Forms.PictureBox();
            this.txtFontName = new System.Windows.Forms.TextBox();
            this.btnSaveAndClose = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtFontSize = new System.Windows.Forms.TextBox();
            this.lblFontName = new System.Windows.Forms.Label();
            this.lblFontSize = new System.Windows.Forms.Label();
            this.grpBoxFont = new System.Windows.Forms.GroupBox();
            this.chkFontUnderline = new System.Windows.Forms.CheckBox();
            this.chkFontItalic = new System.Windows.Forms.CheckBox();
            this.chkFontBold = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbForeColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackColor)).BeginInit();
            this.grpBoxFont.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOpenFontDialog
            // 
            this.btnOpenFontDialog.Location = new System.Drawing.Point(132, 91);
            this.btnOpenFontDialog.Name = "btnOpenFontDialog";
            this.btnOpenFontDialog.Size = new System.Drawing.Size(75, 23);
            this.btnOpenFontDialog.TabIndex = 0;
            this.btnOpenFontDialog.Text = "Font";
            this.btnOpenFontDialog.UseVisualStyleBackColor = true;
            this.btnOpenFontDialog.Click += new System.EventHandler(this.btnOpenFontDialog_Click);
            // 
            // btnOpenColorDialogForeColor
            // 
            this.btnOpenColorDialogForeColor.Location = new System.Drawing.Point(20, 31);
            this.btnOpenColorDialogForeColor.Name = "btnOpenColorDialogForeColor";
            this.btnOpenColorDialogForeColor.Size = new System.Drawing.Size(75, 30);
            this.btnOpenColorDialogForeColor.TabIndex = 1;
            this.btnOpenColorDialogForeColor.Text = "Fore Color";
            this.btnOpenColorDialogForeColor.UseVisualStyleBackColor = true;
            this.btnOpenColorDialogForeColor.Click += new System.EventHandler(this.btnOpenColorDialogForeColor_Click);
            // 
            // btnOpenColorDialogBackColor
            // 
            this.btnOpenColorDialogBackColor.Location = new System.Drawing.Point(20, 83);
            this.btnOpenColorDialogBackColor.Name = "btnOpenColorDialogBackColor";
            this.btnOpenColorDialogBackColor.Size = new System.Drawing.Size(75, 30);
            this.btnOpenColorDialogBackColor.TabIndex = 1;
            this.btnOpenColorDialogBackColor.Text = "Back Color";
            this.btnOpenColorDialogBackColor.UseVisualStyleBackColor = true;
            this.btnOpenColorDialogBackColor.Click += new System.EventHandler(this.btnOpenColorDialogBackColor_Click);
            // 
            // pbForeColor
            // 
            this.pbForeColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbForeColor.Location = new System.Drawing.Point(145, 31);
            this.pbForeColor.Name = "pbForeColor";
            this.pbForeColor.Size = new System.Drawing.Size(30, 30);
            this.pbForeColor.TabIndex = 2;
            this.pbForeColor.TabStop = false;
            // 
            // pbBackColor
            // 
            this.pbBackColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbBackColor.Location = new System.Drawing.Point(145, 83);
            this.pbBackColor.Name = "pbBackColor";
            this.pbBackColor.Size = new System.Drawing.Size(30, 30);
            this.pbBackColor.TabIndex = 2;
            this.pbBackColor.TabStop = false;
            // 
            // txtFontName
            // 
            this.txtFontName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFontName.Enabled = false;
            this.txtFontName.Location = new System.Drawing.Point(105, 19);
            this.txtFontName.Name = "txtFontName";
            this.txtFontName.Size = new System.Drawing.Size(164, 23);
            this.txtFontName.TabIndex = 3;
            // 
            // btnSaveAndClose
            // 
            this.btnSaveAndClose.Location = new System.Drawing.Point(83, 330);
            this.btnSaveAndClose.Name = "btnSaveAndClose";
            this.btnSaveAndClose.Size = new System.Drawing.Size(89, 23);
            this.btnSaveAndClose.TabIndex = 4;
            this.btnSaveAndClose.Text = "Save && Close";
            this.btnSaveAndClose.UseVisualStyleBackColor = true;
            this.btnSaveAndClose.Click += new System.EventHandler(this.btnSaveAndClose_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(194, 330);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtFontSize
            // 
            this.txtFontSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFontSize.Enabled = false;
            this.txtFontSize.Location = new System.Drawing.Point(225, 53);
            this.txtFontSize.MaxLength = 10;
            this.txtFontSize.Name = "txtFontSize";
            this.txtFontSize.Size = new System.Drawing.Size(43, 23);
            this.txtFontSize.TabIndex = 3;
            // 
            // lblFontName
            // 
            this.lblFontName.AutoSize = true;
            this.lblFontName.Location = new System.Drawing.Point(27, 21);
            this.lblFontName.Name = "lblFontName";
            this.lblFontName.Size = new System.Drawing.Size(72, 15);
            this.lblFontName.TabIndex = 5;
            this.lblFontName.Text = "Font Name :";
            // 
            // lblFontSize
            // 
            this.lblFontSize.AutoSize = true;
            this.lblFontSize.Location = new System.Drawing.Point(159, 55);
            this.lblFontSize.Name = "lblFontSize";
            this.lblFontSize.Size = new System.Drawing.Size(60, 15);
            this.lblFontSize.TabIndex = 5;
            this.lblFontSize.Text = "Font Size :";
            // 
            // grpBoxFont
            // 
            this.grpBoxFont.Controls.Add(this.chkFontUnderline);
            this.grpBoxFont.Controls.Add(this.chkFontItalic);
            this.grpBoxFont.Controls.Add(this.chkFontBold);
            this.grpBoxFont.Controls.Add(this.txtFontSize);
            this.grpBoxFont.Controls.Add(this.lblFontSize);
            this.grpBoxFont.Controls.Add(this.txtFontName);
            this.grpBoxFont.Controls.Add(this.lblFontName);
            this.grpBoxFont.Controls.Add(this.btnOpenFontDialog);
            this.grpBoxFont.Location = new System.Drawing.Point(12, 12);
            this.grpBoxFont.Name = "grpBoxFont";
            this.grpBoxFont.Size = new System.Drawing.Size(307, 147);
            this.grpBoxFont.TabIndex = 6;
            this.grpBoxFont.TabStop = false;
            this.grpBoxFont.Text = "Font";
            // 
            // chkFontUnderline
            // 
            this.chkFontUnderline.AutoSize = true;
            this.chkFontUnderline.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkFontUnderline.Enabled = false;
            this.chkFontUnderline.Location = new System.Drawing.Point(22, 95);
            this.chkFontUnderline.Name = "chkFontUnderline";
            this.chkFontUnderline.Size = new System.Drawing.Size(77, 19);
            this.chkFontUnderline.TabIndex = 7;
            this.chkFontUnderline.Text = "Underline";
            this.chkFontUnderline.UseVisualStyleBackColor = true;
            // 
            // chkFontItalic
            // 
            this.chkFontItalic.AutoSize = true;
            this.chkFontItalic.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkFontItalic.Enabled = false;
            this.chkFontItalic.Location = new System.Drawing.Point(48, 76);
            this.chkFontItalic.Name = "chkFontItalic";
            this.chkFontItalic.Size = new System.Drawing.Size(51, 19);
            this.chkFontItalic.TabIndex = 7;
            this.chkFontItalic.Text = "Italic";
            this.chkFontItalic.UseVisualStyleBackColor = true;
            // 
            // chkFontBold
            // 
            this.chkFontBold.AutoSize = true;
            this.chkFontBold.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkFontBold.Enabled = false;
            this.chkFontBold.Location = new System.Drawing.Point(49, 57);
            this.chkFontBold.Name = "chkFontBold";
            this.chkFontBold.Size = new System.Drawing.Size(50, 19);
            this.chkFontBold.TabIndex = 7;
            this.chkFontBold.Text = "Bold";
            this.chkFontBold.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOpenColorDialogForeColor);
            this.groupBox1.Controls.Add(this.btnOpenColorDialogBackColor);
            this.groupBox1.Controls.Add(this.pbForeColor);
            this.groupBox1.Controls.Add(this.pbBackColor);
            this.groupBox1.Location = new System.Drawing.Point(19, 165);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 142);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Font Color";
            // 
            // frmStyleConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 372);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpBoxFont);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSaveAndClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStyleConfig";
            this.Text = "Save \\& Close";
            ((System.ComponentModel.ISupportInitialize)(this.pbForeColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackColor)).EndInit();
            this.grpBoxFont.ResumeLayout(false);
            this.grpBoxFont.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenFontDialog;
        private System.Windows.Forms.Button btnOpenColorDialogForeColor;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.ColorDialog colorDialogForeColor;
        private System.Windows.Forms.ColorDialog colorDialogBackColor;
        private System.Windows.Forms.Button btnOpenColorDialogBackColor;
        private System.Windows.Forms.PictureBox pbForeColor;
        private System.Windows.Forms.PictureBox pbBackColor;
        private System.Windows.Forms.TextBox txtFontName;
        private System.Windows.Forms.Button btnSaveAndClose;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtFontSize;
        private System.Windows.Forms.Label lblFontName;
        private System.Windows.Forms.Label lblFontSize;
        private System.Windows.Forms.GroupBox grpBoxFont;
        private System.Windows.Forms.CheckBox chkFontUnderline;
        private System.Windows.Forms.CheckBox chkFontItalic;
        private System.Windows.Forms.CheckBox chkFontBold;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}