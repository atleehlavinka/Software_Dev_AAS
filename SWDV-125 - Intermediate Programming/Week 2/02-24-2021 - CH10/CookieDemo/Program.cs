using System;
using static System.Console;
namespace CookieDemo
{
    class Program
    {
        static void Main(string[] ars)
        {
            Cookie Cookie1 = new Cookie(12345, "Fred Meyer", "Chocolate Chip", 2);
            Cookie Cookie2 = new Cookie(23456, "Albertsons", "Peanut Butter", 5);
            Cookie Cookie3 = new Cookie(34567, "Winco", "Oatmeal", 1);

            WriteLine(Cookie1.ToString());
            WriteLine(Cookie2.ToString());
            WriteLine(Cookie3.ToString());
        }
    }
    class Cookie
    {
        public int OrderNum { get; set; }
        public string Store { get; set; }
        public string CookieType { get; set; }
        public int Dozen { get; set; }

        public double price;
        public double Price
        {
            get
            {
                price = 15;
                if (Dozen >= 2)
                    price = price + 15;
                if (Dozen > 2)
                    price = price + ((Dozen - 2) * 13);
                return price;
            }
        }



        public Cookie()
        { }

        public Cookie(int code, string store, string cookieType, int dozen, double price)
        {
            OrderNum = code;
            Store = store;
            CookieType = cookieType;
            Dozen = dozen;
            this.price = price;
        }
        public Cookie(int code, string store, string cookieType, int dozen)
        {
            OrderNum = code;
            Store = store;
            CookieType = cookieType;
            Dozen = dozen;
        }
        public override string ToString()
        {
            return ("\nOrderNum: " + OrderNum + " for " + Store + "\n" + CookieType + "\nHow many dozen: " + Dozen + "\nTotal Price: " + Price.ToString("C"));
        }

    }
}
