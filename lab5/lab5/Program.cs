using System;

namespace lab5
{
    class Transport
    {
        public string type;
        public string Type { get; set; }
        public int number;
        public int Number { get; set; }
        public Transport()
        {

        }
        public Transport(string a = "", int b = 0)
        {
            type = a;
            number = b;
        }
        public override string ToString()
        {
            return $"{GetType()} {type} {number}";
        }
        public class Car : Transport
        {
            public string typeofcar;
            public string TypeOfCar { get; set; }
            public Car()
            {

            }
            public Car(string a = "")
            {
                typeofcar = a;
            }
            public class Motor : Car
            {
                public int volume;
                public int Volume { get; set; }
                public Motor()
                {

                }
                public Motor(int a = 0)
                {
                    volume = a;
                }
                public override bool Equals(object obj)
                {
                    if (obj.GetType() != this.GetType()) return false;

                    Motor motor = (Motor)obj;
                    return (this.volume == motor.volume);
                }
                public override int GetHashCode()
                {
                    return volume.GetHashCode();
                }
                public override string ToString()
                {
                    return $"Объём {volume} метров кубических" ;
                }
            }
        }
        public class Train : Transport
        {
            public int numberoftrain;
            public int NumberOfTrain { get; set; }
            public Train()
            {

            }
            public Train(int a = 0)
            {
                numberoftrain = a;
            }
            public override string ToString()
            {
                return $"{GetType()} {numberoftrain}";
            }
            public class Express : Train
            {
                public int price;
                public int Price { get; set; }
                public Express()
                {

                }
                public Express(int a = 0)
                {
                    price = a;
                }
                public override string ToString()
                {
                    return $"{GetType()} {price} ";
                }
            }
            public class Motor : Train
            {
                public int volofmotor;
                public int VolOfMotor { get; set; }
                public Motor()
                {

                }
                public Motor(int a = 0)
                {
                    volofmotor = a;
                }
                public override string ToString()
                {
                    return $"{GetType()} {volofmotor}";
                }
            }
            public class Carriage : Train
            {
                public int amountofplaces;
                public int AmountOfPlaces { get; set; }
                public Carriage()
                {

                }
                public Carriage(int a = 0)
                {
                    amountofplaces = a;
                }
                public override string ToString()
                {
                    return $"{GetType()} {amountofplaces}";
                }
            }
        }
        interface ISomeInterface
        {
            int Property { get; set; }
            bool DoClone();
        }
        class SomeInterface : ISomeInterface
        {
            public int Property { get; set; }
            public bool DoClone()
            {
                return true;
            }
        }
        abstract class AbsCl
        {
            public string st;
            public string St { get; set; }
            public virtual void Display()
            {
                Console.WriteLine(St);
            }
            public class FirstCl : AbsCl
            {
                public int some;
                public int Some { get; set; }
                public override void Display()
                {
                    Console.WriteLine(Some);
                }
            }
            public class SecCl : AbsCl
            {
                public int something;
                public int Something { get; set; }
            }
        }
        sealed class Seal
        {
            public string value;
            public int Value { get; set; }
            public Seal()
            {

            }
            public Seal(string a = "")
            {
                value = a;
            }

        }
        
    }
    interface ICloneable
        {
            bool DoClone();
        }
        abstract class BaseClone
        {
            public abstract bool DoClone();
        }
        class UserClass : BaseClone, ICloneable
        {
            public override bool DoClone()
            {
                Console.WriteLine("Абстрактный класс и интерфейс");
                return true;
            }          
        }
    class Printer
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            UserClass userClass = new UserClass();
            userClass.DoClone();
            Transport transport = new Transport("type", 111);
            Transport.Car car = new Transport.Car("name");
            Transport.Train train = new Transport.Train(222);
            Transport.Car.Motor motor = new Transport.Car.Motor(30);
            Transport.Train.Motor motor1 = new Transport.Train.Motor(40);
            Transport.Train.Express express = new Transport.Train.Express(555);
            Transport.Train.Carriage carriage = new Transport.Train.Carriage(60);
            if (train is Transport)
                Console.WriteLine("Train is transport");
            else
                Console.WriteLine("Train is not transport");
            Transport.Car car1 = transport as Transport.Car;
            if (car1 == null)
            {
                Console.WriteLine("Преобразование прошло неудачно");
            }
            else
            {
                Console.WriteLine("Преобразование прошло удачно");
            }
        }
    }
}
