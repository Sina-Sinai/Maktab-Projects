namespace CW1
{
    public class cw_firiday
    {
        public static void Main()
        {
            //q1();
            //q2();
            //q3();
            q4();
        }

        private static void q1()
        {
            Console.WriteLine("ENter The Radios : ");
            int r = Convert.ToInt32(Console.ReadLine());
            const double PI = 3.14;
            double S = PI * r * r;
            double p = 2 * PI * r;
            Console.WriteLine($"The area of circle is : {p}\nThe ... of circle is {S}");
        }
        public static void q2() {
            int hour, minute, second;
            Console.WriteLine("Enter The Numbers : ");
            hour = Convert.ToInt32(Console.ReadLine());
            minute = Convert.ToInt32(Console.ReadLine());
            second = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((hour * 3600) + (minute * 60) + second);
        }
        public static void q3() {
            Console.Write("Enter Income : ");
            double income = Convert.ToInt32(Console.ReadLine());
            income -= income * 0.1;
            income -= income * 0.06;
            Console.WriteLine(income);

        }
        public static void q4() {
            string phrase = Console.ReadLine();
            try
            {
                int a = Convert.ToInt32(phrase);
                Console.WriteLine("True\n" + a);
            }
            catch
            {
                Console.WriteLine("False\n0");

            }

        }
        public static void q5() {
            
        }
        public static void q6() {; }

    }
}