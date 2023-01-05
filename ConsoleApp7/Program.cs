namespace ConsoleApp7
{
    internal class Program
    {
        public static void FindExtensions(string path)
        {
            var Files = Directory.GetFiles(path);
            foreach (string file in Files)
            {
                Console.WriteLine(file);
                //Console.WriteLine(Path.GetExtension(file));
            }
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            FindExtensions(@"F:\lnddf");
            FileStream x = new FileStream(@"",FileMode.Create);

        }

        
    }
}