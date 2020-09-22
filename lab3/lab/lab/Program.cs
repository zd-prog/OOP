using System;

namespace lab
{
    class Train
    {
        private string destination
        {
            get
            {
                return destination;
            }
            set
            {
                destination = value;
            }
        }
        private int number
        {
            get
            {
                return number;
            }
            set
            {
                number = value;
            }
        }
        private string time
        {
            get
            {
                return time;
            }
            set
            {
                time = value;
            }
        }
        private const int amount = 100;
        private int amount_kupe
        {
            get
            {
                return amount_kupe;
            }
            set
            {
                amount_kupe = value;
            }
        }
        private int amount_plackart
        {
            get
            {
                return amount_plackart;
            }
            set
            {
                amount_plackart = value;
            }
        }
        private int amount_lux
        {
            get
            {
                return amount_lux;
            }
            set
            {
                amount_lux = value;
            }
        }
        private readonly int ID;
        Train()
        {

        }
        public Train()
        {
            destination = "";
            number = 100000;
            time = "";
            amount_kupe = 0;
            amount_plackart = 0;
            amount_lux = 0;
        }
        public Train(string a, int b, string c, int e, int f, int g)
        {
            destination = a;
            number = b;
            time = c;
            amount_kupe = e;
            amount_plackart = f;
            amount_lux = g;
        }
        public Train(string a = "", int b = 10000, string c = "", int e = 0, int f = 0, int g = 0)
        {
            destination = a;
            number = b;
            time = c;
            amount_kupe = e;
            amount_plackart = f;
            amount_lux = g;
        }
        static Train()
        {
            Console.WriteLine("Добавлен новый поезд");
        }
        public static int AmountOut()
        {
            return amount;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Train tr = new Train();
        }
    }
}
