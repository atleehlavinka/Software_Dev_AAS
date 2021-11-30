using System;
using static System.Console;
namespace LectureBookDemo
{
    class Program
    {
        static void Main(string[] ars)
        {
            Book Novel = new Book("48577-XC", "Moby Dick", "Herman Melville", 15);
            TextBook History = new TextBook("567756-00", "This is History", "James Washington", 125, 5);
            CoffeeTableBook Airplanes = new CoffeeTableBook("33190-CC", "Boeing", "Betty Gravison", 35);

            WriteLine(Novel.ToString());
            WriteLine(History.ToString());
            WriteLine(Airplanes.ToString());
        }
    }
    class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public double price;
        public virtual double Price
        {
            set
            {
                price = value;
            }
            get
            {
                return price;
            }
        }
        
        
        
        public Book()
        { }
        
        public Book(string code, string title, string author, double price)
        {
            ISBN = code;
            Title = title;
            Author = author;
            this.price = price;
        }
        public override string ToString()
        {
            return ("\nISBN: " + ISBN + "\nBook Title: " + Title + "\nAuthor: " + Author + "\nPrice: " + Price.ToString("C"));
        }

    }
    class TextBook : Book
    {
        public int Grade { get; set; }
        public override double Price
        {
            get
            {
                if (base.Price <= 20)
                    this.price = base.Price + 10;
                if (base.Price >= 80)
                    this.price = base.Price + 20;
                return price;
            }
        }
        public TextBook(string code, string title, string author, double price, int grade) : base(code, title, author, price)
        {
            Grade = grade;
        }
        public override string ToString()
        {
            return (base.ToString() + "\nThis book intended for Grade: " + Grade);
        }

    }
    class CoffeeTableBook : Book
    {
        public override double Price
        {
            get
            {
                if (base.Price <= 35)
                    this.price = base.Price = 5;
                if (base.Price >= 100)
                    this.price = base.Price = 10;
                return price;
            }
        }
        public CoffeeTableBook(string code, string title, string author, double price) : base(code, title, author, price)
        {
        }
    }
}