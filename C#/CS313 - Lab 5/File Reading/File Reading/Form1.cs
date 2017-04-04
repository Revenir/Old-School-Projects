//
//          Program:                      Sebastian Rock     (Lab 5)   
//
//          Description:                  Read a range of text lines and output them to a text file   
//
//          Program history:   
//
//                      Date                       Change   
//                      -------     ------------------      -----------
//                      5/3/14             Program written   
// 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace File_Reading
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            txtOpenFilePath.Text = openFileDialog1.FileName;
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text Documents|*.txt";
            openFileDialog1.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReadTextLines_Click(object sender, EventArgs e)
        {
            int integerValidationTest;
            if (!(String.IsNullOrEmpty(txtStartingLineNumber.Text)) &&
                !(String.IsNullOrEmpty(txtEndingLineNumber.Text)) &&
                Path.GetExtension(txtOpenFilePath.Text) == ".txt" &&
                (int.TryParse(txtStartingLineNumber.Text, out integerValidationTest)) &&
                (int.TryParse(txtEndingLineNumber.Text, out integerValidationTest))
                )
            {
                int startingLineNumber = Convert.ToInt32(txtStartingLineNumber.Text);
                int endingLineNumber = Convert.ToInt32(txtEndingLineNumber.Text);

                IEnumerable<string> lines = File.ReadLines(txtOpenFilePath.Text);

                if (startingLineNumber > 0 && endingLineNumber > 0 &&
                    endingLineNumber <= lines.Count() && startingLineNumber <= lines.Count())
                {
                    if (endingLineNumber > startingLineNumber)
                    {
                        var startinglineToRead = startingLineNumber;
                        var startingLine = lines.Skip(startinglineToRead - 1).First();

                        lblStartingTextLine.Text = startingLine;

                        var endingLineToRead = endingLineNumber;
                        var endingLine = lines.Skip(endingLineToRead - 1).First();

                        lblEndingTextLine.Text = endingLine;
                    }
                    else
                        MessageBox.Show("Starting line number must be less than ending line number.");
                }
                else
                    MessageBox.Show("Please enter a valid range of line numbers");
            }
            else
                MessageBox.Show("Please enter valid line numbers of a .txt file");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Path.GetExtension(txtWriteFilePath.Text) != ".txt")
            {
                saveFileDialog1.Filter = "Text Documents|*.txt";
                saveFileDialog1.ShowDialog();

                txtWriteFilePath.Text = saveFileDialog1.FileName;
            }

            IEnumerable<string> lines = File.ReadLines(txtOpenFilePath.Text);
            int startingLineNumber = Convert.ToInt32(txtStartingLineNumber.Text);
            int endingLineNumber = Convert.ToInt32(txtEndingLineNumber.Text);

            var result = lines.Skip(startingLineNumber - 1).Take(endingLineNumber);
            File.WriteAllLines(txtWriteFilePath.Text, result);


        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text Documents|*.txt";
            saveFileDialog1.ShowDialog();

            txtWriteFilePath.Text = saveFileDialog1.FileName;
        }
    }
}
