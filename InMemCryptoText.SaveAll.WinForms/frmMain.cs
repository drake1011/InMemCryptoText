using System;
using System.IO;
using System.Windows.Forms;
using CryptoLib;

namespace InMemCryptoText.SaveAll.WinForms
{
    public partial class frmMain : Form
    {
        private readonly ICryptography _cryptography;

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnOpenEncryptedFile_Click(object sender, EventArgs e)
        {
            if (openFileDialogEnc.ShowDialog() == DialogResult.OK)
            {
                txtEncryptedFileLocation.Text = openFileDialogEnc.FileName;
            }
        }

        private void btnOpenTextFile_Click(object sender, EventArgs e)
        {
            if (openFileDialogTxt.ShowDialog() == DialogResult.OK)
            {
                txtTextFileLocation.Text = openFileDialogTxt.FileName;
            }
        }

        private async void btnDecrypt_Click(object sender, EventArgs e)
        {
            var decryptedText = string.Empty;
            do // used to break on exceptions
            {
                if (string.IsNullOrEmpty(txtDecryptPassword.Text))
                {
                    MessageBox.Show("Enter a Decrypt Password First!", "Missing Decrypt Password", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (string.IsNullOrEmpty(txtEncryptedFileLocation.Text))
                    {
                        MessageBox.Show("Select Ecnrypted File First!", "Missing Encrypted File", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        try
                        {
                            decryptedText = await _cryptography.Decrypt(File.ReadAllText(txtEncryptedFileLocation.Text), txtDecryptPassword.Text);
                        }
                        catch (InvalidPasswordException ipex)
                        {
                            MessageBox.Show($"{ipex.Message}", "Invalid Password Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"{ex.Message}", "Unknown Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }

                        var diagResult = saveFileDialogTxt.ShowDialog();
                        if (diagResult != DialogResult.OK)
                        {
                            MessageBox.Show("Select Save Text File First!", "Missing File Save Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        }
                        else if (diagResult == DialogResult.OK)
                        {
                            if (!string.IsNullOrEmpty(saveFileDialogTxt.FileName))
                            {
                                File.WriteAllText(saveFileDialogTxt.FileName, decryptedText);
                                MessageBox.Show($"File {txtEncryptedFileLocation.Text} decrypted and saved Successfully\nto {saveFileDialogTxt.FileName}!");
                            }
                        }
                    }
                }
            } while (1 == 0);
        }

        private async void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEncryptPassword.Text))
            {
                MessageBox.Show("Enter an Encrypt Password First!", "Missing Encrypt Password", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (string.IsNullOrEmpty(txtTextFileLocation.Text))
                {
                    MessageBox.Show("Select Text File to Encrypt First!", "Missing Text File Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    var encryptedText = await _cryptography.Encrypt(File.ReadAllText(txtTextFileLocation.Text), txtEncryptPassword.Text);

                    var diagResult = saveFileDialogEnc.ShowDialog();
                    if (diagResult != DialogResult.OK)
                    {
                        MessageBox.Show("Select Save Encrypt File First!", "Missing File Save Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                    else if (diagResult == DialogResult.OK)
                    {
                        if (!string.IsNullOrEmpty(saveFileDialogEnc.FileName))
                        {
                            File.WriteAllText(saveFileDialogEnc.FileName, encryptedText);
                            MessageBox.Show($"File {txtTextFileLocation.Text} encrypted and saved Successfully\nto {saveFileDialogEnc.FileName}!");
                        }
                    }
                }
            }
        }
    }
}
