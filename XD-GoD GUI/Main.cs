using System;
using System.IO;
using System.Text;

namespace XD_GoD_GUI

{ 
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
                    string path;
                    path = CurrentFile.FileName;

                    using(FileStream fsSource = new FileStream(path, FileMode.Open, FileAccess.Read))
                    {
                        // Read bytes into array
                        byte[] bytes = new byte[6]; // Only first 6 bytes contain version info
                        int bytesToRead = 0;

                        while (bytesToRead <= 6) // Ensures we read all 6 bytes
                        {
                            int n = fsSource.Read(bytes, 0, 6);
                            bytesToRead += n;

                            if(bytesToRead > 6) //Failsafe ensuring the loop is broken when overstepping 6 bytes
                            {
                                break;
                            }
                            string GameID = System.Text.Encoding.ASCII.GetString(bytes);
                            DialogResult result = MessageBox.Show("You have selected:\n" + GameID);
                        }

                    }
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
