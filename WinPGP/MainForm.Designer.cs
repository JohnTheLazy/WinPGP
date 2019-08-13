namespace WinPGP
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.KeyGenTabControl = new System.Windows.Forms.TabControl();
            this.KeyGenTabPage = new System.Windows.Forms.TabPage();
            this.MainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.GenerateTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.PassphraseTextBox = new System.Windows.Forms.TextBox();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.KeysTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.PrivateKeyTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.PrivateKeyLabel = new System.Windows.Forms.Label();
            this.PrivateKeyTextBox = new System.Windows.Forms.TextBox();
            this.PublicKeyTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.PublicKeyLabel = new System.Windows.Forms.Label();
            this.PublicKeyTextBox = new System.Windows.Forms.TextBox();
            this.EncryptTabPage = new System.Windows.Forms.TabPage();
            this.EncryptTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.Encrypt2TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.EncrypButton = new System.Windows.Forms.Button();
            this.EncryptPassPhraseTextBox = new System.Windows.Forms.TextBox();
            this.EncryptedTextBox = new System.Windows.Forms.TextBox();
            this.EncryptPlainTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.EncryptKeysTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.EncryptPublicKeyTextBox = new System.Windows.Forms.TextBox();
            this.EncryptPrivateKeyTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DecryptTabPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.DecryptedMessageTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.DecryptButton = new System.Windows.Forms.Button();
            this.DecryptPassphraseTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.DecryptPrivateTextBox = new System.Windows.Forms.TextBox();
            this.DecryptPlainTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.MainMenuStrip.SuspendLayout();
            this.KeyGenTabControl.SuspendLayout();
            this.KeyGenTabPage.SuspendLayout();
            this.MainTableLayoutPanel.SuspendLayout();
            this.GenerateTableLayoutPanel.SuspendLayout();
            this.KeysTableLayoutPanel.SuspendLayout();
            this.PrivateKeyTableLayoutPanel.SuspendLayout();
            this.PublicKeyTableLayoutPanel.SuspendLayout();
            this.EncryptTabPage.SuspendLayout();
            this.EncryptTableLayoutPanel.SuspendLayout();
            this.Encrypt2TableLayoutPanel.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.EncryptKeysTableLayoutPanel.SuspendLayout();
            this.DecryptTabPage.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Size = new System.Drawing.Size(684, 24);
            this.MainMenuStrip.TabIndex = 0;
            this.MainMenuStrip.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FileToolStripMenuItem.Text = "&File";
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.ExitToolStripMenuItem.Text = "E&xit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // KeyGenTabControl
            // 
            this.KeyGenTabControl.Controls.Add(this.KeyGenTabPage);
            this.KeyGenTabControl.Controls.Add(this.EncryptTabPage);
            this.KeyGenTabControl.Controls.Add(this.DecryptTabPage);
            this.KeyGenTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KeyGenTabControl.Location = new System.Drawing.Point(0, 24);
            this.KeyGenTabControl.Name = "KeyGenTabControl";
            this.KeyGenTabControl.SelectedIndex = 0;
            this.KeyGenTabControl.Size = new System.Drawing.Size(684, 637);
            this.KeyGenTabControl.TabIndex = 1;
            // 
            // KeyGenTabPage
            // 
            this.KeyGenTabPage.Controls.Add(this.MainTableLayoutPanel);
            this.KeyGenTabPage.Location = new System.Drawing.Point(4, 22);
            this.KeyGenTabPage.Name = "KeyGenTabPage";
            this.KeyGenTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.KeyGenTabPage.Size = new System.Drawing.Size(676, 611);
            this.KeyGenTabPage.TabIndex = 0;
            this.KeyGenTabPage.Text = "KeyGen";
            this.KeyGenTabPage.UseVisualStyleBackColor = true;
            // 
            // MainTableLayoutPanel
            // 
            this.MainTableLayoutPanel.ColumnCount = 1;
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayoutPanel.Controls.Add(this.GenerateTableLayoutPanel, 0, 0);
            this.MainTableLayoutPanel.Controls.Add(this.KeysTableLayoutPanel, 0, 1);
            this.MainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.MainTableLayoutPanel.Name = "MainTableLayoutPanel";
            this.MainTableLayoutPanel.RowCount = 2;
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayoutPanel.Size = new System.Drawing.Size(670, 605);
            this.MainTableLayoutPanel.TabIndex = 0;
            // 
            // GenerateTableLayoutPanel
            // 
            this.GenerateTableLayoutPanel.ColumnCount = 3;
            this.GenerateTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 158F));
            this.GenerateTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 107F));
            this.GenerateTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.GenerateTableLayoutPanel.Controls.Add(this.label1, 0, 0);
            this.GenerateTableLayoutPanel.Controls.Add(this.label2, 1, 0);
            this.GenerateTableLayoutPanel.Controls.Add(this.UsernameTextBox, 0, 1);
            this.GenerateTableLayoutPanel.Controls.Add(this.PassphraseTextBox, 1, 1);
            this.GenerateTableLayoutPanel.Controls.Add(this.GenerateButton, 2, 1);
            this.GenerateTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.GenerateTableLayoutPanel.Name = "GenerateTableLayoutPanel";
            this.GenerateTableLayoutPanel.RowCount = 2;
            this.GenerateTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.GenerateTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.GenerateTableLayoutPanel.Size = new System.Drawing.Size(340, 54);
            this.GenerateTableLayoutPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(3, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Location = new System.Drawing.Point(161, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Passphrase";
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Location = new System.Drawing.Point(3, 30);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(150, 20);
            this.UsernameTextBox.TabIndex = 2;
            // 
            // PassphraseTextBox
            // 
            this.PassphraseTextBox.Location = new System.Drawing.Point(161, 30);
            this.PassphraseTextBox.Name = "PassphraseTextBox";
            this.PassphraseTextBox.PasswordChar = '*';
            this.PassphraseTextBox.Size = new System.Drawing.Size(100, 20);
            this.PassphraseTextBox.TabIndex = 3;
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(268, 30);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(68, 21);
            this.GenerateButton.TabIndex = 4;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // KeysTableLayoutPanel
            // 
            this.KeysTableLayoutPanel.ColumnCount = 1;
            this.KeysTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.KeysTableLayoutPanel.Controls.Add(this.PrivateKeyTableLayoutPanel, 0, 0);
            this.KeysTableLayoutPanel.Controls.Add(this.PublicKeyTableLayoutPanel, 0, 1);
            this.KeysTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KeysTableLayoutPanel.Location = new System.Drawing.Point(3, 64);
            this.KeysTableLayoutPanel.Name = "KeysTableLayoutPanel";
            this.KeysTableLayoutPanel.RowCount = 2;
            this.KeysTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.KeysTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.KeysTableLayoutPanel.Size = new System.Drawing.Size(664, 538);
            this.KeysTableLayoutPanel.TabIndex = 1;
            // 
            // PrivateKeyTableLayoutPanel
            // 
            this.PrivateKeyTableLayoutPanel.ColumnCount = 1;
            this.PrivateKeyTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PrivateKeyTableLayoutPanel.Controls.Add(this.PrivateKeyLabel, 0, 0);
            this.PrivateKeyTableLayoutPanel.Controls.Add(this.PrivateKeyTextBox, 0, 1);
            this.PrivateKeyTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PrivateKeyTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.PrivateKeyTableLayoutPanel.Name = "PrivateKeyTableLayoutPanel";
            this.PrivateKeyTableLayoutPanel.RowCount = 2;
            this.PrivateKeyTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PrivateKeyTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PrivateKeyTableLayoutPanel.Size = new System.Drawing.Size(658, 316);
            this.PrivateKeyTableLayoutPanel.TabIndex = 0;
            // 
            // PrivateKeyLabel
            // 
            this.PrivateKeyLabel.AutoSize = true;
            this.PrivateKeyLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PrivateKeyLabel.Location = new System.Drawing.Point(3, 7);
            this.PrivateKeyLabel.Name = "PrivateKeyLabel";
            this.PrivateKeyLabel.Size = new System.Drawing.Size(652, 13);
            this.PrivateKeyLabel.TabIndex = 0;
            this.PrivateKeyLabel.Text = "Private Key";
            // 
            // PrivateKeyTextBox
            // 
            this.PrivateKeyTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PrivateKeyTextBox.Location = new System.Drawing.Point(3, 23);
            this.PrivateKeyTextBox.Multiline = true;
            this.PrivateKeyTextBox.Name = "PrivateKeyTextBox";
            this.PrivateKeyTextBox.ReadOnly = true;
            this.PrivateKeyTextBox.Size = new System.Drawing.Size(652, 290);
            this.PrivateKeyTextBox.TabIndex = 1;
            // 
            // PublicKeyTableLayoutPanel
            // 
            this.PublicKeyTableLayoutPanel.ColumnCount = 1;
            this.PublicKeyTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PublicKeyTableLayoutPanel.Controls.Add(this.PublicKeyLabel, 0, 0);
            this.PublicKeyTableLayoutPanel.Controls.Add(this.PublicKeyTextBox, 0, 1);
            this.PublicKeyTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PublicKeyTableLayoutPanel.Location = new System.Drawing.Point(3, 325);
            this.PublicKeyTableLayoutPanel.Name = "PublicKeyTableLayoutPanel";
            this.PublicKeyTableLayoutPanel.RowCount = 2;
            this.PublicKeyTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PublicKeyTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PublicKeyTableLayoutPanel.Size = new System.Drawing.Size(658, 210);
            this.PublicKeyTableLayoutPanel.TabIndex = 1;
            // 
            // PublicKeyLabel
            // 
            this.PublicKeyLabel.AutoSize = true;
            this.PublicKeyLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PublicKeyLabel.Location = new System.Drawing.Point(3, 7);
            this.PublicKeyLabel.Name = "PublicKeyLabel";
            this.PublicKeyLabel.Size = new System.Drawing.Size(652, 13);
            this.PublicKeyLabel.TabIndex = 0;
            this.PublicKeyLabel.Text = "Public Key";
            // 
            // PublicKeyTextBox
            // 
            this.PublicKeyTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PublicKeyTextBox.Location = new System.Drawing.Point(3, 23);
            this.PublicKeyTextBox.Multiline = true;
            this.PublicKeyTextBox.Name = "PublicKeyTextBox";
            this.PublicKeyTextBox.ReadOnly = true;
            this.PublicKeyTextBox.Size = new System.Drawing.Size(652, 184);
            this.PublicKeyTextBox.TabIndex = 1;
            // 
            // EncryptTabPage
            // 
            this.EncryptTabPage.Controls.Add(this.EncryptTableLayoutPanel);
            this.EncryptTabPage.Location = new System.Drawing.Point(4, 22);
            this.EncryptTabPage.Name = "EncryptTabPage";
            this.EncryptTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.EncryptTabPage.Size = new System.Drawing.Size(676, 611);
            this.EncryptTabPage.TabIndex = 1;
            this.EncryptTabPage.Text = "Encrypt";
            this.EncryptTabPage.UseVisualStyleBackColor = true;
            // 
            // EncryptTableLayoutPanel
            // 
            this.EncryptTableLayoutPanel.ColumnCount = 1;
            this.EncryptTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.EncryptTableLayoutPanel.Controls.Add(this.Encrypt2TableLayoutPanel, 0, 1);
            this.EncryptTableLayoutPanel.Controls.Add(this.EncryptKeysTableLayoutPanel, 0, 0);
            this.EncryptTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EncryptTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.EncryptTableLayoutPanel.Name = "EncryptTableLayoutPanel";
            this.EncryptTableLayoutPanel.RowCount = 2;
            this.EncryptTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.EncryptTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.EncryptTableLayoutPanel.Size = new System.Drawing.Size(670, 605);
            this.EncryptTableLayoutPanel.TabIndex = 0;
            // 
            // Encrypt2TableLayoutPanel
            // 
            this.Encrypt2TableLayoutPanel.ColumnCount = 2;
            this.Encrypt2TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Encrypt2TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Encrypt2TableLayoutPanel.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.Encrypt2TableLayoutPanel.Controls.Add(this.EncryptedTextBox, 1, 1);
            this.Encrypt2TableLayoutPanel.Controls.Add(this.EncryptPlainTextBox, 0, 1);
            this.Encrypt2TableLayoutPanel.Controls.Add(this.label7, 0, 0);
            this.Encrypt2TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Encrypt2TableLayoutPanel.Location = new System.Drawing.Point(3, 305);
            this.Encrypt2TableLayoutPanel.Name = "Encrypt2TableLayoutPanel";
            this.Encrypt2TableLayoutPanel.RowCount = 2;
            this.Encrypt2TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.Encrypt2TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Encrypt2TableLayoutPanel.Size = new System.Drawing.Size(664, 297);
            this.Encrypt2TableLayoutPanel.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 123F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 123F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.Controls.Add(this.label6, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.EncrypButton, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.EncryptPassPhraseTextBox, 1, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(335, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(326, 54);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label6.Location = new System.Drawing.Point(126, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Passphrase";
            // 
            // EncrypButton
            // 
            this.EncrypButton.Location = new System.Drawing.Point(249, 30);
            this.EncrypButton.Name = "EncrypButton";
            this.EncrypButton.Size = new System.Drawing.Size(75, 21);
            this.EncrypButton.TabIndex = 5;
            this.EncrypButton.Text = "Encrypt";
            this.EncrypButton.UseVisualStyleBackColor = true;
            this.EncrypButton.Click += new System.EventHandler(this.EncrypButton_Click);
            // 
            // EncryptPassPhraseTextBox
            // 
            this.EncryptPassPhraseTextBox.Location = new System.Drawing.Point(126, 30);
            this.EncryptPassPhraseTextBox.Name = "EncryptPassPhraseTextBox";
            this.EncryptPassPhraseTextBox.PasswordChar = '*';
            this.EncryptPassPhraseTextBox.Size = new System.Drawing.Size(114, 20);
            this.EncryptPassPhraseTextBox.TabIndex = 3;
            // 
            // EncryptedTextBox
            // 
            this.EncryptedTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EncryptedTextBox.Location = new System.Drawing.Point(335, 63);
            this.EncryptedTextBox.Multiline = true;
            this.EncryptedTextBox.Name = "EncryptedTextBox";
            this.EncryptedTextBox.ReadOnly = true;
            this.EncryptedTextBox.Size = new System.Drawing.Size(326, 231);
            this.EncryptedTextBox.TabIndex = 4;
            // 
            // EncryptPlainTextBox
            // 
            this.EncryptPlainTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EncryptPlainTextBox.Location = new System.Drawing.Point(3, 63);
            this.EncryptPlainTextBox.Multiline = true;
            this.EncryptPlainTextBox.Name = "EncryptPlainTextBox";
            this.EncryptPlainTextBox.Size = new System.Drawing.Size(326, 231);
            this.EncryptPlainTextBox.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label7.Location = new System.Drawing.Point(3, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(326, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Message";
            // 
            // EncryptKeysTableLayoutPanel
            // 
            this.EncryptKeysTableLayoutPanel.ColumnCount = 2;
            this.EncryptKeysTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.EncryptKeysTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.EncryptKeysTableLayoutPanel.Controls.Add(this.EncryptPublicKeyTextBox, 1, 1);
            this.EncryptKeysTableLayoutPanel.Controls.Add(this.EncryptPrivateKeyTextBox, 0, 1);
            this.EncryptKeysTableLayoutPanel.Controls.Add(this.label3, 0, 0);
            this.EncryptKeysTableLayoutPanel.Controls.Add(this.label4, 1, 0);
            this.EncryptKeysTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EncryptKeysTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.EncryptKeysTableLayoutPanel.Name = "EncryptKeysTableLayoutPanel";
            this.EncryptKeysTableLayoutPanel.RowCount = 2;
            this.EncryptKeysTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.EncryptKeysTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.EncryptKeysTableLayoutPanel.Size = new System.Drawing.Size(664, 296);
            this.EncryptKeysTableLayoutPanel.TabIndex = 0;
            // 
            // EncryptPublicKeyTextBox
            // 
            this.EncryptPublicKeyTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EncryptPublicKeyTextBox.Location = new System.Drawing.Point(335, 23);
            this.EncryptPublicKeyTextBox.Multiline = true;
            this.EncryptPublicKeyTextBox.Name = "EncryptPublicKeyTextBox";
            this.EncryptPublicKeyTextBox.Size = new System.Drawing.Size(326, 270);
            this.EncryptPublicKeyTextBox.TabIndex = 4;
            // 
            // EncryptPrivateKeyTextBox
            // 
            this.EncryptPrivateKeyTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EncryptPrivateKeyTextBox.Location = new System.Drawing.Point(3, 23);
            this.EncryptPrivateKeyTextBox.Multiline = true;
            this.EncryptPrivateKeyTextBox.Name = "EncryptPrivateKeyTextBox";
            this.EncryptPrivateKeyTextBox.Size = new System.Drawing.Size(326, 270);
            this.EncryptPrivateKeyTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Location = new System.Drawing.Point(3, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(326, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Private Key";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label4.Location = new System.Drawing.Point(335, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(326, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Public Key";
            // 
            // DecryptTabPage
            // 
            this.DecryptTabPage.Controls.Add(this.tableLayoutPanel1);
            this.DecryptTabPage.Location = new System.Drawing.Point(4, 22);
            this.DecryptTabPage.Name = "DecryptTabPage";
            this.DecryptTabPage.Size = new System.Drawing.Size(676, 611);
            this.DecryptTabPage.TabIndex = 2;
            this.DecryptTabPage.Text = "Decrypt";
            this.DecryptTabPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(676, 611);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.DecryptedMessageTextBox, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 308);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(670, 300);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // DecryptedMessageTextBox
            // 
            this.DecryptedMessageTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DecryptedMessageTextBox.Location = new System.Drawing.Point(3, 63);
            this.DecryptedMessageTextBox.Multiline = true;
            this.DecryptedMessageTextBox.Name = "DecryptedMessageTextBox";
            this.DecryptedMessageTextBox.ReadOnly = true;
            this.DecryptedMessageTextBox.Size = new System.Drawing.Size(664, 234);
            this.DecryptedMessageTextBox.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel4.Controls.Add(this.label9, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.DecryptButton, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.DecryptPassphraseTextBox, 1, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(664, 54);
            this.tableLayoutPanel4.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label9.Location = new System.Drawing.Point(470, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Passphrase";
            // 
            // DecryptButton
            // 
            this.DecryptButton.Location = new System.Drawing.Point(587, 30);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(74, 21);
            this.DecryptButton.TabIndex = 5;
            this.DecryptButton.Text = "Decrypt";
            this.DecryptButton.UseVisualStyleBackColor = true;
            this.DecryptButton.Click += new System.EventHandler(this.DecryptButton_Click);
            // 
            // DecryptPassphraseTextBox
            // 
            this.DecryptPassphraseTextBox.Location = new System.Drawing.Point(470, 30);
            this.DecryptPassphraseTextBox.Name = "DecryptPassphraseTextBox";
            this.DecryptPassphraseTextBox.PasswordChar = '*';
            this.DecryptPassphraseTextBox.Size = new System.Drawing.Size(111, 20);
            this.DecryptPassphraseTextBox.TabIndex = 3;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.DecryptPrivateTextBox, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.DecryptPlainTextBox, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.label11, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.label12, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(670, 299);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // DecryptPrivateTextBox
            // 
            this.DecryptPrivateTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DecryptPrivateTextBox.Location = new System.Drawing.Point(338, 23);
            this.DecryptPrivateTextBox.Multiline = true;
            this.DecryptPrivateTextBox.Name = "DecryptPrivateTextBox";
            this.DecryptPrivateTextBox.Size = new System.Drawing.Size(329, 273);
            this.DecryptPrivateTextBox.TabIndex = 4;
            // 
            // DecryptPlainTextBox
            // 
            this.DecryptPlainTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DecryptPlainTextBox.Location = new System.Drawing.Point(3, 23);
            this.DecryptPlainTextBox.Multiline = true;
            this.DecryptPlainTextBox.Name = "DecryptPlainTextBox";
            this.DecryptPlainTextBox.Size = new System.Drawing.Size(329, 273);
            this.DecryptPlainTextBox.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label11.Location = new System.Drawing.Point(3, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(329, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Encrypted Message";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label12.Location = new System.Drawing.Point(338, 7);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(329, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Private Key";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 661);
            this.Controls.Add(this.KeyGenTabControl);
            this.Controls.Add(this.MainMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WinPGP v1.0";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.KeyGenTabControl.ResumeLayout(false);
            this.KeyGenTabPage.ResumeLayout(false);
            this.MainTableLayoutPanel.ResumeLayout(false);
            this.GenerateTableLayoutPanel.ResumeLayout(false);
            this.GenerateTableLayoutPanel.PerformLayout();
            this.KeysTableLayoutPanel.ResumeLayout(false);
            this.PrivateKeyTableLayoutPanel.ResumeLayout(false);
            this.PrivateKeyTableLayoutPanel.PerformLayout();
            this.PublicKeyTableLayoutPanel.ResumeLayout(false);
            this.PublicKeyTableLayoutPanel.PerformLayout();
            this.EncryptTabPage.ResumeLayout(false);
            this.EncryptTableLayoutPanel.ResumeLayout(false);
            this.Encrypt2TableLayoutPanel.ResumeLayout(false);
            this.Encrypt2TableLayoutPanel.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.EncryptKeysTableLayoutPanel.ResumeLayout(false);
            this.EncryptKeysTableLayoutPanel.PerformLayout();
            this.DecryptTabPage.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private new System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.TabControl KeyGenTabControl;
        private System.Windows.Forms.TabPage KeyGenTabPage;
        private System.Windows.Forms.TabPage EncryptTabPage;
        private System.Windows.Forms.TableLayoutPanel MainTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel GenerateTableLayoutPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.TextBox PassphraseTextBox;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.TableLayoutPanel KeysTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel PrivateKeyTableLayoutPanel;
        private System.Windows.Forms.Label PrivateKeyLabel;
        private System.Windows.Forms.TextBox PrivateKeyTextBox;
        private System.Windows.Forms.TableLayoutPanel PublicKeyTableLayoutPanel;
        private System.Windows.Forms.Label PublicKeyLabel;
        private System.Windows.Forms.TextBox PublicKeyTextBox;
        private System.Windows.Forms.TabPage DecryptTabPage;
        private System.Windows.Forms.TableLayoutPanel EncryptTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel EncryptKeysTableLayoutPanel;
        private System.Windows.Forms.TextBox EncryptPublicKeyTextBox;
        private System.Windows.Forms.TextBox EncryptPrivateKeyTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel Encrypt2TableLayoutPanel;
        private System.Windows.Forms.TextBox EncryptedTextBox;
        private System.Windows.Forms.TextBox EncryptPlainTextBox;
        private System.Windows.Forms.Button EncrypButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox EncryptPassPhraseTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox DecryptedMessageTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button DecryptButton;
        private System.Windows.Forms.TextBox DecryptPassphraseTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TextBox DecryptPrivateTextBox;
        private System.Windows.Forms.TextBox DecryptPlainTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
    }
}

