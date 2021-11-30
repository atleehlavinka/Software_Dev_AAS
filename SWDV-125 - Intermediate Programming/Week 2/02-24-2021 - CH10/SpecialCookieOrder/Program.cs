using System;
using static System.Console;
namespace SpecialCookieOrder
{
    class Program
    {
        static void Main(string[] ars)
        {
            Cookie Cookie1 = new Cookie(12345, "Fred Meyer", "Chocolate Chip", 2);
            Cookie Cookie2 = new Cookie(23456, "Albertsons", "Peanut Butter", 5);
            Cookie Cookie3 = new Cookie(34567, "Winco", "Oatmeal", 1);
            SpecialCookieOrder SnickerDoodle = new SpecialCookieOrder(45678, "Whole Foods", "SnickerDoodle", 3, "Gluten-Free");
            SpecialCookieOrder IcedSugar = new SpecialCookieOrder(56789, "Sweet Valley Cookie Company", "Sugar", 1, "Iced");

            WriteLine(Cookie1.ToString());
            WriteLine(Cookie2.ToString());
            WriteLine(Cookie3.ToString());
            WriteLine(SnickerDoodle.ToString());
            WriteLine(IcedSugar.ToString());
        }
    }
    class Cookie
    {
        public int OrderNum { get; set; }
        public string Store { get; set; }
        public string CookieType { get; set; }
        public int Dozen { get; set; }

        public double price;
        public virtual double Price
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

        public Cookie(int order, string store, string cookieType, int dozen, double price)
        {
            OrderNum = order;
            Store = store;
            CookieType = cookieType;
            Dozen = dozen;
            this.price = price;
        }
        public Cookie(int order, string store, string cookieType, int dozen)
        {
            OrderNum = order;
            Store = store;
            CookieType = cookieType;
            Dozen = dozen;
        }
        public override string ToString()
        {
            return ("\nOrderNum: " + OrderNum + " for " + Store + "\n" + CookieType + "\nHow many dozen: " + Dozen + "\nTotal Price: " + Price.ToString("C"));
        }

    }
    class SpecialCookieOrder : Cookie
    {
        public string Special { get; set; }
        public override double Price
        {
            get
            {
                if (base.Price <= 40)
                    this.price = base.price + 10;
                else
                    this.price = base.price + 8;
                return price;
            }
        }
        public SpecialCookieOrder(int order, string store, string cookieType, int dozen, string special) : base(order, store, cookieType, dozen)
        {
            Special = special;
        }
        public override string ToString()
        {
            return (base.ToString() + "\nSpecial Order: " + Special);
        }

    }
}