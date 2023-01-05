using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Begining : IBegining
    {
        public static void start()
        {
            ReadData.ReadPerson(@"E:\Programming\C#-PR\PeopleDataBase.json");
            Console.Write("Login or Register? : ");
            string f = Console.ReadLine();
            if (f == "Login")
            {
                Console.Write("\nEnter Your Email : ");
                string email = Console.ReadLine();
                Authentication.Login(email);
            }
            else if (f == "Register")
            {
                Authentication.Register();
            }
        }
        public static void menu(Person p)
        {
            if ((int)p.Rolee == 0)//member
            {
                while (true)
                {
                    Console.Clear();
                    Console.Write("* USER MENU *\n1. Borrow a book\n2. Return a book\n3. Borrowed books\n4. Exit from account\n>>> ");
                    int res = Convert.ToInt32(Console.ReadLine());
                    switch (res)
                    {
                        case 1:
                            Console.Clear();
                            LibraryRepository.BorrowBook(p);
                            break;
                        case 2:
                            Console.Clear();
                            LibraryRepository.ReturnBook(p);
                            break;
                        case 3:
                            Console.Clear();
                            LibraryRepository.GetListOfUserBooks(p);
                            break;
                        case 4:
                            Users.CurrentUser = null;
                            Console.Clear();
                            start();
                            break;
                    }
                }
            }
            else if ((int)p.Rolee == 1)//manager
            {
                Console.Clear();
                Console.Write("** Manager Menu **\n1. Add Book\n2. Remove Book\n3. All Library Books\n4. All Borrowed Books\n5. Logout\n>>> ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.Clear();
                        LibraryRepository.AddBook();
                        menu(p);
                        break;
                    case "2":
                        Console.Clear();
                        LibraryRepository.RemoveBook();
                        menu(p);
                        break;
                    case "3":
                        Console.Clear();
                        string X = LibraryRepository.GetListOfLibraryBooks();
                        if (X != "") {
                            Console.WriteLine(">>> ");
                            string num = Console.ReadLine();
                            LibraryRepository.PrintBook(Book.librarybooks[int.Parse(num)]);
                            Console.WriteLine("To get back to menu, press m");
                            char c = Console.ReadKey().KeyChar;
                            if (c == 'm')
                            {
                                Console.Clear();
                                menu(p); break;
                            }
                            break;
                        }
                        else
                        {
                            Console.WriteLine("No books in here!");
                            Console.ReadKey();
                            menu(p);
                            break;
                        }
                        
                    case "4":
                        Console.Clear();
                        LibraryRepository.AllBorrowed();
                        menu(p);
                        break;
                    case "5":
                        Console.Clear();
                        start();
                        break;

                }

            }

        }
    }

}

