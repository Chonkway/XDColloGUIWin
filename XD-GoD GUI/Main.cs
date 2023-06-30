using System;
using System.IO;
using System.Text;
using System.Xml;
using VersionInfo;

namespace XD_GoD_GUI

{
    public partial class Main : Form
    {
        public string path;

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

        public void OpenFile_Click(object sender, EventArgs e)
        //---------
        // Pulls GameID and conditionally matches title, also displays file size and other information
        //---------
        {
            OpenFileDialog CurrentFile = new(); // New instance of OpenFileDialog
            try
            {
                if (CurrentFile.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Clear(); // clears all previous information displayed 
                    path = CurrentFile.FileName;
                    var fileInfo = new VersionInfo.GameInfo();

                    using (FileStream fsSource = new FileStream(path, FileMode.Open, FileAccess.Read))
                    {
                        // Read bytes into array

                        byte[] bytes = new byte[6]; // Only first 6 bytes contain version info
                        fileInfo.FileSize = new FileInfo(path).Length;
                        int bytesToRead = 0;

                        while (bytesToRead <= 6) // Ensures we read all 6 bytes
                        {
                            int n = fsSource.Read(bytes, 0, 6);
                            bytesToRead += n;

                            if (bytesToRead > 6) //Failsafe ensuring the loop is broken when overstepping 6 bytes
                            {
                                break;
                            }
                            string GameID = System.Text.Encoding.ASCII.GetString(bytes);
                            DialogResult result = MessageBox.Show("Game Loaded!"); // Add future error handling
                            var newline = Environment.NewLine;

                            switch (GameID)
                            {
                                case "GXXE01":
                                    {
                                        string gameTitle = fileInfo.GXXE01;
                                        textBox1.AppendText("GameID: " + GameID +
                                            newline +
                                            "Title: " + gameTitle +
                                            newline +
                                            "File Size: " + fileInfo.FileSize + " bytes");
                                        textBox1.ReadOnly = true;
                                    }
                                    break;

                                case "GXXP01":
                                    {
                                        string gameTitle = fileInfo.GXXP01;
                                        textBox1.AppendText("GameID: " + GameID +
                                            newline +
                                            "Title: " + gameTitle +
                                            newline +
                                            "File Size: " + fileInfo.FileSize + " bytes");
                                        textBox1.ReadOnly = true;
                                    }
                                    break;

                                default:
                                    {
                                        string gameTitle = fileInfo.Unknown;
                                        textBox1.AppendText("GameID: " + GameID +
                                            newline +
                                            "Title:" + gameTitle +
                                            newline +
                                            "File Size: " + fileInfo.FileSize + " bytes");
                                        textBox1.ReadOnly = true;
                                    }
                                    break;

                            } // GameID Check

                            //-- filestream scope



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