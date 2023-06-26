using System;
using System.IO;

namespace XD_GoD_GUI
{
    public struct ByteInfo
    {
        byte[] byteArray; // Array of bytes to be written to for required data manipulation
        int currentOffset; //Write offset location for editing byte array and, subsequently, re-writing
        int blockLength; //For each Pokemon block in the db, store the length and commpare the number of bytes to be written to that block. Lets us remove 0's from empty header and insert 0's to the end before writing bytes to ensure nothing is overwritten
    }
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void OpenFile_Click(object sender, EventArgs e) // 
        {
            OpenFileDialog CurrentFile = new(); // New instance of OpenFileDialog
            try
            {
                if (CurrentFile.ShowDialog() == DialogResult.OK)
                {
                    var VersionInfo = new ByteInfo(); //Instantiate struct
                    string path = CurrentFile.ToString();

                    Console.WriteLine(path);

                    {
                    }
                }
            }
            catch (IOException) { } // Event handler for failure to open



        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
