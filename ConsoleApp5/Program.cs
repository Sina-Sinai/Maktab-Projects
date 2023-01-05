using System;

namespace ConsoleApp5
{
    enum mathematic
    {
        Fibonacci = 1,
        factoriel,
        matris
    }

    public class CustomeDate
    {
        DateTime? _mydate;
        public string MyDate
        {
            get => (DateTime.Now - _mydate < TimeSpan.FromDays(7)) ?_mydate.ToString() : null;
            set 
            {
                _mydate = 
                    (DateTime.Now - DateTime.Parse(value) < TimeSpan.FromDays(2) || DateTime.Now - DateTime.Parse(value) > TimeSpan.FromDays(14)  ? DateTime.Parse(value) : null);
            }
        }
        
        
    }

    public class Product
    {
        public double Weight { get; set; }
        public decimal Price { get; set; }

        public static bool operator ==(Product a, Product b) =>
            a.Price == b.Price && a.Weight == b.Weight;
        public static bool operator !=(Product a, Product b) => !(a == b);
        
    }
    public class Utility
    {
        

        public int[] Fibo(int n)
        {
            int[] arr = new int[n];
            int first = 0;
            int second = 1;
            int x = 0;
            Console.Write("0\t1\t");
            for (int i = 2; i < n; i++)
            {
                x = first + second;
                first = second;
                second = x;
                arr[i] = x;
                //arr = arr.Append(x).ToArray();
                Console.Write(arr[i] + "\t");
            }
            Console.WriteLine();
            return arr;
        }

        public int Fact(int n)
        {
            if (n == 1 || n == 0)
            {
                return 1;
            }
            
            return n * Fact(n - 1);
            
            //int i, fact = 1;
            //for (i = 1; i <= n; i++) {
            //    fact *= i;
            //}
            //return fact;
        }

        //public int[] matris(int[] arr1, int[] arr2) {
            
        //}


    }
    internal class cw3
    {
        static void Main(string[] args)
        {
            //q2();
            CustomeDate date1 = new CustomeDate();
            Console.Write("Enter The Date : ");
            date1.MyDate = Console.ReadLine();
            Console.WriteLine(date1.MyDate);
            //string resume;
            //do
            //{
            //    Utility obj = new Utility();
            //    //int[] fib = obj.Fibo(6);
            //    //Console.WriteLine(obj.Fact(Convert.ToInt32(Console.ReadLine())));

            //    Console.Write("Enter the function name : ");
            //    string str = Console.ReadLine();
            //    switch (Enum.Parse(typeof(mathematic), str))
            //    {
            //        case mathematic.Fibonacci:
            //            Console.Write("Enter the number for fibo: ");
            //            obj.Fibo(Convert.ToInt32(Console.ReadLine()));
            //            break;
            //        case mathematic.factoriel:
            //            Console.Write("Enter the number for factorie: ");
            //            Console.WriteLine(obj.Fact(Convert.ToInt32(Console.ReadLine())));
            //            break;
            //            //case mathematic.matris:
            //            //    obj.matris(Convert.ToInt32(Console.ReadLine()));
            //            //    break;
            //    }
            //    Console.Write("Do you want to continue?");
            //    resume = Console.ReadLine();
            //} while (resume == "y");
        }

        public static void q2()
        {
            Console.WriteLine("Enter Two Date: ");
            DateTime date1 = Convert.ToDateTime(Console.ReadLine());
            DateTime date2 = Convert.ToDateTime(Console.ReadLine());
            if (date1 > date2)
            {
                var substract = date1 - date2;
                Console.WriteLine(substract.Ticks);

            }
            else
            {
                var substract = date2 - date1;
                Console.WriteLine(substract.Ticks);

            }
        }
    }
}