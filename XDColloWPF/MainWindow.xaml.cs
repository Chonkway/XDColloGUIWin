using System.IO;
using System.Windows;
using System.Windows.Controls;
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
                    var finfo = FileHandling.FileInfo(ofd.FileName); // Info

                    FileInfo.Text = ("Editing: " + fpath + "\n" + 
                        "GameID: " + finfo[1] + "\n" +

                       "Title: " + finfo[0]);
                }
            }

            catch (IOException) { }
        }


        private void AdditionalFeatures_IsEnabledChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        //private void RandomizerElements (object sender, RoutedEventArgs e)
        //{

        //}
    }
}
