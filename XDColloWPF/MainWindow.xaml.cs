using FileHandle;
using Microsoft.Win32;
using System.Collections.Generic;
using System.IO;
using System.Text.Json.Serialization;
using System.Windows;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Linq;

namespace XDColloWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static string fpath;

        public MainWindow()
        {
            // Load the JSON file and parse its contents into a list of objects
            string json = File.ReadAllText(@"C:\Users\penot\OneDrive\Documents\GitHub\XDColloGUIWin\XDColloWPF\XD_GoD_File_Tree.json");
            // Parse the JSON data
            JObject jsonData = JObject.Parse(json);

            // Iterate over each key-value pair

            foreach (KeyValuePair<string, JToken> kvp in jsonData)
            {
                string fileName = kvp.Key;
                JArray fileData = (JArray)kvp.Value;

                int offset = fileData[0].ToObject<int>();
                int size = fileData[1].ToObject<int>();
                System.Diagnostics.Debug.WriteLine(fileName);
                
            }
        }

        public void FileOpen(object sender, RoutedEventArgs e) //Call on file -> open
        {

            OpenFileDialog ofd = new(); //Select file
            try
            {
                if (ofd.ShowDialog() == true)
                {
                    fpath = ofd.FileName;
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

        private void RandomizeButton_Click(object sender, RoutedEventArgs e)
        {
            FileHandle.FileHandling.FileTree(fpath);
        }

        private void ListBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }

        private void DataGrid_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }

        //private void RandomizerElements (object sender, RoutedEventArgs e)
        //{

        //}
    }
}
