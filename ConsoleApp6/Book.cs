namespace ConsoleApp6
{
    class Book
    {
        public Book(string name, string author, int genre1) { 
            Name = name;
            Author = author;
            genre = (Genre)genre1;
        }
        public override string ToString()
        {
            return this.Name + "-" + this.genre + "-" + this.Author;
        }
        public static List<Book> librarybooks = new List<Book>();
        public enum Genre
        {
            science,
            novel,
            history,
            cook
        }

        public static DateTime? BorrowTime { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public Genre genre { get; set; }
    }
}