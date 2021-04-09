using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using CryptoLib;

namespace InMemCryptoText.WinFormsCore
{
    public partial class frmMain : Form
    {
        private readonly frmStyleConfig _frmStyle;
        private readonly ICryptography _crypto;
        private string _decryptedText;

        public frmMain(ICryptography crypto, frmStyleConfig frmStyle)
        {
            InitializeComponent();
            _frmStyle = frmStyle;
            ReLoadStyleConfigSettings();

            _crypto = crypto;
        }

        private void ReLoadStyleConfigSettings()
        {
            txtDecryptedText.Font = Settings.Default.SavedFont;
            txtDecryptedText.ForeColor = Settings.Default.SavedForeColor;
            txtDecryptedText.BackColor = Settings.Default.SavedBackColor;
        }

        private void btnSelectDecryptFile_Click(object sender, EventArgs e)
        {
            if (openFileDialogEnc.ShowDialog() == DialogResult.OK)
            {
                txtEncryptedFileLocation.Text = openFileDialogEnc.FileName;
                txtSaveNewEncryptedFile.Text = openFileDialogEnc.FileName;
            }
        }

        private async void btnDecrypt_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtEncryptedFileLocation.Text))
            {
                if (!string.IsNullOrEmpty(txtPassword.Text))
                {
                    try
                    {
                        txtDecryptedText.Text = _decryptedText = await _crypto.Decrypt(File.ReadAllText(txtEncryptedFileLocation.Text), txtPassword.Text);
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

        private async void btnEncrypt_Click(object sender, EventArgs e)
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
                        var diagResult = saveFileDialog.ShowDialog();
                        if (diagResult != DialogResult.OK)
                        {
                            MessageBox.Show("Select Save Encrypt File First!", "Missing File Save Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        }
                        else if (diagResult == DialogResult.OK)
                        {
                            txtSaveNewEncryptedFile.Text = saveFileDialog.FileName;
                        }
                    }

                    if (!string.IsNullOrEmpty(txtSaveNewEncryptedFile.Text))
                    {
                        File.WriteAllText(txtSaveNewEncryptedFile.Text, await _crypto.Encrypt(txtDecryptedText.Text, txtEncryptPassword.Text));
                        MessageBox.Show($"Text encrypted and saved Successfully\nto {txtSaveNewEncryptedFile.Text}!", "Success");
                    }
                }
            }
        }

        private void btnSelectEncryptFile_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtSaveNewEncryptedFile.Text = saveFileDialog.FileName;
            }
        }

        private void tsmiClear_Click(object sender, System.EventArgs e)
        {
            openFileDialogEnc.FileName = string.Empty;
            saveFileDialog.FileName = string.Empty;

            txtEncryptedFileLocation.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtSaveNewEncryptedFile.Text = string.Empty;
            txtEncryptPassword.Text = string.Empty;
            txtDecryptedText.Text = string.Empty;
        }

        private void tsmiStyleConfig_Click(object sender, System.EventArgs e)
        {
            _frmStyle.ShowDialog();
            ReLoadStyleConfigSettings();
        }

        private int matches_index;
        private MatchCollection matches;

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            if (txtDecryptedText.Text.Length > 0)
            {
                matches = Regex.Matches(txtDecryptedText.Text, txtFind.Text);
                if (matches.Count > 0)
                {
                    var index = matches.First().Index;//txtDecryptedText.Text.IndexOf(txtFind.Text);
                    matches_index = 0;

                    MoveSelection(index, 1);
                }
                else
                    lblResultsFound.Text = $"Match 0/0";
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (matches?.Count > 0)
            {
                // moove forward in array
                var index = (matches_index + 1) % matches.Count;
                MoveSelection(matches.ElementAt(index).Index, index + 1);
                matches_index = index;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (matches?.Count > 0)
            {
                // move backward in array
                var index = ((matches_index - 1) + matches.Count) % matches.Count;
                MoveSelection(matches.ElementAt(index).Index, index + 1);
                matches_index = index;
            }
        }

        private void MoveSelection(int index, int resultNumber)
        {
            lblResultsFound.Text = $"Match {resultNumber}/{matches.Count}";
            txtDecryptedText.Select(index, txtFind.Text.Length);
            txtDecryptedText.ScrollToCaret();
        }
    }
}
