using System;
using static System.Console;
using static System.Array;
namespace CookieDemoArray
{
    class Program
    {
        static void Main(string[] ars)
        {
            Cookie[] cookieArray = new Cookie[3];
            int x = 0;

            while (x < cookieArray.Length)
            {
                cookieArray[x] = new Cookie();
                Write("Please enter order number >> ");
                cookieArray[x].OrderNum = Convert.ToInt32(ReadLine());
                Write("Please enter store name for order {0} >> ", cookieArray[x].OrderNum);
                cookieArray[x].Store = ReadLine();
                Write("Please enter flavor of cookie >> ");
                cookieArray[x].CookieType = ReadLine();
                Write("How many dozen {0} cookies are being ordered {1} >> ", cookieArray[x].CookieType, cookieArray[x].OrderNum);
                cookieArray[x].Dozen = Convert.ToInt32(ReadLine());
                WriteLine();
                ++x;
            }

            for (x = 0; x < cookieArray.Length; ++x)
                WriteLine(cookieArray[x].ToString());
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
