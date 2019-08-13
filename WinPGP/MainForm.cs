using PGP;
using PGP.KeyGeneration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinPGP
{
    public partial class MainForm : Form
    {
        private string _privateKeyPath = "";
        private string _publicKeyPath = "";
        private string _plainTextPath = "";
        private string _encryptedDataPath = "";

        public MainForm()
        {
            InitializeComponent();

            _privateKeyPath = string.Format("{0}/PrivateKey.asc", @Application.StartupPath);
            _publicKeyPath = string.Format("{0}/PublicKey.asc", @Application.StartupPath);
            _plainTextPath = string.Format("{0}/PlainText.txt", @Application.StartupPath);
            _encryptedDataPath = string.Format("{0}/EncryptedData.txt", @Application.StartupPath);
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            try
            {
                KeyGeneration.GenerateKey(UsernameTextBox.Text, PassphraseTextBox.Text, @Application.StartupPath);

                PrivateKeyTextBox.Text = File.ReadAllText(_privateKeyPath);
                PublicKeyTextBox.Text = File.ReadAllText(_publicKeyPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EncrypButton_Click(object sender, EventArgs e)
        {
            try
            {
                File.WriteAllText(_privateKeyPath, EncryptPrivateKeyTextBox.Text);
                File.WriteAllText(_publicKeyPath, EncryptPublicKeyTextBox.Text);
                File.WriteAllText(_plainTextPath, EncryptPlainTextBox.Text);

                PGP.Keys encryptionKeys = new PGP.Keys(
                    _publicKeyPath,
                    _privateKeyPath,
                    EncryptPassPhraseTextBox.Text);
                Encryption encrypter = new Encryption(encryptionKeys);
                using (Stream outputStream = File.Create(_encryptedDataPath))
                {
                    encrypter.EncryptAndSign(outputStream, new FileInfo(_plainTextPath));
                }
                EncryptedTextBox.Text = File.ReadAllText(_encryptedDataPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            try
            {
                File.WriteAllText(_plainTextPath, DecryptPlainTextBox.Text);
                File.WriteAllText(_privateKeyPath, DecryptPrivateTextBox.Text);

                Decryption.Decrypt(_encryptedDataPath,
                    _privateKeyPath,
                    DecryptPassphraseTextBox.Text,
                    _plainTextPath);

                DecryptedMessageTextBox.Text = File.ReadAllText(_plainTextPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
