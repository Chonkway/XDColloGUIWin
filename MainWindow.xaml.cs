using System.IO;
using System.Windows;
using FileHandle;
using Microsoft.Win32;

namespace XDColloWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void FileOpen(object sender, RoutedEventArgs e) //Call on file -> open
        {

            OpenFileDialog ofd = new(); //Select file
            try
            {
                if (ofd.ShowDialog() == true)
                {
                    string fpath = ofd.FileName;
                    var finfo = FileHandle.FileHandling.FileInfo(fpath);

                    FileInfo.Text = ("Editing: " + fpath + "\n" + 
                        "GameID: " + finfo[1] + "\n" +

                       "Title: " + finfo[0]);
                }
            }

            catch (IOException) { }
        }
    }
}
