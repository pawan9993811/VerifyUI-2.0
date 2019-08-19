using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using VisualUIAVerify.Controls;

namespace VisualUIAVerify.Forms
{
    public partial class FileCreator : Form
    {
        string fileDirPath = @"C:\CFW";
        public string xmlLocation;
        string strSearchDirectory;
        string txtFileLocation = null;
        string txtFileName = null;
        private const string notAllowedChar = @"/';}{~`!^*?<>|""";

        public FileCreator()
        {
            InitializeComponent();
            FileLocation.Text = fileDirPath;
            FileName.Enabled = false;
        }

        public string NewFileLocation
        {
            get { return xmlLocation; }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            string folderName = string.Concat(FileLocation.Text.Substring(FileLocation.Text.LastIndexOf("\\"), 
                FileLocation.Text.Length - FileLocation.Text.LastIndexOf("\\")).Replace(@"\", ""));

            if (FileLocation.Text == fileDirPath)
            {
                DialogResult dr = MessageBox.Show("Folder Name: '" + folderName + "' already exists. \nClick OK to enter File Location", "Error", MessageBoxButtons.OK);
                FileLocation.Focus();
                return;
            }
            else
            {
                foreach (string d in Directory.GetDirectories(fileDirPath, "*.*", SearchOption.AllDirectories))
                {
                    if (new DirectoryInfo(d).Name.ToUpperInvariant().Equals(folderName.ToUpperInvariant()))
                    {
                        DialogResult dr = MessageBox.Show("Folder Name: '" + folderName + "' already exists. \nClick OK to continue or Cancel to re-enter File Location", 
                            "Warning", MessageBoxButtons.OKCancel);
                        if (dr == DialogResult.Cancel)
                        {
                            FileLocation.Focus();
                            return;
                        }
                        break;
                    }
                }
            }
            try
            {
                // check File not created
                if (!File.Exists(FileLocation.Text + "\\" + FileName.Text))
                {
                    if (!Directory.Exists(FileLocation.Text))
                    {
                        Directory.CreateDirectory(FileLocation.Text);
                    }
                    //create xml file 
                    File.Create(FileLocation.Text + "\\" + FileName.Text);
                    //Strore file location
                    xmlLocation = FileLocation.Text + "\\" + FileName.Text;
                    DialogResult d = MessageBox.Show("'File Created Successfully:' " + string.Concat(FileLocation.Text, @"\", FileName.Text), "Message", MessageBoxButtons.OK);
                    if (d == DialogResult.OK) {
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Folder/File already Exists", "Warining",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Exclamation,
                                  MessageBoxDefaultButton.Button1);
                    xmlLocation = FileLocation.Text + "\\" + FileName.Text;
                }
            }
            catch
            {
                MessageBox.Show("Error creating file .Cannot Access Location");
            }
            AutomationElementTreeControl aetc = new AutomationElementTreeControl();
            aetc.FileName = NewFileLocation;
        }

        public void btnBrowser_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Directory.Exists(fileDirPath))
                {
                    Directory.CreateDirectory(fileDirPath);
                }
                FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
                folderBrowser.SelectedPath = fileDirPath;
                if (folderBrowser.ShowDialog() == DialogResult.OK)
                {
                    strSearchDirectory = folderBrowser.SelectedPath;
                    FileLocation.Text = strSearchDirectory;
                }
                FileName.Text = string.Concat(FileLocation.Text.Substring(FileLocation.Text.LastIndexOf("\\"), FileLocation.Text.Length - FileLocation.Text.LastIndexOf("\\")).Replace(@"\", ""), ".xml");
            }
            catch
            {
                MessageBox.Show("Error Cannot Access Location", "Warining",
                                   MessageBoxButtons.OK,
                                  MessageBoxIcon.Exclamation,
                                  MessageBoxDefaultButton.Button1);
            }
        }

        private void FileLocation_Leave(object sender, EventArgs e)
        {
            if (notAllowedChar.Any(s => FileLocation.Text.Contains(s)))
            {
                MessageBox.Show("A file name cannot contain any of the following characters " + @"/';}{~`!^*?<>|""",
                                    "Error",
                                   MessageBoxButtons.OK,
                                  MessageBoxIcon.Error,
                                  MessageBoxDefaultButton.Button3);
                FileLocation.Text = txtFileLocation;
                return;
            }
            
            FileName.Text = string.Concat(FileLocation.Text.Substring(FileLocation.Text.LastIndexOf("\\"), FileLocation.Text.Length - FileLocation.Text.LastIndexOf("\\")).Replace(@"\", ""), ".xml");
        }

        private void FileLocation_Enter(object sender, EventArgs e)
        {
            txtFileLocation = FileLocation.Text;
        }

        private void FileName_Enter(object sender, EventArgs e)
        {
            if (notAllowedChar.Any(s => FileLocation.Text.Contains(s)))
            {
                MessageBox.Show("A file name cannot contain any of the following characters " + @"/';}{~`!^*?<>|""",
                                    "Error",
                                   MessageBoxButtons.OK,
                                  MessageBoxIcon.Error,
                                  MessageBoxDefaultButton.Button3);
                FileLocation.Text = txtFileLocation;
                return;
            }
            FileName.Text = string.Concat(FileLocation.Text.Substring(FileLocation.Text.LastIndexOf("\\"), FileLocation.Text.Length - FileLocation.Text.LastIndexOf("\\")).Replace(@"\", ""), ".xml");
            txtFileName = FileName.Text;
        }

        private void FileName_Leave(object sender, EventArgs e)
        {
            if (notAllowedChar.Any(s => FileName.Text.Contains(s)))
            {
                MessageBox.Show("A file name cannot contain any of the following characters " + @"/';}{~`!^*?<>|""",
                                    "Error",
                                   MessageBoxButtons.OK,
                                  MessageBoxIcon.Error,
                                  MessageBoxDefaultButton.Button3);
                FileName.Text = txtFileName;
            }
        }
    }
}
