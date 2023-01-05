using Bogus;
using Bogus.Extensions.Italy;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;


namespace ConsoleApp6
{
    internal class Authentication : IAuthentication
    {
        public static void Login(string email)
        {
            bool isthere = false;
            Console.Write("Enter your password : ");
            string password = Console.ReadLine();
            foreach (var i in Users.people)
            {
                if (i.Email == email)
                {
                    isthere = true;
                    if (i.Password == password)
                    {
                        Users.CurrentUser = i;

                        Console.WriteLine("Success");
                        Begining.menu(Users.CurrentUser);
                        Begining.menu(i);
                    }
                    else
                    {
                        Console.WriteLine("Wrong passwordd!");
                    }
                }
                
            }
            if (!isthere)
            {
                Console.WriteLine("User not found!");
            }

        }

        public static void Register()
        {
            string? address = null, city = null;
            long? mobile = null;
            //----------------------------------------------
            Console.Write("\nEnter Your Email : ");
            string email = Console.ReadLine();
            foreach (Person i in Users.people)
            {
                if (i != null)
                {
                    if (i.Email == email && i != null)
                    {
                        Console.Write("User already exists, Do you want to login? (y, n)");
                        string ans = Console.ReadLine();
                        switch (ans)
                        {
                            case "y":
                                Login(email);
                                break;
                            case "n":
                                break;
                        }
                    }
                    else { continue; }
                }
            }
            //----------------------------------------------
            Console.Write("\nEnter Your Password : ");
            string password = Console.ReadLine();
            //----------------------------------------------
            Console.Write("Enter Your Name : ");
            string name = Console.ReadLine();
            //----------------------------------------------
            Console.Write("\nEnter Your Family Name : ");
            string family = Console.ReadLine();
            //----------------------------------------------
            Console.Write("Enter your role :");
            int role = Convert.ToInt32(Console.ReadLine());
            //----------------------------------------------
            Console.Write("\nEnter Your Age :");
            int age = Convert.ToInt32(Console.ReadLine());
            //----------------------------------------------
            Console.Write("\nEnter Your Gender (1 as male & 2 as Female) : ");
            int gender = Convert.ToInt32(Console.ReadLine());
            //----------------------------------------------
            Console.Write("Do you want to enter your address and mobile? (y, n) : ");
            string sss = Console.ReadLine();
            //----------------------------------------------
            switch (sss)
            {
                case "y":
                    Console.Write("Enter your address : ");
                    address = Console.ReadLine();
                    Console.Write("Enter your City : ");
                    city = Console.ReadLine();
                    Console.Write("Enter your mobile : ");
                    mobile = Convert.ToInt64(Console.ReadLine());
                    break;
                case "n":
                    break;
            }
            //----------------------------------------------
            Person person = new Person(email, name, family, age, gender, password, role);
            ContactInfo p = new ContactInfo(city, address, mobile);
            person.Contacts.Add(p);
            //------------------------------------------------
            WriteData.WritePerson(@"E:\Programming\C#-PR\PeopleDataBase.json", person);
            //------------------------------------------------
            Users.people.Add(person);
            Begining.menu(person);
        }

    }

}

