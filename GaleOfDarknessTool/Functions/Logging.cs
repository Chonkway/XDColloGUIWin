using System;
using System.IO;

namespace GaleOfDarknessTool.Functions
{
    internal class Logging
    {
        //Logger for any mishaps

        public void LogWriter(string log_entry)
        {
            var log_directory = Path.Combine(Directory.GetCurrentDirectory() + @"\Logs");
            var file_name = ("Log: {0} at {1}.txt", DateTime.Now.ToLongDateString(), DateTime.Now.ToLongTimeString());


            if (Directory.Exists(log_directory))
            {
                try
                {
                    using (StreamWriter sw = File.CreateText(Path.Combine(log_directory + @"\" + file_name)))
                    {

                        sw.Write(log_entry);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Unable to generate logfile");
                }


            }
            else
            {
                Directory.CreateDirectory(log_directory);
                using (StreamWriter sw = File.CreateText(Path.Combine(log_directory + "\\" + file_name)))
                {
                    sw.Write(log_entry);
                }
            }
        }
    }
}


