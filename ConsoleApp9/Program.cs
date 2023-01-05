using System.Text.Json.Serialization;

namespace ConsoleApp9
{
    internal class Program
    {
        static void findwordinfile(string path, string userword) {
            string[] Files = Directory.GetFiles(path);
            foreach (string file in Files)
            {
                var fileinfo = new FileInfo(file);
                string[] text = File.ReadAllLines(fileinfo.FullName);
                foreach (var line in text)
                {
                    if (line.Contains(userword))
                    {
                        Console.WriteLine(fileinfo.FullName + " -> has your word at line : " + line) ;
                    }
                }

            }
        }

        static void renamefilecorrectly(string path) {
            string[] Files = Directory.GetFiles(path);
            foreach (string file in Files)
            {
                var fileInfo = new FileInfo(file);
                string newname = fileInfo.Name.Replace('s', 'a');
                newname = newname.Replace('n', 'M');
                string secPath = fileInfo.FullName.Replace(fileInfo.Name, newname);
                fileInfo.Delete();
                File.Create(secPath);
            }
        }

        static void log(string path, int num1, int num2) {
            string LogFilePath = @"E:\Programming\c#-ex\func-log.txt";
            //if (!File.Exists(LogFilePath))
            //{
            //    var logfile = File.Create(LogFilePath);
            //    logfile.Close();
            //}
            try
            {
                Console.WriteLine(num1 / num2);
                File.Delete(path);
                string[] line = {$"---- Start of message ----\nthe {num1} was devided by {num2} and result were {num1 / num2}\n And the file at " +
                    $"{path} was deleted\n---- End of message ----\n" };
                File.AppendAllLines(LogFilePath, line);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                string[] line = {"---- Start of message ----\nan error has occured and the message is shown below : " +
                    $"\n{ex.Message}\n---- End of message ----\n" };
                File.AppendAllLines(LogFilePath, line);
            }
        }

        static void Main(string[] args)
        {
            //findwordinfile("E:\\Programming\\c#-ex\\f-1", "amet");
            //renamefilecorrectly("E:\\Programming\\c#-ex\\f-2");
            log(@"E:\Programming\c#-ex\f-17\t-1-888.txt", 10, 2);
        }
    }
}