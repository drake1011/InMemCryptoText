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
            this.txtFont = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbForeColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackColor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpenFontDialog
            // 
            this.btnOpenFontDialog.Location = new System.Drawing.Point(64, 34);
            this.btnOpenFontDialog.Name = "btnOpenFontDialog";
            this.btnOpenFontDialog.Size = new System.Drawing.Size(75, 23);
            this.btnOpenFontDialog.TabIndex = 0;
            this.btnOpenFontDialog.Text = "Font";
            this.btnOpenFontDialog.UseVisualStyleBackColor = true;
            this.btnOpenFontDialog.Click += new System.EventHandler(this.btnOpenFontDialog_Click);
            // 
            // btnOpenColorDialogForeColor
            // 
            this.btnOpenColorDialogForeColor.Location = new System.Drawing.Point(64, 91);
            this.btnOpenColorDialogForeColor.Name = "btnOpenColorDialogForeColor";
            this.btnOpenColorDialogForeColor.Size = new System.Drawing.Size(75, 23);
            this.btnOpenColorDialogForeColor.TabIndex = 1;
            this.btnOpenColorDialogForeColor.Text = "Fore Color";
            this.btnOpenColorDialogForeColor.UseVisualStyleBackColor = true;
            this.btnOpenColorDialogForeColor.Click += new System.EventHandler(this.btnOpenColorDialogForeColor_Click);
            // 
            // btnOpenColorDialogBackColor
            // 
            this.btnOpenColorDialogBackColor.Location = new System.Drawing.Point(64, 156);
            this.btnOpenColorDialogBackColor.Name = "btnOpenColorDialogBackColor";
            this.btnOpenColorDialogBackColor.Size = new System.Drawing.Size(75, 23);
            this.btnOpenColorDialogBackColor.TabIndex = 1;
            this.btnOpenColorDialogBackColor.Text = "Back Color";
            this.btnOpenColorDialogBackColor.UseVisualStyleBackColor = true;
            this.btnOpenColorDialogBackColor.Click += new System.EventHandler(this.btnOpenColorDialogBackColor_Click);
            // 
            // pbForeColor
            // 
            this.pbForeColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbForeColor.Location = new System.Drawing.Point(189, 87);
            this.pbForeColor.Name = "pbForeColor";
            this.pbForeColor.Size = new System.Drawing.Size(30, 30);
            this.pbForeColor.TabIndex = 2;
            this.pbForeColor.TabStop = false;
            // 
            // pbBackColor
            // 
            this.pbBackColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbBackColor.Location = new System.Drawing.Point(189, 149);
            this.pbBackColor.Name = "pbBackColor";
            this.pbBackColor.Size = new System.Drawing.Size(30, 30);
            this.pbBackColor.TabIndex = 2;
            this.pbBackColor.TabStop = false;
            // 
            // txtFont
            // 
            this.txtFont.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFont.Enabled = false;
            this.txtFont.Location = new System.Drawing.Point(189, 35);
            this.txtFont.Name = "txtFont";
            this.txtFont.Size = new System.Drawing.Size(151, 23);
            this.txtFont.TabIndex = 3;
            // 
            // frmStyleConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 226);
            this.Controls.Add(this.txtFont);
            this.Controls.Add(this.pbBackColor);
            this.Controls.Add(this.pbForeColor);
            this.Controls.Add(this.btnOpenColorDialogBackColor);
            this.Controls.Add(this.btnOpenColorDialogForeColor);
            this.Controls.Add(this.btnOpenFontDialog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStyleConfig";
            this.Text = "frmStyleConfig";
            ((System.ComponentModel.ISupportInitialize)(this.pbForeColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.TextBox txtFont;
    }
}