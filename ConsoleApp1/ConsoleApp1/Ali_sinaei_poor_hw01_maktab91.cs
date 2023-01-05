//q1();
//q2();
//q3();
//q4();
//q5();
//q6();
q7();

static void q1() {
    int a, b, c, sum;
    Console.WriteLine("enter the number : ");
    int num = Convert.ToInt32(Console.ReadLine());
    a = num % 10;
    b = ((num % 100) - a)/10;
    c = num / 100;
    sum = a + b + c;
    Console.WriteLine("Sum of numbers is :"+sum);
}

static void q2()
{
    Console.Write("Enter The Temperature: ");
    double temperature = Convert.ToInt32(Console.ReadLine());
    double faranhite = (1.8 * temperature) + 32;
    Console.WriteLine(faranhite.ToString());
}

static void q3()
{
    double num1, num2,ave;
    Console.WriteLine("Enter number 1 and number 2: ");
    num1 = Convert.ToSingle(Console.ReadLine());
    num2 = Convert.ToSingle(Console.ReadLine());
    ave = (num1 + num2) / 2.00;
    Console.WriteLine(String.Format("{0:0.00}", ave));

}

static void q4()
{
    string date, day, month, year;
    Console.WriteLine("Enter the number: ");
    date = Console.ReadLine();
    day = date[6..];
    month = date.Substring(4, 2);
    year = date[..4];
    Console.WriteLine(day + "\n" + month + "\n" + year);

}

static void q5()
{
    string a, n1, n2, n3, n4, res;
    Console.Write("Enter The Number : ");
    a = Console.ReadLine();
    n1 = a.Substring(0, 1);
    n2 = a.Substring(1, 1);
    n3 = a.Substring(2, 1);
    n4 = a.Substring(3,1);
    res = n4 + n3 + n2 + n1;
    Console.WriteLine(res);
}

static void q6()
{
    string a;
    a = Console.ReadLine();
    long b = 0;
    try
    {
        b = long.Parse(a);
        Console.WriteLine("True\n" + b);
    }
    catch {
        Console.WriteLine("False\n0");

    }
}

static void q7()
{
    int nums; 
    double power = 4, res = 0;
    for(int i = 1; i<= 5; i++)
    {
        nums = Convert.ToInt32(Console.ReadLine());
        res += nums * (Math.Pow(2, power));
        power--;
    }
    Console.WriteLine(res);
}