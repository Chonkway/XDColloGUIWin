using Microsoft.Win32;
using System;
using System.Collections;
using System.IO;
using System.Windows.Documents;

namespace GaleOfDarknessTool.Functions
{
    public class Load
    {
        public string GetISO()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == true)
            {
                return ofd.FileName;
            }

            else
            {
                return null;
            }
        }

        // Call to assign an instance of LoadedGame the code and game name
        public void GameInfo(string path, LoadedGame game)
        {
            using (FileStream stream = new(path, FileMode.Open, FileAccess.Read))
            {
                byte[] bytes = new byte[6];
                int bytesToRead = 0;

                stream.Seek(0x0, SeekOrigin.Begin);

                while (bytesToRead < 6) // Ensures we read all 6 bytes
                {

                    int bytesRead = stream.Read(bytes, bytesToRead, 6 - bytesToRead);

                    bytesToRead += bytesRead;
                }

                game.GameID = System.Text.Encoding.ASCII.GetString(bytes);

                switch (game.GameID)
                {
                    case "GXXE01":
                        game.GameName = "Pokemon: Gale of Darkness (USA)";
                        game.GameLogo = string.Empty;

                        break;


                    case "GXXP01":
                        game.GameName = "Pokemon: Gale of Darkness (EU)";

                        break;

                    default:

                        game.GameID = game.GameID;
                        game.GameName = game.GameName;
                        break;
                }



            }

        }


        public byte[] ArrayTest(string path, int blocksize)
        {

            using (FileStream stream = new(path, FileMode.Open, FileAccess.Read))
            {
                byte[] bytes = new byte[blocksize];
                int bytesToRead = 0;
                ushort valueToInsert = 0x567;

                stream.Seek(0x32A976C, SeekOrigin.Begin);

                while (bytesToRead < blocksize)
                {
                    for (int i = 31; i < bytes.Length; i += 32)
                    {
                        bytes[i] = (byte)valueToInsert;
                        bytes[i + 1] = (byte)(valueToInsert >> 8);
                    }

                }
                return bytes;

            } 
        }
    }
}

