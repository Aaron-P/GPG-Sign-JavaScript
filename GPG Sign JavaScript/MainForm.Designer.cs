namespace GPG_Sign_JavaScript
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.gpgPathTextBox = new System.Windows.Forms.TextBox();
            this.gpgExecutableGroupBox = new System.Windows.Forms.GroupBox();
            this.gpgLocateButton = new System.Windows.Forms.Button();
            this.gpgFindDialog = new System.Windows.Forms.OpenFileDialog();
            this.signingKeyGroupBox = new System.Windows.Forms.GroupBox();
            this.signingKeyListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.unmaskPassphraseCheckBox = new System.Windows.Forms.CheckBox();
            this.passphraseLabel = new System.Windows.Forms.Label();
            this.passphraseTextBox = new System.Windows.Forms.TextBox();
            this.scriptFilesGroupBox = new System.Windows.Forms.GroupBox();
            this.minificationWarningLabel = new System.Windows.Forms.Label();
            this.outputFolderCheckBox = new System.Windows.Forms.CheckBox();
            this.outputFolderSelectButton = new System.Windows.Forms.Button();
            this.outputFolderLabel = new System.Windows.Forms.Label();
            this.outputFolderTextBox = new System.Windows.Forms.TextBox();
            this.scriptsClearButton = new System.Windows.Forms.Button();
            this.outputMaskLabel = new System.Windows.Forms.Label();
            this.outputMaskTextBox = new System.Windows.Forms.TextBox();
            this.scriptFileListView = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.scriptsSelectButton = new System.Windows.Forms.Button();
            this.jsOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.jsSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.signScriptsButton = new System.Windows.Forms.Button();
            this.headerTextGroupBox = new System.Windows.Forms.GroupBox();
            this.headerTextRichTextBox = new System.Windows.Forms.RichTextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.outputFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.gpgExecutableGroupBox.SuspendLayout();
            this.signingKeyGroupBox.SuspendLayout();
            this.scriptFilesGroupBox.SuspendLayout();
            this.headerTextGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpgPathTextBox
            // 
            this.gpgPathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpgPathTextBox.Location = new System.Drawing.Point(6, 21);
            this.gpgPathTextBox.Name = "gpgPathTextBox";
            this.gpgPathTextBox.Size = new System.Drawing.Size(338, 20);
            this.gpgPathTextBox.TabIndex = 0;
            this.gpgPathTextBox.TextChanged += new System.EventHandler(this.gpgPathTextBox_TextChanged);
            // 
            // gpgExecutableGroupBox
            // 
            this.gpgExecutableGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpgExecutableGroupBox.Controls.Add(this.gpgLocateButton);
            this.gpgExecutableGroupBox.Controls.Add(this.gpgPathTextBox);
            this.gpgExecutableGroupBox.Location = new System.Drawing.Point(12, 340);
            this.gpgExecutableGroupBox.Name = "gpgExecutableGroupBox";
            this.gpgExecutableGroupBox.Size = new System.Drawing.Size(436, 48);
            this.gpgExecutableGroupBox.TabIndex = 1;
            this.gpgExecutableGroupBox.TabStop = false;
            this.gpgExecutableGroupBox.Text = "GPG Executable";
            // 
            // gpgLocateButton
            // 
            this.gpgLocateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gpgLocateButton.Location = new System.Drawing.Point(350, 19);
            this.gpgLocateButton.Name = "gpgLocateButton";
            this.gpgLocateButton.Size = new System.Drawing.Size(80, 23);
            this.gpgLocateButton.TabIndex = 1;
            this.gpgLocateButton.Text = "Find gpg.exe";
            this.gpgLocateButton.UseVisualStyleBackColor = true;
            this.gpgLocateButton.Click += new System.EventHandler(this.gpgLocateButton_Click);
            // 
            // gpgFindDialog
            // 
            this.gpgFindDialog.FileName = "gpg.exe";
            this.gpgFindDialog.Filter = "GPG Executable|gpg.exe";
            // 
            // signingKeyGroupBox
            // 
            this.signingKeyGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.signingKeyGroupBox.Controls.Add(this.signingKeyListView);
            this.signingKeyGroupBox.Controls.Add(this.unmaskPassphraseCheckBox);
            this.signingKeyGroupBox.Controls.Add(this.passphraseLabel);
            this.signingKeyGroupBox.Controls.Add(this.passphraseTextBox);
            this.signingKeyGroupBox.Enabled = false;
            this.signingKeyGroupBox.Location = new System.Drawing.Point(12, 394);
            this.signingKeyGroupBox.Name = "signingKeyGroupBox";
            this.signingKeyGroupBox.Size = new System.Drawing.Size(436, 147);
            this.signingKeyGroupBox.TabIndex = 2;
            this.signingKeyGroupBox.TabStop = false;
            this.signingKeyGroupBox.Text = "Signing Key";
            // 
            // signingKeyListView
            // 
            this.signingKeyListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.signingKeyListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.signingKeyListView.FullRowSelect = true;
            this.signingKeyListView.GridLines = true;
            this.signingKeyListView.Location = new System.Drawing.Point(6, 19);
            this.signingKeyListView.MultiSelect = false;
            this.signingKeyListView.Name = "signingKeyListView";
            this.signingKeyListView.Size = new System.Drawing.Size(424, 96);
            this.signingKeyListView.TabIndex = 3;
            this.signingKeyListView.UseCompatibleStateImageBehavior = false;
            this.signingKeyListView.View = System.Windows.Forms.View.Details;
            this.signingKeyListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.signingKeyListView_ColumnClick);
            this.signingKeyListView.SelectedIndexChanged += new System.EventHandler(this.signingKeyListView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Email";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Created";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Expires";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Algorithms";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Size";
            // 
            // unmaskPassphraseCheckBox
            // 
            this.unmaskPassphraseCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.unmaskPassphraseCheckBox.AutoSize = true;
            this.unmaskPassphraseCheckBox.Location = new System.Drawing.Point(365, 123);
            this.unmaskPassphraseCheckBox.Name = "unmaskPassphraseCheckBox";
            this.unmaskPassphraseCheckBox.Size = new System.Drawing.Size(65, 17);
            this.unmaskPassphraseCheckBox.TabIndex = 2;
            this.unmaskPassphraseCheckBox.Text = "Unmask";
            this.unmaskPassphraseCheckBox.UseVisualStyleBackColor = true;
            this.unmaskPassphraseCheckBox.CheckedChanged += new System.EventHandler(this.unmaskPassphraseCheckBox_CheckedChanged);
            // 
            // passphraseLabel
            // 
            this.passphraseLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.passphraseLabel.AutoSize = true;
            this.passphraseLabel.Location = new System.Drawing.Point(6, 124);
            this.passphraseLabel.Name = "passphraseLabel";
            this.passphraseLabel.Size = new System.Drawing.Size(65, 13);
            this.passphraseLabel.TabIndex = 1;
            this.passphraseLabel.Text = "Passphrase:";
            // 
            // passphraseTextBox
            // 
            this.passphraseTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passphraseTextBox.Location = new System.Drawing.Point(77, 121);
            this.passphraseTextBox.Name = "passphraseTextBox";
            this.passphraseTextBox.PasswordChar = '●';
            this.passphraseTextBox.Size = new System.Drawing.Size(282, 20);
            this.passphraseTextBox.TabIndex = 0;
            // 
            // scriptFilesGroupBox
            // 
            this.scriptFilesGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scriptFilesGroupBox.Controls.Add(this.minificationWarningLabel);
            this.scriptFilesGroupBox.Controls.Add(this.outputFolderCheckBox);
            this.scriptFilesGroupBox.Controls.Add(this.outputFolderSelectButton);
            this.scriptFilesGroupBox.Controls.Add(this.outputFolderLabel);
            this.scriptFilesGroupBox.Controls.Add(this.outputFolderTextBox);
            this.scriptFilesGroupBox.Controls.Add(this.scriptsClearButton);
            this.scriptFilesGroupBox.Controls.Add(this.outputMaskLabel);
            this.scriptFilesGroupBox.Controls.Add(this.outputMaskTextBox);
            this.scriptFilesGroupBox.Controls.Add(this.scriptFileListView);
            this.scriptFilesGroupBox.Controls.Add(this.scriptsSelectButton);
            this.scriptFilesGroupBox.Location = new System.Drawing.Point(12, 12);
            this.scriptFilesGroupBox.Name = "scriptFilesGroupBox";
            this.scriptFilesGroupBox.Size = new System.Drawing.Size(436, 220);
            this.scriptFilesGroupBox.TabIndex = 4;
            this.scriptFilesGroupBox.TabStop = false;
            this.scriptFilesGroupBox.Text = "JavaScript Files";
            // 
            // minificationWarningLabel
            // 
            this.minificationWarningLabel.AutoSize = true;
            this.minificationWarningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minificationWarningLabel.Location = new System.Drawing.Point(6, 24);
            this.minificationWarningLabel.Name = "minificationWarningLabel";
            this.minificationWarningLabel.Size = new System.Drawing.Size(219, 13);
            this.minificationWarningLabel.TabIndex = 9;
            this.minificationWarningLabel.Text = "Any minification must be done before signing.";
            // 
            // outputFolderCheckBox
            // 
            this.outputFolderCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.outputFolderCheckBox.AutoSize = true;
            this.outputFolderCheckBox.Checked = true;
            this.outputFolderCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.outputFolderCheckBox.Location = new System.Drawing.Point(297, 169);
            this.outputFolderCheckBox.Name = "outputFolderCheckBox";
            this.outputFolderCheckBox.Size = new System.Drawing.Size(132, 17);
            this.outputFolderCheckBox.TabIndex = 8;
            this.outputFolderCheckBox.Text = "Output to Same Folder";
            this.outputFolderCheckBox.UseVisualStyleBackColor = true;
            this.outputFolderCheckBox.CheckedChanged += new System.EventHandler(this.outputFolderCheckBox_CheckedChanged);
            // 
            // outputFolderSelectButton
            // 
            this.outputFolderSelectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.outputFolderSelectButton.Enabled = false;
            this.outputFolderSelectButton.Location = new System.Drawing.Point(297, 191);
            this.outputFolderSelectButton.Name = "outputFolderSelectButton";
            this.outputFolderSelectButton.Size = new System.Drawing.Size(133, 23);
            this.outputFolderSelectButton.TabIndex = 7;
            this.outputFolderSelectButton.Text = "Select Output Folder";
            this.outputFolderSelectButton.UseVisualStyleBackColor = true;
            this.outputFolderSelectButton.Click += new System.EventHandler(this.outputFolderSelectButton_Click);
            // 
            // outputFolderLabel
            // 
            this.outputFolderLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.outputFolderLabel.AutoSize = true;
            this.outputFolderLabel.Enabled = false;
            this.outputFolderLabel.Location = new System.Drawing.Point(8, 196);
            this.outputFolderLabel.Name = "outputFolderLabel";
            this.outputFolderLabel.Size = new System.Drawing.Size(74, 13);
            this.outputFolderLabel.TabIndex = 6;
            this.outputFolderLabel.Text = "Output Folder:";
            // 
            // outputFolderTextBox
            // 
            this.outputFolderTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputFolderTextBox.Enabled = false;
            this.outputFolderTextBox.Location = new System.Drawing.Point(88, 193);
            this.outputFolderTextBox.Name = "outputFolderTextBox";
            this.outputFolderTextBox.Size = new System.Drawing.Size(203, 20);
            this.outputFolderTextBox.TabIndex = 5;
            this.outputFolderTextBox.TextChanged += new System.EventHandler(this.outputFolderTextBox_TextChanged);
            // 
            // scriptsClearButton
            // 
            this.scriptsClearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.scriptsClearButton.Enabled = false;
            this.scriptsClearButton.Location = new System.Drawing.Point(350, 19);
            this.scriptsClearButton.Name = "scriptsClearButton";
            this.scriptsClearButton.Size = new System.Drawing.Size(80, 23);
            this.scriptsClearButton.TabIndex = 4;
            this.scriptsClearButton.Text = "Clear List";
            this.scriptsClearButton.UseVisualStyleBackColor = true;
            this.scriptsClearButton.Click += new System.EventHandler(this.scriptsClearButton_Click);
            // 
            // outputMaskLabel
            // 
            this.outputMaskLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.outputMaskLabel.AutoSize = true;
            this.outputMaskLabel.Location = new System.Drawing.Point(7, 170);
            this.outputMaskLabel.Name = "outputMaskLabel";
            this.outputMaskLabel.Size = new System.Drawing.Size(75, 13);
            this.outputMaskLabel.TabIndex = 3;
            this.outputMaskLabel.Text = "Output Mask*:";
            // 
            // outputMaskTextBox
            // 
            this.outputMaskTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputMaskTextBox.Location = new System.Drawing.Point(88, 167);
            this.outputMaskTextBox.Name = "outputMaskTextBox";
            this.outputMaskTextBox.Size = new System.Drawing.Size(203, 20);
            this.outputMaskTextBox.TabIndex = 2;
            this.outputMaskTextBox.Text = "<file name>.asc.js";
            this.toolTip.SetToolTip(this.outputMaskTextBox, "<file name> = Name of input file.");
            this.outputMaskTextBox.TextChanged += new System.EventHandler(this.outputMaskTextBox_TextChanged);
            // 
            // scriptFileListView
            // 
            this.scriptFileListView.AllowDrop = true;
            this.scriptFileListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scriptFileListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9});
            this.scriptFileListView.FullRowSelect = true;
            this.scriptFileListView.GridLines = true;
            this.scriptFileListView.Location = new System.Drawing.Point(6, 48);
            this.scriptFileListView.Name = "scriptFileListView";
            this.scriptFileListView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.scriptFileListView.Size = new System.Drawing.Size(424, 113);
            this.scriptFileListView.TabIndex = 1;
            this.scriptFileListView.UseCompatibleStateImageBehavior = false;
            this.scriptFileListView.View = System.Windows.Forms.View.Details;
            this.scriptFileListView.DragDrop += new System.Windows.Forms.DragEventHandler(this.scriptFileListView_DragDrop);
            this.scriptFileListView.DragEnter += new System.Windows.Forms.DragEventHandler(this.scriptFileListView_DragEnter);
            this.scriptFileListView.KeyUp += new System.Windows.Forms.KeyEventHandler(this.scriptFileListView_KeyUp);
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Input File";
            this.columnHeader8.Width = 210;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Output File";
            this.columnHeader9.Width = 210;
            // 
            // scriptsSelectButton
            // 
            this.scriptsSelectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.scriptsSelectButton.Location = new System.Drawing.Point(264, 19);
            this.scriptsSelectButton.Name = "scriptsSelectButton";
            this.scriptsSelectButton.Size = new System.Drawing.Size(80, 23);
            this.scriptsSelectButton.TabIndex = 0;
            this.scriptsSelectButton.Text = "Select Files";
            this.scriptsSelectButton.UseVisualStyleBackColor = true;
            this.scriptsSelectButton.Click += new System.EventHandler(this.scriptsSelectButton_Click);
            // 
            // jsOpenFileDialog
            // 
            this.jsOpenFileDialog.Filter = "JavaScript Files|*.js";
            this.jsOpenFileDialog.Multiselect = true;
            // 
            // signScriptsButton
            // 
            this.signScriptsButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.signScriptsButton.Enabled = false;
            this.signScriptsButton.Location = new System.Drawing.Point(12, 547);
            this.signScriptsButton.Name = "signScriptsButton";
            this.signScriptsButton.Size = new System.Drawing.Size(436, 23);
            this.signScriptsButton.TabIndex = 5;
            this.signScriptsButton.Text = "Sign JavaScript Files";
            this.signScriptsButton.UseVisualStyleBackColor = true;
            // 
            // headerTextGroupBox
            // 
            this.headerTextGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headerTextGroupBox.Controls.Add(this.headerTextRichTextBox);
            this.headerTextGroupBox.Location = new System.Drawing.Point(12, 238);
            this.headerTextGroupBox.Name = "headerTextGroupBox";
            this.headerTextGroupBox.Size = new System.Drawing.Size(436, 96);
            this.headerTextGroupBox.TabIndex = 6;
            this.headerTextGroupBox.TabStop = false;
            this.headerTextGroupBox.Text = "Header Text*";
            // 
            // headerTextRichTextBox
            // 
            this.headerTextRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headerTextRichTextBox.Location = new System.Drawing.Point(6, 19);
            this.headerTextRichTextBox.Name = "headerTextRichTextBox";
            this.headerTextRichTextBox.Size = new System.Drawing.Size(423, 71);
            this.headerTextRichTextBox.TabIndex = 0;
            this.headerTextRichTextBox.Text = resources.GetString("headerTextRichTextBox.Text");
            this.toolTip.SetToolTip(this.headerTextRichTextBox, "<key id> = The id of the used signing key.\r\n<key name> = The name on the used sig" +
        "ning key.\r\n<key email> = The email address on the used signing key.\r\n<file name>" +
        " = The full name of the output file.");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 582);
            this.Controls.Add(this.headerTextGroupBox);
            this.Controls.Add(this.scriptFilesGroupBox);
            this.Controls.Add(this.signingKeyGroupBox);
            this.Controls.Add(this.gpgExecutableGroupBox);
            this.Controls.Add(this.signScriptsButton);
            this.MinimumSize = new System.Drawing.Size(476, 620);
            this.Name = "MainForm";
            this.Text = "GPG Sign JavaScript";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.gpgExecutableGroupBox.ResumeLayout(false);
            this.gpgExecutableGroupBox.PerformLayout();
            this.signingKeyGroupBox.ResumeLayout(false);
            this.signingKeyGroupBox.PerformLayout();
            this.scriptFilesGroupBox.ResumeLayout(false);
            this.scriptFilesGroupBox.PerformLayout();
            this.headerTextGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox gpgPathTextBox;
        private System.Windows.Forms.GroupBox gpgExecutableGroupBox;
        private System.Windows.Forms.Button gpgLocateButton;
        private System.Windows.Forms.OpenFileDialog gpgFindDialog;
        private System.Windows.Forms.GroupBox signingKeyGroupBox;
        private System.Windows.Forms.GroupBox scriptFilesGroupBox;
        private System.Windows.Forms.OpenFileDialog jsOpenFileDialog;
        private System.Windows.Forms.SaveFileDialog jsSaveFileDialog;
        private System.Windows.Forms.Label passphraseLabel;
        private System.Windows.Forms.TextBox passphraseTextBox;
        private System.Windows.Forms.CheckBox unmaskPassphraseCheckBox;
        private System.Windows.Forms.Button scriptsSelectButton;
        private System.Windows.Forms.ListView signingKeyListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button signScriptsButton;
        private System.Windows.Forms.ListView scriptFileListView;
        private System.Windows.Forms.Label outputMaskLabel;
        private System.Windows.Forms.TextBox outputMaskTextBox;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Button scriptsClearButton;
        private System.Windows.Forms.GroupBox headerTextGroupBox;
        private System.Windows.Forms.RichTextBox headerTextRichTextBox;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.FolderBrowserDialog outputFolderBrowserDialog;
        private System.Windows.Forms.Button outputFolderSelectButton;
        private System.Windows.Forms.Label outputFolderLabel;
        private System.Windows.Forms.TextBox outputFolderTextBox;
        private System.Windows.Forms.CheckBox outputFolderCheckBox;
        private System.Windows.Forms.Label minificationWarningLabel;
    }
}

