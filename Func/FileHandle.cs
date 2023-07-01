// ----------
// Handles the operations of pathing the ISO, unpacking it and repacking it
// ----------

using Microsoft.Win32;
using System.IO;
using System;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;

namespace FileHandle
{
    public class FileHandling
    {
        public static List<string> FileInfo(string path) //Returns an array of ["GameID", "Title", "Size"] from source file
        {

            List<string> info = new List<string>(); //might need to cast elements to the array idk yet

            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                byte[] bytes = new byte[6]; // Only first 6 bytes contain version info
                int bytes_to_read = 0;


                while(bytes_to_read <= 6) {

                    int n = fs.Read(bytes, 0, 6);
                    bytes_to_read+= n;
                }

                string GameID = System.Text.Encoding.ASCII.GetString(bytes); //GameID var

                switch (GameID)
                {
                    case "GXXE01":
                        {
                            string title = "Pokémon XD: Gale of Darkness (USA)";
                            info.Add(title);
                            info.Add("GXXE01");
                        }
                        break;

                    case "GXXP01":
                        {
                            string title = "Pokémon XD: Gale of Darkness (EU)";
                            info.Add(title);
                            info.Add("GXXP01");
                        }
                        break;

                    default:
                        {
                            string title = "Unknown Title (Unknown Region) [Broken/Custom Game?]";
                            info.Add(title);
                            info.Add("[??????]");

                        }
                        break;

                } return info;
            }
        }
    }
}