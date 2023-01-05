namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public class People
    {
        public int PersonalId { get; }
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class Student : People, IStudent
    {
        public int StudentId { get; }

        public int IStudentId { get; }
    }

    public interface IStudent {
        public int IStudentId { get; }

    }
}