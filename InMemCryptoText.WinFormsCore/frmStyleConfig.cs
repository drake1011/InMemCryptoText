using System;
using System.Windows.Forms;

namespace InMemCryptoText.WinFormsCore
{
    public partial class frmStyleConfig : Form
    {
        public frmStyleConfig()
        {
            InitializeComponent();
            ReloadFontFields();
            ReloadFontColor();
        }

        private void ReloadFontFields()
        {
            txtFontName.Text = Settings.Default.SavedFont.Name;
            txtFontSize.Text = Settings.Default.SavedFont.Size.ToString();
            chkFontBold.Checked = Settings.Default.SavedFont.Bold;
            chkFontItalic.Checked = Settings.Default.SavedFont.Italic;
            chkFontUnderline.Checked = Settings.Default.SavedFont.Underline;
        }

        private void ReloadFontColor()
        {
            pbForeColor.BackColor = Settings.Default.SavedForeColor;
            pbBackColor.BackColor = Settings.Default.SavedBackColor;
        }

        private void btnOpenFontDialog_Click(object sender, EventArgs e)
        {
            fontDialog.ShowDialog();
            Settings.Default.SavedFont = fontDialog.Font;
            ReloadFontFields();
        }

        private void btnOpenColorDialogForeColor_Click(object sender, EventArgs e)
        {
            colorDialogForeColor.ShowDialog();
            Settings.Default.SavedForeColor = colorDialogForeColor.Color;
            ReloadFontColor();
        }

        private void btnOpenColorDialogBackColor_Click(object sender, EventArgs e)
        {
            colorDialogBackColor.ShowDialog();
            Settings.Default.SavedBackColor = colorDialogBackColor.Color;
            ReloadFontColor();
        }

        private void btnSaveAndClose_Click(object sender, EventArgs e)
        {
            Settings.Default.Save();
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Settings.Default.Reload();
            ReloadFontFields();
            ReloadFontColor();
            Close();
        }
    }
}
