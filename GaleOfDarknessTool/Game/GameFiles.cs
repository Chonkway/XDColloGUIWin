using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Windows;

class Filesystem
{
    public Dictionary<string, int[]> SetFiletree(string path) // Generate 

    {

        if (File.Exists(path))
        {
            var currentjson = File.ReadAllText(path);
            var files = JsonConvert.DeserializeObject<Dictionary<string, int[]>>(currentjson);
            return files;

        }
        else
        {
            MessageBox.Show("Unable to locate JSON.\n Ensure the JSON files are present in the JSON folder.");
            return null;
        }

    }
}