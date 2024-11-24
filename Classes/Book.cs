    public class Book
    {
        private string bookName;
        private string author;
        private double salary;
        public string BookName
        { 
            get
            {
                return bookName;
            }
            set
            {
                bookName = value;
            } 
        }
        public string Author 
        {
            get
            {
                return author;
            } 
            set
            {
                author = value;
            }
        }
        public double Salary
        {
            get
            {
                return salary;
            }
            set
            {
                salary = value;
            }
        }
        public Book(string input)
        {
            if(input.Equals("Shaytanat"))
            {
                System.Console.WriteLine($"Kitob nomi: {input}");
                System.Console.WriteLine("Mualifi: Tohir Malik");
                System.Console.WriteLine("Narxi: 100000");
            }
            else
            {
                System.Console.WriteLine("Uzur siz so\'ragan kitob ro\'yxatdan topilmadi!\nIltimos pastagi kitoblardan birini tanglang...");
                ListBooks();
            }
        }

        public void ListBooks()
        {
            System.Console.WriteLine("Hazrati Abu Bakr.");
            System.Console.WriteLine("Vavilonlik eng boy odam.");
            System.Console.WriteLine("Men dunyoni anglayman.");
        }

        

        public void BookInfo(string input)
        {
            switch(input)
            {
                 case "Hazrati Abu Bakir":  
                 System.Console.WriteLine($"Kitob nomi:{input}");
                 System.Console.WriteLine("Mualifi: Abdullayev Mansur");
                 System.Console.WriteLine("Narxi: 120000");
                 break;
                 case "Vavilonlik eng boy odam":
                 System.Console.WriteLine($"Kitob nomi:{input}");
                 System.Console.WriteLine("Mualifi: Toshpulatov Abbos");
                 System.Console.WriteLine("Narxi: 150000");
                 break;
                 case "Men dunyoni anglayman":
                 System.Console.WriteLine($"Kitob nomi:{input}");
                 System.Console.WriteLine("Mualifi: Dosmatov Abdurashid");
                 System.Console.WriteLine("Narxi: 190000");
                 break;
            }
        }    
    }
