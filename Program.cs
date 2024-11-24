namespace Task8Book
{
    class Program
    {
        static void Main()
        {
            System.Console.Write("Kitob nomini kiriting:");
            string? input = Console.ReadLine();
            Book book = new Book(input);
            string? input2 = Console.ReadLine();
            book.BookInfo(input2);
        }
    }
}