namespace PasswordGenerator
{
    partial class Form1
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
            this.tbPasswordType = new System.Windows.Forms.TabControl();
            this.tabRandom = new System.Windows.Forms.TabPage();
            this.cbLowerCase = new System.Windows.Forms.CheckBox();
            this.cbUpperCase = new System.Windows.Forms.CheckBox();
            this.cbSpecialChars = new System.Windows.Forms.CheckBox();
            this.cbInt = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabMemorable = new System.Windows.Forms.TabPage();
            this.tbKeyWord = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.automaticallyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToDefaultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.nbLength = new System.Windows.Forms.NumericUpDown();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.tbSinglePassword = new System.Windows.Forms.TextBox();
            this.pbProgress = new System.Windows.Forms.ProgressBar();
            this.lblBits = new System.Windows.Forms.Label();
            this.msMultiple = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.generateMultiplePasswordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbPasswordType.SuspendLayout();
            this.tabRandom.SuspendLayout();
            this.tabMemorable.SuspendLayout();
            this.msMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbLength)).BeginInit();
            this.msMultiple.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbPasswordType
            // 
            this.tbPasswordType.Controls.Add(this.tabRandom);
            this.tbPasswordType.Controls.Add(this.tabMemorable);
            this.tbPasswordType.Location = new System.Drawing.Point(-2, 78);
            this.tbPasswordType.Name = "tbPasswordType";
            this.tbPasswordType.SelectedIndex = 0;
            this.tbPasswordType.Size = new System.Drawing.Size(613, 317);
            this.tbPasswordType.TabIndex = 0;
            this.tbPasswordType.Selected += new System.Windows.Forms.TabControlEventHandler(this.TbPasswordType_Selected);
            // 
            // tabRandom
            // 
            this.tabRandom.Controls.Add(this.cbLowerCase);
            this.tabRandom.Controls.Add(this.cbUpperCase);
            this.tabRandom.Controls.Add(this.cbSpecialChars);
            this.tabRandom.Controls.Add(this.cbInt);
            this.tabRandom.Controls.Add(this.label2);
            this.tabRandom.Location = new System.Drawing.Point(4, 22);
            this.tabRandom.Name = "tabRandom";
            this.tabRandom.Padding = new System.Windows.Forms.Padding(3);
            this.tabRandom.Size = new System.Drawing.Size(605, 291);
            this.tabRandom.TabIndex = 0;
            this.tabRandom.Text = "Random";
            this.tabRandom.UseVisualStyleBackColor = true;
            // 
            // cbLowerCase
            // 
            this.cbLowerCase.AutoSize = true;
            this.cbLowerCase.Checked = true;
            this.cbLowerCase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbLowerCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLowerCase.Location = new System.Drawing.Point(12, 90);
            this.cbLowerCase.Name = "cbLowerCase";
            this.cbLowerCase.Size = new System.Drawing.Size(139, 28);
            this.cbLowerCase.TabIndex = 5;
            this.cbLowerCase.Text = "LowerCase:";
            this.cbLowerCase.UseVisualStyleBackColor = true;
            this.cbLowerCase.CheckedChanged += new System.EventHandler(this.CbLowerCase_CheckedChanged);
            // 
            // cbUpperCase
            // 
            this.cbUpperCase.AutoSize = true;
            this.cbUpperCase.Checked = true;
            this.cbUpperCase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbUpperCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUpperCase.Location = new System.Drawing.Point(13, 138);
            this.cbUpperCase.Name = "cbUpperCase";
            this.cbUpperCase.Size = new System.Drawing.Size(139, 28);
            this.cbUpperCase.TabIndex = 4;
            this.cbUpperCase.Text = "UpperCase:";
            this.cbUpperCase.UseVisualStyleBackColor = true;
            this.cbUpperCase.CheckedChanged += new System.EventHandler(this.CbUpperCase_CheckedChanged);
            // 
            // cbSpecialChars
            // 
            this.cbSpecialChars.AutoSize = true;
            this.cbSpecialChars.Checked = true;
            this.cbSpecialChars.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSpecialChars.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSpecialChars.Location = new System.Drawing.Point(13, 186);
            this.cbSpecialChars.Name = "cbSpecialChars";
            this.cbSpecialChars.Size = new System.Drawing.Size(210, 28);
            this.cbSpecialChars.TabIndex = 3;
            this.cbSpecialChars.Text = "Special Characters:";
            this.cbSpecialChars.UseVisualStyleBackColor = true;
            this.cbSpecialChars.CheckedChanged += new System.EventHandler(this.CbSpecialChars_CheckedChanged);
            // 
            // cbInt
            // 
            this.cbInt.AutoSize = true;
            this.cbInt.Checked = true;
            this.cbInt.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbInt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbInt.Location = new System.Drawing.Point(13, 41);
            this.cbInt.Name = "cbInt";
            this.cbInt.Size = new System.Drawing.Size(110, 28);
            this.cbInt.TabIndex = 2;
            this.cbInt.Text = "Integers:";
            this.cbInt.UseVisualStyleBackColor = true;
            this.cbInt.CheckedChanged += new System.EventHandler(this.CbInt_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(223, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(380, 168);
            this.label2.TabIndex = 1;
            this.label2.Text = "(0123456789)\r\n\r\n(abcdefghijklmnopqrstuvwxyz)\r\n\r\n(ABCDEFGHIJKLMNOPQRSTUVWXYZ)\r\n\r\n(" +
    "!@#$%^&*()_+-=[]{}|;:\',.<>?/~`\"\\)\r\n";
            // 
            // tabMemorable
            // 
            this.tabMemorable.Controls.Add(this.tbKeyWord);
            this.tabMemorable.Controls.Add(this.label3);
            this.tabMemorable.Location = new System.Drawing.Point(4, 22);
            this.tabMemorable.Name = "tabMemorable";
            this.tabMemorable.Padding = new System.Windows.Forms.Padding(3);
            this.tabMemorable.Size = new System.Drawing.Size(605, 291);
            this.tabMemorable.TabIndex = 1;
            this.tabMemorable.Text = "Memorable";
            this.tabMemorable.UseVisualStyleBackColor = true;
            // 
            // tbKeyWord
            // 
            this.tbKeyWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKeyWord.Location = new System.Drawing.Point(251, 58);
            this.tbKeyWord.Name = "tbKeyWord";
            this.tbKeyWord.Size = new System.Drawing.Size(303, 35);
            this.tbKeyWord.TabIndex = 1;
            this.tbKeyWord.TextChanged += new System.EventHandler(this.TbKeyWord_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "Keyword:";
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(611, 24);
            this.msMain.TabIndex = 1;
            this.msMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.automaticallyToolStripMenuItem,
            this.resetToDefaultsToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "&Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.SettingsToolStripMenuItem_Click);
            // 
            // automaticallyToolStripMenuItem
            // 
            this.automaticallyToolStripMenuItem.Name = "automaticallyToolStripMenuItem";
            this.automaticallyToolStripMenuItem.Size = new System.Drawing.Size(294, 22);
            this.automaticallyToolStripMenuItem.Text = "Automatically Copy Generated Passwords";
            // 
            // resetToDefaultsToolStripMenuItem
            // 
            this.resetToDefaultsToolStripMenuItem.Name = "resetToDefaultsToolStripMenuItem";
            this.resetToDefaultsToolStripMenuItem.Size = new System.Drawing.Size(294, 22);
            this.resetToDefaultsToolStripMenuItem.Text = "Reset to Defaults...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Length:";
            // 
            // nbLength
            // 
            this.nbLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbLength.Location = new System.Drawing.Point(144, 37);
            this.nbLength.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nbLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nbLength.Name = "nbLength";
            this.nbLength.Size = new System.Drawing.Size(443, 38);
            this.nbLength.TabIndex = 3;
            this.nbLength.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nbLength.ValueChanged += new System.EventHandler(this.NbLength_ValueChanged);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(14, 439);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(196, 39);
            this.btnGenerate.TabIndex = 4;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopy.Location = new System.Drawing.Point(458, 439);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(145, 39);
            this.btnCopy.TabIndex = 5;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.BtnCopy_Click);
            // 
            // tbSinglePassword
            // 
            this.tbSinglePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.tbSinglePassword.Location = new System.Drawing.Point(216, 445);
            this.tbSinglePassword.Name = "tbSinglePassword";
            this.tbSinglePassword.Size = new System.Drawing.Size(236, 30);
            this.tbSinglePassword.TabIndex = 6;
            // 
            // pbProgress
            // 
            this.pbProgress.Location = new System.Drawing.Point(2, 397);
            this.pbProgress.Name = "pbProgress";
            this.pbProgress.Size = new System.Drawing.Size(605, 24);
            this.pbProgress.TabIndex = 10;
            // 
            // lblBits
            // 
            this.lblBits.AutoSize = true;
            this.lblBits.BackColor = System.Drawing.Color.Transparent;
            this.lblBits.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBits.Location = new System.Drawing.Point(270, 402);
            this.lblBits.Name = "lblBits";
            this.lblBits.Size = new System.Drawing.Size(38, 16);
            this.lblBits.TabIndex = 11;
            this.lblBits.Text = "0 bits";
            // 
            // msMultiple
            // 
            this.msMultiple.BackColor = System.Drawing.SystemColors.ControlLight;
            this.msMultiple.Dock = System.Windows.Forms.DockStyle.None;
            this.msMultiple.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.msMultiple.Location = new System.Drawing.Point(156, 445);
            this.msMultiple.Name = "msMultiple";
            this.msMultiple.Size = new System.Drawing.Size(48, 27);
            this.msMultiple.TabIndex = 12;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateMultiplePasswordsToolStripMenuItem});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(40, 23);
            this.toolStripMenuItem1.Text = "🔻";
            // 
            // generateMultiplePasswordsToolStripMenuItem
            // 
            this.generateMultiplePasswordsToolStripMenuItem.Name = "generateMultiplePasswordsToolStripMenuItem";
            this.generateMultiplePasswordsToolStripMenuItem.Size = new System.Drawing.Size(256, 24);
            this.generateMultiplePasswordsToolStripMenuItem.Text = "Generate Multiple Passwords";
            this.generateMultiplePasswordsToolStripMenuItem.Click += new System.EventHandler(this.GenerateMultiplePasswordsToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 486);
            this.Controls.Add(this.msMultiple);
            this.Controls.Add(this.lblBits);
            this.Controls.Add(this.pbProgress);
            this.Controls.Add(this.tbSinglePassword);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.nbLength);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPasswordType);
            this.Controls.Add(this.msMain);
            this.MainMenuStrip = this.msMain;
            this.Name = "Form1";
            this.Text = "Password Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tbPasswordType.ResumeLayout(false);
            this.tabRandom.ResumeLayout(false);
            this.tabRandom.PerformLayout();
            this.tabMemorable.ResumeLayout(false);
            this.tabMemorable.PerformLayout();
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbLength)).EndInit();
            this.msMultiple.ResumeLayout(false);
            this.msMultiple.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tbPasswordType;
        private System.Windows.Forms.TabPage tabRandom;
        private System.Windows.Forms.TabPage tabMemorable;
        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem automaticallyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToDefaultsToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nbLength;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.TextBox tbSinglePassword;
        private System.Windows.Forms.ProgressBar pbProgress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbKeyWord;
        private System.Windows.Forms.CheckBox cbInt;
        private System.Windows.Forms.CheckBox cbLowerCase;
        private System.Windows.Forms.CheckBox cbUpperCase;
        private System.Windows.Forms.CheckBox cbSpecialChars;
        private System.Windows.Forms.Label lblBits;
        private System.Windows.Forms.MenuStrip msMultiple;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem generateMultiplePasswordsToolStripMenuItem;
    }
}

