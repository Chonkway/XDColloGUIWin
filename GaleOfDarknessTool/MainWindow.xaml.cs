using GaleOfDarknessTool.Functions;
using System.Diagnostics;
using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace GaleOfDarknessTool
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

        public void Openfile_Click(object sender, RoutedEventArgs e)
        {
            Logging log_entry = new Logging();
            string working_directory = Directory.GetCurrentDirectory();
            var tree = new Filesystem();

            var newpath = Path.Combine(working_directory + @"\JSON\XD_GoD_File_Tree.json");
            tree.SetFiletree(newpath);

        }

        private void Filetree_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

    }
}
