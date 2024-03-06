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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FileRenamer
{
    public partial class FileRenamer : Form
    {
        public FileRenamer()
        {
            InitializeComponent();
        }

        private void btnGetPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            // Dialog penceresinin açılışında görünecek klasör
            //folderBrowserDialog.SelectedPath = @"C:\";


            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                //get path of folder
                string folderPath = folderBrowserDialog.SelectedPath;


                txtBoxPath.Text = folderPath;
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            string selectedFolderPath = "";
            string newFilePath = "";
            string newFileName = "";

            bool check = false;
            try
            {
                if (!String.IsNullOrWhiteSpace(txtBoxPath.Text) && !String.IsNullOrWhiteSpace(txtBoxFileName.Text))
                {
                    check = true;
                    selectedFolderPath = txtBoxPath.Text;

                    // get all files
                    string[] files = Directory.GetFiles(selectedFolderPath);

                    int fileIndex = 1;
                    string prefix = txtBoxFileName.Text.TrimStart().TrimEnd();

                    foreach (string file in files)
                    {
                        //string fileName = Path.GetFileNameWithoutExtension(file); // get file name withoute extension
                        string fileExtension = Path.GetExtension(file); // get extension of file


                        if (checkBoxSaveExtension.Checked)
                        {
                            newFileName = $"{fileIndex}_{prefix}" + fileExtension.ToLower();
                            newFilePath = Path.Combine(selectedFolderPath, newFileName); // Yeni tam dosya yolu
                        }
                        else
                        {
                            newFileName = $"{fileIndex}_{prefix}" + (fileExtension.ToLower() != ".jpg" ? ".jpg" : fileExtension);
                            newFilePath = Path.Combine(selectedFolderPath, newFileName);
                        }



                        // Rename the file
                        File.Move(file, newFilePath);

                        fileIndex++;
                    }

                    //MessageBox.Show(selectedFolderPath);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show($" HATA {exception.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                if (check)
                {
                    MessageBox.Show("The process completed successfully.", "SUCCESSFULL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    System.Diagnostics.Process.Start(selectedFolderPath);
                }
                else
                {
                    MessageBox.Show("Make sure that selected folder path and entered a file name", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void txtBoxFileName_TextChanged(object sender, EventArgs e)
        {

        }

        private void FileRenamer_Load(object sender, EventArgs e)
        {
            checkBoxSaveExtension.Checked = true;
        }
    }
}
