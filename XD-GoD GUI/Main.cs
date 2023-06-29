using System;
using System.IO;
using System.Text;
using System.Xml;
using VersionInfo;

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

        public void OpenFile_Click(object sender, EventArgs e) {
            //---------
            // Pulls GameID and conditionally matches title, also displays file size and other 

            Unpack.OpenOnClick openOnClick = new Unpack.OpenOnClick();

        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
