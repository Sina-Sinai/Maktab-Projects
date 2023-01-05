using System;


namespace HW2
{
    public class hw2
    {
        public static void Main()
        {
            q6();
        }

        public static void q1()
        {
            int number = Convert.ToInt32(Console.ReadLine());
            int counter = 0;
            for(int i = 2; i < number; i++)
            {
                for(int j = 1; j <=i; j++)
                {
                    if (i % j == 0)
                    {
                        counter++;
                    }
                }
                if (counter == 2)
                {
                    Console.WriteLine(i);
                }
                counter = 0;
            }
            
        }

        public static void q2()
        {
            string str = Console.ReadLine();
            int n = Convert.ToInt32(Console.ReadLine());
            while (1==1)
            {
                if (str.Length >= n)
                {
                    Console.WriteLine(str.Substring(0, n));
                    str = str.Substring(n);
                }
                else
                {
                    foreach(var i in str)
                    {
                        Console.WriteLine(i);
                    }
                    break;
                }
            }
        }

        public static void q3()
        {
            string str = Console.ReadLine();
            str = str.ToLower();
            str = (str.Substring(0, 1).ToUpper()) + (str.Substring(1));
            for (int i = 1; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    str = str.Substring(0, i)+ " " + Convert.ToString(str[i+1]).ToUpper() + str.Substring(i+2);
                }
            }
            Console.WriteLine(str);
        }

        public static void q4()
        {
            int rounds = 0;
            bool x = false;
            int number = Convert.ToInt32(Console.ReadLine());
            while (number != 1)
            {
                if (rounds > 6)
                {
                    Console.WriteLine("unexepted result");
                    x = true;
                    break;
                }
                else
                {
                    if (number % 2 == 0)
                    {
                        number /= 2;
                        rounds++;
                    }
                    else
                    {
                        number = 3 * number + 1;
                        rounds++;
                    }
                }
            }
            if (!x)
            {
                Console.WriteLine(rounds);
            }
            
        }

        public static void q5() {
            int cost = Convert.ToInt32(Console.ReadLine());
            int fifty=0, ten=0, five = 0, one = 0;
            while(cost >= 50)
            {
                cost -= 50;
                fifty++;
            }
            while (cost >= 10)
            {
                cost -= 10;
                ten++;
            } 
            while (cost >= 5)
            {
                cost -= 5;
                five++;
            }
            while (cost >= 1)
            {
                cost -= 1;
                one++;
            }
            Console.WriteLine($"fifty : {fifty}\nten : {ten}\nfive : {five}\none : {one}");
        }
        public static void q6()
        {
            
        }
        public static void q7()
        {
            string before, after, str = Console.ReadLine();
            bool start = false;
            for(int i = 0; i < str.Length; i++)
            {
                if (int.TryParse(str[i].ToString(), out int j) && start)
                {
                    before = str.Substring(0, i);
                    start = true;
                }else if(!int.TryParse(str[i].ToString(), out int j) && start)
                {
                    after = str.Substring(i);
                }
            }

        }
    }
}
               