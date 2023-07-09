using System.IO;

namespace GaleOfDarknessTool.Functions
{
    public class Strip
    {
        public string JSONStrip(string jsonpath)
        // Removes invalid characters for the class of files in the game
        {
            var jsonstring = File.ReadAllText(jsonpath).Replace("/", "").Replace(".", "");
            return jsonstring;
        }
    }
}
