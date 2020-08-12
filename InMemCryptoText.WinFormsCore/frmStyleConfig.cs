using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InMemCryptoText.WinFormsCore
{
    public partial class frmStyleConfig : Form
    {
        public frmStyleConfig()
        {
            InitializeComponent();

            txtFont.Text = Settings.Default.SavedFont.Name;
            
            pbForeColor.BackColor = Settings.Default.SavedForeColor;
            colorDialogForeColor.Color = Settings.Default.SavedForeColor;

            pbBackColor.BackColor = Settings.Default.SavedBackColor;
            colorDialogBackColor.Color = Settings.Default.SavedBackColor;
        }

        private void btnOpenFontDialog_Click(object sender, EventArgs e)
        {
            fontDialog.ShowDialog();
            txtFont.Text = fontDialog.Font.Name;
            Settings.Default.SavedFont = fontDialog.Font;
            Settings.Default.Save();
        }

        private void btnOpenColorDialogForeColor_Click(object sender, EventArgs e)
        {
            colorDialogForeColor.ShowDialog();
            pbForeColor.BackColor = colorDialogForeColor.Color;
            Settings.Default.SavedForeColor = colorDialogForeColor.Color;
            Settings.Default.Save();
        }

        private void btnOpenColorDialogBackColor_Click(object sender, EventArgs e)
        {
            colorDialogBackColor.ShowDialog();
            pbBackColor.BackColor = colorDialogBackColor.Color;
            Settings.Default.SavedBackColor = colorDialogBackColor.Color;
            Settings.Default.Save();
        }
    }
}
