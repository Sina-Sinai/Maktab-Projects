using System.Text;
using System.Threading;

namespace ConsoleApp8
{
    internal class Program
    {

        static void BackUpFile(string path)
        {
            Directory.CreateDirectory(Path.Combine(path,"BackUp"));
            var Files = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);
            foreach (var file in Files)
            {
                
                var fileinfo = new FileInfo(file);
                if (fileinfo.Name.StartsWith("BackUp"))
                {
                    continue;
                }
                var backupfilestream = new FileStream(fileinfo.FullName, FileMode.Open);
                var newfile = new FileStream(path + @"\BackUp\BackUp_" + fileinfo.Name,FileMode.Create,FileAccess.ReadWrite);
                byte[] buf = new byte[fileinfo.Length];
                int c;
                while ((c = backupfilestream.Read(buf, 0, buf.Length)) > 0)
                {
                    newfile.Write(buf[..c]); 
                }
                //newfile.Flush();
                newfile.Close();
                backupfilestream.Close();

            }
        }

        static void BackUpFilewithFile(string path)
        {
            Directory.CreateDirectory(Path.Combine(path, "BackUp"));
            var Files = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);
            foreach (var file in Files)
            {

                var fileinfo = new FileInfo(file);
                if (fileinfo.Name.StartsWith("BackUp"))
                {
                    continue;
                }
                var backupfile = File.Open(fileinfo.FullName, FileMode.Open);
                var newfile = File.Create(Path.Combine(path, $@"BackUp\BackUp_{fileinfo.Name}"));
                byte[] buf = new byte[fileinfo.Length];
                int c;
                //while ((c = backupfile.Read(buf, 0, buf.Length)) > 0)
                //{
                //    newfile.Write(buf[..c]);
                //}
                newfile.Write(buf, 0, buf.Length);
                newfile.Close();
                backupfile.Close();
            }
        }

        static void FileSizeFinder(string path)
        {
            string scvpath = @"E:\Programming\c#-ex\filesize.csv";
            var scvfile = File.Create(scvpath);
            scvfile.Close();
            var Files = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);
            long totalsize = 0;
            foreach (var file in Files)
            {
                var fileinfo = new FileInfo(file);
                //scvfile.Write();
                File.AppendAllText(scvpath, $"{Convert.ToString(fileinfo.Length)},{fileinfo.Name}\n");
                totalsize += fileinfo.Length;
            }
            File.AppendAllText(scvpath, $"{totalsize},{scvpath}");
        }

        static void TxtFileFounder(string path)
        {
            var Files = Directory.GetFiles(path, "*.txt", SearchOption.AllDirectories);
            string destpath = path + @"\TxtFiles\";
            foreach (var i in Files)
            {
                var finfo = new FileInfo(i);
                if (!File.Exists(destpath))
                {
                    Directory.CreateDirectory(destpath);
                    File.Copy(i, $@"{destpath}\{finfo.Name}");
                }
                else
                {
                    File.Copy(i, $@"{destpath}\{finfo.Name}");
                }
            }
        }

        static string FindLine(string filepath1, string filepath2)
        {
            var File1Lines = File.ReadAllLines(filepath1);
            var File2Lines = File.ReadAllLines(filepath2);
            foreach (var line1 in File1Lines)
            {
                foreach (var line2 in File2Lines)
                {
                    if (line1 == line2)
                    {
                        return line1;
                    }
                }
            }
            return "No Match!";
        }

        static void deletefile(string path)
        {
            try
            {
                File.Delete(path);
                Console.WriteLine("File deleted successfuly!");
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\nTry again ->");
                deletefile(Console.ReadLine());
            }
            //}catch (FileNotFoundException)
            //{
            //    Console.WriteLine("File not found! try again. ->");
            //    deletefile(Console.ReadLine());
            //}catch (IOException)
            //{
            //    Console.WriteLine("There is an I/O erorr! try again. ->");
            //    deletefile(Console.ReadLine());
            //}
        }

        static void Main(string[] args)
        {
            //TxtFileFounder(Console.ReadLine());
            //Console.WriteLine(FindLine(@"E:\Programming\c#-ex\TxtFiles\t-1-1.txt", @"E:\Programming\c#-ex\TxtFiles\txt-f-1-1.txt"));
            //deletefile(Console.ReadLine());
            //FileSizeFinder(Console.ReadLine());
            //BackUpFile(Console.ReadLine());
            BackUpFilewithFile(Console.ReadLine());
        }
    }
}