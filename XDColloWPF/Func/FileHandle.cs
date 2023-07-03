// ----------
// Handles some operations for reading the file. A lot of unpacking/repacking and editing is done over in
// filehandling.py
// ----------

using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace FileHandle
{
    public class FileHandling
    {
        public static List<string> FileInfo(string path)
        /// <summary>
        /// Returns an array of ["GameID", "Title", "Size"] from source file
        /// </summary>
        {

            List<string> info = new List<string>(); //might need to cast elements to the array idk yet

            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                byte[] bytes = new byte[6]; // Only first 6 bytes contain version info
                fs.Read(bytes, 0, 6);

                string GameID = System.Text.Encoding.ASCII.GetString(bytes); //GameID var
                switch (GameID)
                {
                    case "GXXE01":
                        {
                            string title = "Pokémon XD: Gale of Darkness (USA)";
                            info.Add(title);
                            info.Add(GameID);
                        }
                        break;

                    case "GXXP01":
                        {
                            string title = "Pokémon XD: Gale of Darkness (EU)";
                            info.Add(title);
                            info.Add(GameID);
                        }
                        break;

                    default:
                        {
                            string title = "Unknown Title (Unknown Region) [Broken/Custom Game?]";
                            info.Add(title);
                            info.Add(GameID);

                        }
                        break;




                }
                return info;

            }
        }

        public static void FileTree(string path) //Dictionary<string, Dictionary<int, int>> (calling void for now for debug)
        ///<summary>
        /// Calls Filehandling.py to retreive the dirtree of the loaded ISO, casting to a C# Dict
        /// Dict is formatted {filename {offset_start:size}
        ///</summary>
        {

        }
    }
}