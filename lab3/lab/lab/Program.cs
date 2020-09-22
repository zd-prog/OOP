using System;

namespace lab
{
    public class Train
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
        public int number
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
        static int kolichestvo;
        /*
         Train()
        {

        }
        */
        public Train()
        {
            destination = "";
            number = 100000;
            time = "";
            amount_kupe = 0;
            amount_plackart = 0;
            amount_lux = 0;
            kolichestvo++;
        }
        public Train(string a, int b, string c, int e, int f, int g)
        {
            destination = a;
            number = b;
            time = c;
            amount_kupe = e;
            amount_plackart = f;
            amount_lux = g;
            kolichestvo++;
        }
        public Train(string a = "", int b = 10000, string c = "", int e = 0, int f = 0)
        {
            destination = a;
            number = b;
            time = c;
            amount_kupe = e;
            amount_plackart = f;
            kolichestvo++;
        }
        static Train()
        {
            Console.WriteLine("Добавлен новый поезд");
            kolichestvo++;
        }
        public static int AmountOut(ref int amount, out int Output)
        {
            return Output = amount;
        }
        static string info = "Класс, для представления информации о поездах и их маршрутах";
        public static string GetInfo()
        {
            return info;
        }
        /*
         public partial class Train
        { 

        }
        */
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            Train tr = obj as Train;
            if (tr as Train == null)
                return false;

            return tr.number == this.number;
        }
        public override int GetHashCode()
        {
            int Dest;
            if (destination == "Питер")
                Dest = 1;
            else Dest = 2;
            return (int)amount + Dest;
        }
        public override string ToString()
        {
            return $"{number} {destination} {time}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Train tr1 = new Train("Питер", 12345, "17:15", 25, 40, 35);
            Train tr2 = new Train("Москва", 22345, "17:45", 43, 27, 30);
            Train tr3 = new Train("Минск", 32345, "17:30", 19, 30, 51);
            Console.WriteLine(tr1.GetType());
            Train[] trains;
        }
    }
}
