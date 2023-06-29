

namespace Unpack;

// ----------
// Manages the unpacking and repacking of ISO and directory holding
//

public class Unpack(string source)
{
    public void ISOUnpack() // Unpack ISO to program root
    {
        using (FileStream fsUnpack = System.IO.File.Open(source, FileMode.Open))
        {
           

        }
    }
}

public class OpenOnClick : XD_GoD_GUI.Main
{
    public string path; //Public string for iso dir

    public void PopUp()
    {
        OpenFileDialog CurrentFile = new();

        try
        {
            if (CurrentFile.ShowDialog() == DialogResult.OK)
            {
                textBox1.ReadOnly = false;
                textBox1.Clear();

                path = CurrentFile.FileName;
                var fileInfo = new VersionInfo.GameInfo();

                using (FileStream fsSource = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    byte[] bytes = new byte[6];
                    fileInfo.FileSize = new FileInfo(path).Length;
                    int bytesToRead = 0;


                    while (bytesToRead <= 6) // Guarentees 6 bytes read
                    {
                        int n = fsSource.Read(bytes, 0, 6);
                        bytesToRead += n;

                        if (bytesToRead > 6) // Failsafe break
                        {
                            break;
                        }

                    }

                    string GameID = System.Text.Encoding.ASCII.GetString(bytes);
                    DialogResult result = MessageBox.Show("Game Loaded!");

                    switch (GameID)
                    {
                        case "GXXE01":
                            {
                                string gameTitle = fileInfo.GXXE01;
                                textBox1.AppendText("GameID: " + GameID + "\n" +
                                    "Title: " + gameTitle + "\n" +
                                    "File Size: " + fileInfo.FileSize + " bytes");
                                textBox1.ReadOnly = true;
                            }
                            break;

                        case "GXXP01":
                            {
                                string gameTitle = fileInfo.GXXE01;
                                textBox1.AppendText("GameID: " + GameID + "\n" +
                                    "Title: " + gameTitle + "\n" +
                                    "File Size: " + fileInfo.FileSize + " bytes");
                                textBox1.ReadOnly = true;
                            }
                            break;

                        default:
                            {
                                string gameTitle = fileInfo.Unknown;
                                textBox1.AppendText("GameID: " + GameID + "\n" +
                                    "Title: " + gameTitle + "\n" +
                                    "File Size: " + fileInfo.FileSize + " bytes");
                                textBox1.ReadOnly = true;
                            }
                            break;

                    }
                    fsSource.Close();
                    
                }

            }
        }
        catch (IOException) { } // Event handler for failure to open
    }

}