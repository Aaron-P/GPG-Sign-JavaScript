/**
 * GPL (because of gpgapi)
 * 
 * 
 * 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using GpgApi;
using Microsoft.Win32;

namespace GPG_Sign_JavaScript
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void gpgLocateButton_Click(object sender, EventArgs e)
        {
            DialogResult result = gpgFindDialog.ShowDialog();
            if (result == DialogResult.OK)
                gpgPathTextBox.Text = gpgFindDialog.FileName;//Check file?
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string gpgPath = Program.gpgGetPath();
            if (gpgPath != null)
                gpgPathTextBox.Text = gpgPath;
        }

        private void gpgPathTextBox_TextChanged(object sender, EventArgs e)//change only allow valid chars
        {
            if (Program.gpgIsValid(gpgPathTextBox.Text))
            {
                signingKeyGroupBox.Enabled = true;
            
                GpgListSecretKeys privateKeys = new GpgListSecretKeys();
                privateKeys.Execute();

                foreach (Key key in privateKeys.Keys)
                {
                    if (!key.IsDisabled)
                    {
                        string[] row = {
                            "0x" + key.Id.ToString().Substring(key.Id.ToString().Length - 8),
                            key.UserInfos[0].Name.ToString(),//Assuming the first value is the default and will be recognized. //Does this always exist?
                            key.UserInfos[0].Email.ToString(),//Assuming the first value is the default and will be recognized. //Does this always exist?
                            key.CreationDate.ToString(),
                            key.ExpirationDate.ToString(),
                            key.Algorithm.ToString(),
                            key.Size.ToString()
                        };

                        ListViewItem lvi = new ListViewItem(row);
                        signingKeyListView.Items.Add(lvi);
                    }
                }
                if (signingKeyListView.Items.Count > 0)
                {
                    Program.autoSizeListViewColumns(signingKeyListView);
                    signingKeyListView.Items[0].Selected = true;//not working?
                }
            }
            else
            {
                signingKeyListView.Items.Clear();
                signingKeyGroupBox.Enabled = false;
                passphraseTextBox.Text = "";

                for (int i = 0; i <= 6; i++)
                    signingKeyListView.Columns[i].Width = 60;//Do dynamically
            }
        }

        private void scriptsSelectButton_Click(object sender, EventArgs e)
        {
            DialogResult result = jsOpenFileDialog.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                foreach (string file in jsOpenFileDialog.FileNames)
                {
                    if (scriptFileListView.FindItemWithText(file) == null)
                    {
                        string outputFileName = Path.GetFileNameWithoutExtension(file) + ".asc.js";
                        if (outputMaskTextBox.Text.Length > 0)//check valid chars, strip invalid
                            outputFileName = outputMaskTextBox.Text.Replace("<file name>", Path.GetFileNameWithoutExtension(file));

                        string outputPath = Path.GetDirectoryName(file);
                        if (!outputFolderCheckBox.Checked && outputFolderTextBox.Text.Length > 0)//check valid path
                        {
//                            if (outputFolderTextBox.Text.Substring(outputFolderTextBox.Text.Length - 1, 1) == "\\")


                            outputPath = outputFolderTextBox.Text;//CHECK IS VALID FIRST
                        }

                        string[] row = {
                            file,
                            outputPath + "\\" + outputFileName
                        };

                        ListViewItem lvi = new ListViewItem(row);
                        scriptFileListView.Items.Add(lvi);
                    }
                }
                if (scriptFileListView.Items.Count > 0)
                {
                    Program.autoSizeListViewColumns(scriptFileListView);
                    scriptsClearButton.Enabled = true;
                }


//                jsOpenFileDialog.FileNames;
//                string file = gpgFindDialog.FileName;
//                gpgPathTextBox.Text = file;
            }
        }

        private void unmaskPassphraseCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (unmaskPassphraseCheckBox.Checked)
                passphraseTextBox.PasswordChar = '\0';
            else
                passphraseTextBox.PasswordChar = '●';
        }

        private void signingKeyListView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            //add sorting
        }

        private void signingKeyListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (signingKeyListView.SelectedItems.Count > 0)
                ;
        }

        private void scriptsClearButton_Click(object sender, EventArgs e)
        {
            scriptFileListView.Items.Clear();
            scriptsClearButton.Enabled = false;

            for (int i = 0; i <= 1; i++)
                scriptFileListView.Columns[i].Width = 210;//Do dynamically
        }

        private void outputFolderCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            outputFolderLabel.Enabled = !outputFolderCheckBox.Checked;
            outputFolderTextBox.Enabled = !outputFolderCheckBox.Checked;
            outputFolderSelectButton.Enabled = !outputFolderCheckBox.Checked;
        }

        private void outputFolderSelectButton_Click(object sender, EventArgs e)
        {
            DialogResult result = outputFolderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
                outputFolderTextBox.Text = outputFolderBrowserDialog.SelectedPath;
        }

        private void scriptFileListView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                foreach (ListViewItem listViewItem in scriptFileListView.SelectedItems)
                    listViewItem.Remove();
            }
        }

        private void scriptFileListView_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void scriptFileListView_DragDrop(object sender, DragEventArgs e)
        {
            string[] FileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            foreach (string filePath in FileList)
                ;//redo output paths
        }

        private void outputFolderTextBox_TextChanged(object sender, EventArgs e)
        {
            if (outputFolderCheckBox.Checked)
                ;//redo output paths
        }

        private void outputMaskTextBox_TextChanged(object sender, EventArgs e)
        {
            if (outputFolderCheckBox.Checked)
                ;//redo output paths
        }










        //refresh keys button?


//        if (scriptFileListView.Items.Count > 0)
//            ;

        //scriptFileListView dont highlight/dont allow select

        //try to get gpg path from registry
        //save path to config file?
        //option to save files individually or as .asc.js or replace existing file
        //check if save as has a . in front, if not then add a .
        //header
        //auto resize column of js files for scrollbar
        //open/read file exception handling
        //handle exceptions from gpg api
        //abstract this

        //output folder options
        //output file options
        //header message
        //tooltips to describe mask values
        //trim strings and properly format
        //does column reorder changed indexes?
        //report success and failure per file, report totals
        //reset column widths on clear
        //set dialog titles
        //add sorting
        //set default open folder to gnupg folder if found
    }
}
