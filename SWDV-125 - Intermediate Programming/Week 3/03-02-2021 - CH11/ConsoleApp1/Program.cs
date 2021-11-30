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
                try
                {
                    cookieArray[x] = new Cookie();
                    cookieArray[x].setOrderNum();
                    cookieArray[x].setStore();
                    cookieArray[x].setCookieType();
                    cookieArray[x].setDozen();
                    WriteLine(cookieArray[x].ToString());
                    ++x;
                }
                catch (FormatException e)
                {
                    WriteLine(e.Message);
                    WriteLine("\t** The order number or dozen ordered was not a numeric value **");
                    WriteLine("\tYou will have to re-enter the order.\n");
                }
            }
        }
    }
    class Cookie
    {
        public int OrderNum { get; set; }
        public string Store { get; set; }
        public string CookieType { get; set; }
        public int Dozen { get; set; }

        public void setOrderNum()
        {
            try
            {
                Write("Enter order number: ");
                OrderNum = Convert.ToInt32(ReadLine());
            }
            catch (FormatException f)
            {
                throw (f);
            }
        }

        public void setStore()
        {
            try
            {
                Write("Enter the store to fultill the order: ");
                Store = ReadLine();
            }
            catch (FormatException f)
            {
                throw (f);
            }
        }
        public void setCookieType()
        {
            try
            {
                Write("What type of cookie is being ordered: ");
                CookieType = ReadLine();
            }
            catch (FormatException f)
            {
                throw (f);
            }
        }
        public void setDozen()
        {
            try
            {
                Write("How many dozen? ");
                Dozen = Convert.ToInt32(ReadLine());
            }
            catch (FormatException f)
            {
                throw (f);
            }
        }

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
            return ("\nOrderNum: " + OrderNum + " for " + Store + "\n" + CookieType + "\nHow many dozen: " + Dozen + "\nTotal Price: " + Price.ToString("C") + "\n");
        }

    }
}
