using GaleOfDarknessTool.Functions;
using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

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

        [STAThread]
        public void Openfile_Click(object sender, RoutedEventArgs e)
        {
            // Initialize classes
            // severe cleanup needed
            //-------------
            Logging log_entry = new();
            string working_directory = Directory.GetCurrentDirectory();
            Load loadiso = new();
            LoadedGame game = new LoadedGame();
            var iso = loadiso.GetISO();

            LoadedFileInfo.Text = "GameID: " + game.GameID + "\n" + "Game Name: " + game.GameName;
            //------------------

            var test = loadiso.ArrayTest(iso, 32);
            Debug.WriteLine(test.ToString());
            // external class for ofd return path to file
            // external class for reading bytes, identifying game and displaying image/details
            //external class for extracting the games needed files (common.rel, trainerdeckdata etc.) 

        }

        private void Filetree_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

    }
}
