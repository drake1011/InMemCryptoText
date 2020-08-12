using System;
using System.IO;
using System.Windows.Forms;
using CryptoLib;

namespace InMemCryptoText.WinFormsCore
{
    public partial class frmMain : Form
    {
        private frmStyleConfig frmStyle;
        public frmMain()
        {
            InitializeComponent();
            frmStyle = new frmStyleConfig();
            ReLoadStyleConfigSettings();
        }

        private void ReLoadStyleConfigSettings()
        {
            txtDecryptedText.Font = Settings.Default.SavedFont;
            txtDecryptedText.ForeColor = Settings.Default.SavedForeColor;
            txtDecryptedText.BackColor = Settings.Default.SavedBackColor;
        }

        private void btnSelectDecryptFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtEncryptedFileLocation.Text = openFileDialog1.FileName;
                txtSaveNewEncryptedFile.Text = openFileDialog1.FileName;
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtEncryptedFileLocation.Text))
            {
                if (!string.IsNullOrEmpty(txtPassword.Text))
                {
                    try
                    {
                        txtDecryptedText.Text = Cryptography.Decrypt(File.ReadAllText(txtEncryptedFileLocation.Text), txtPassword.Text);
                    }
                    catch (InvalidPasswordException ipex)
                    {
                        MessageBox.Show($"{ipex.Message}", "Invalid Password Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"{ex.Message}", "Unknown Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Enter a Decrypt Password First!", "Missing Decrypt Password", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Select File First!", "Missing Encrypted File", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDecryptedText.Text))
            {
                MessageBox.Show("Enter some text to encrypt First!", "Missing Text to Encrypt", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (string.IsNullOrEmpty(txtEncryptPassword.Text))
                {
                    MessageBox.Show("Enter an Encrypt Password First!", "Missing Encrypt Password", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (string.IsNullOrEmpty(txtSaveNewEncryptedFile.Text))
                    {
                        var diagResult = saveFileDialog1.ShowDialog();
                        if (diagResult != DialogResult.OK)
                        {
                            MessageBox.Show("Select Save Encrypt File First!", "Missing File Save Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        }
                        else if (diagResult == DialogResult.OK)
                        {
                            txtSaveNewEncryptedFile.Text = saveFileDialog1.FileName;
                        }
                    }

                    if (!string.IsNullOrEmpty(txtSaveNewEncryptedFile.Text))
                    {
                        File.WriteAllText(txtSaveNewEncryptedFile.Text, Cryptography.Encrypt(txtDecryptedText.Text, txtEncryptPassword.Text));
                        MessageBox.Show($"Text encrypted and saved Successfully\nto {txtSaveNewEncryptedFile.Text}!", "Success");
                    }
                }
            }
        }

        private void btnSelectEncryptFile_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtSaveNewEncryptedFile.Text = saveFileDialog1.FileName;
            }
        }

        private void tsmiClear_Click(object sender, System.EventArgs e)
        {
            openFileDialog1.FileName = string.Empty;
            saveFileDialog1.FileName = string.Empty;

            txtEncryptedFileLocation.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtSaveNewEncryptedFile.Text = string.Empty;
            txtEncryptPassword.Text = string.Empty;
            txtDecryptedText.Text = string.Empty;
        }

        private void tsmiStyleConfig_Click(object sender, System.EventArgs e)
        {
            frmStyle.ShowDialog();
            ReLoadStyleConfigSettings();
        }
    }
}
