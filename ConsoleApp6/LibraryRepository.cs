namespace ConsoleApp6
{
    internal class LibraryRepository : ILibraryRepository
    {
        public static void PrintBook(Book b)
        {
            Console.WriteLine(b);
        }
        public static void AllBorrowed()
        {
            int index = 1;
            foreach (var item in Person.borrowed)
            {
                Console.WriteLine(index + " " + item.Name);
            }
        }
        public static void AddBook()
        {
            Console.Write("Enter the book\'s title : ");
            string title = Console.ReadLine();
            Console.Write("ENter the author : ");
            string author = Console.ReadLine();
            Book.Genre? g = null;
            do
            {
                Console.Write("\n1. Science\n2. Novel\n3. History\n4. Cook\n>>> ");
                string res = Console.ReadLine();
                switch (res)
                {
                    case "1": g = Book.Genre.science; break;
                    case "2": g = Book.Genre.novel; break;
                    case "3": g = Book.Genre.history; break;
                    case "4": g = Book.Genre.cook; break;
                }
            } while (g == null);
            try
            {
                Book b = new Book(title, author, (int)g);
                Book.librarybooks.Add(b);
                WriteData.WriteBook(@"E:\Programming\c#-pr\BookDataBase.json", b);
                Console.WriteLine("Book added successfuly!");
                Log.log($"A book was added.\nName: {b.Name}, Author: {b.Author}, Genre: {b.genre}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong!\nSee log file for more info!");
                Log.log(ex.Message);
            }
            Console.Write("Press any key to continue...");
            Console.ReadKey();
        }
        public static void RemoveBook()
        {
            GetListOfLibraryBooks();
            Console.Write(">>> ");
            int res = Convert.ToInt32(Console.ReadLine());
            try
            {
                Book b = Book.librarybooks[res - 1];
                Log.log($"A book was removed.\nName: {b.Name}, Author: {b.Author}, Genre: {b.genre}");
                Book.librarybooks.RemoveAt(res - 1);
            }catch (Exception ex)
            {
                Console.WriteLine("Something went wrong!\nSee log file for more info!");
                Log.log(ex.Message);
            }
        }
        public static void BorrowBook(Person p)
        {
            char pressed;
            do
            {
                GetListOfLibraryBooks();
                Console.Write("To borrow a book, enter the number of the book : ");
                int n = Convert.ToInt32(Console.ReadLine()); n -= 1;
                try
                {
                    Person.borrowed.Add(Book.librarybooks[n]);
                    Book.BorrowTime = DateTime.Now;
                    Book b = Book.librarybooks[n];
                    Log.log($"A book was borrowed.\nName: {b.Name}, Author: {b.Author}, Genre: {b.genre}, Borrowed at {DateTime.Now}");
                    Book.librarybooks.RemoveAt(n);
                }catch (Exception ex)
                {
                    Console.WriteLine("Something went wrong!\nSee log file for more info!");
                    Log.log(ex.Message);
                }
                Console.Write("\nFor continue enter c, and for menu enter m : ");
                pressed = Console.ReadKey().KeyChar;
            } while (pressed == 'c');
            Console.Clear();
            Begining.menu(p);
        }

        public static void ReturnBook(Person p)
        {
            char pressed;
            do
            {
                GetListOfLibraryBooks();
                Console.Write("To borrow a book, enter the number of the book : ");
                int n = Convert.ToInt32(Console.ReadLine()); n -= 1;
                Book.librarybooks.Add(Person.borrowed[n]);
                Book.BorrowTime = null; 
                Person.borrowed.RemoveAt(n);
                Console.Write("\nFor continue enter c, and for menu enter m : ");
                pressed = Console.ReadKey().KeyChar;
            } while (pressed == 'c');
            Console.Clear();
            Begining.menu(p);

        }

        public static string GetListOfLibraryBooks()
        {
            Console.Write("** Library Books **\n1. Science\n2. Novel\n3. History\n4. Cook\n>>");
            string choice = Console.ReadLine();
            int index = 1;
            string x = "";
            switch (choice)
            {
                case "1": 
                    foreach (var item in Book.librarybooks)
                    {
                        if (item.genre == Book.Genre.science)
                        {
                            x += (index + ". " + item.Name + "\n"); 
                        }
                        index++;
                    }
                    break;
                case "2":
                    foreach (var item in Book.librarybooks)
                    {
                        if (item.genre == Book.Genre.novel)
                        {
                            x += (index + ". " + item.Name + "\n");
                        }
                        index++;
                    }
                    break;
                case "3":
                    foreach (var item in Book.librarybooks)
                    {
                        if (item.genre == Book.Genre.history)
                        {
                            x += (index + ". " + item.Name + "\n");
                        }
                        index++;
                    }
                    break;
                case "4":
                    foreach (var item in Book.librarybooks)
                    {
                        if (item.genre == Book.Genre.cook)
                        {
                            x += (index + ". " + item.Name + "\n");
                        }
                        index++;
                    }
                    break;
            }
            return x;
        }
        public static void GetListOfUserBooks(Person p)
        {
            Console.Clear();
            int j = 1;
            Console.WriteLine("* Borrowed Books *");
            foreach (var i in Person.borrowed)
            {
                Console.WriteLine((j++) + $". {i.Name}");
            }
            Console.Write("\nreturn to main menu press any key");
            Console.ReadKey();
            Console.Clear();
            Begining.menu(p);
        }

    }
}
