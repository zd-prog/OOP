using System;
using System.Collections.Generic;
using System.Linq;

namespace lab5_6
{
    public interface ICloneable
    {
        void DoClone();
    }
    public abstract class BaseClone
    {
        abstract public void DoClone();
    }
    public class Realization : BaseClone, ICloneable
    {
        override public void DoClone()
        {
            Console.WriteLine("AbstractMethod");
        }
        void ICloneable.DoClone()
        {
            Console.WriteLine("WriteInterfaceMethod Realization");
        }


    }
    public class Transport : BaseClone
    {
        public override void DoClone()
        {
            Console.WriteLine("Abstract Transport");
        }
        public string type;
        public string Type { get; set; }
        public int volume;
        public int Volume { get; set; }
        public int price;
        public int Price { get; set; }
        public int min_speed;
        public int MinSpeed { get; set; }
        public int max_speed;
        public int MaxSpeed { get; set; }

        public Transport[] transports;
        public Transport this[int index]
        {
            get
            {
                return this.transports[index];
            }
            set
            {
                this.transports[index] = value;
            }
        }
        enum Age
        {
            New,
            Old
        }
        public struct Structura
        {
            public string Value;
        }
        public Transport()
        {

        }
        public Transport(string a = "", int b = 0, int min = 0, int max = 0, int vol = 0)
        {
            type = a;
            price = b;
            min_speed = min;
            max_speed = max;
            volume = vol;
        }
        public override string ToString()
        {
            return $"{GetType()} Тип транспорта: {type}, цена: {price}, минимальная цена: {min_speed}, максимальная цена: {max_speed}, объём двигателя: {volume}";
        }
        public partial class Car : Transport
        {
            public string typeofcar;
            public string TypeOfCar { get; set; }
            public Car[] cars1;
            public Car this[int index]
            {
                get
                {
                    return this.cars1[index];
                }
                set
                {
                    this.cars1[index] = value;
                }
            }
            public Car() : base()
            {

            }
            public Car(string a, int b, int c, int d, int e, Car[] cars) : base(a,b,c,d,e)
            {
                this.TypeOfCar = a;
                this.cars1 = cars;
                this.Price = b;
                this.MinSpeed = c;
                this.MaxSpeed = d;
                this.Volume = e;
            }
            public Car(string a, int b, int c, int d, int e) : base(a, b, c, d, e)
            {
                this.TypeOfCar = a;
                this.Price = b;
                this.MinSpeed = c;
                this.MaxSpeed = d;
                this.Volume = e;
            }
            public class Motor : Car
            {
                public int volumeofmotor;
                public int VolumeOfMotor { get; set; }
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
                    return $"Объём {volume} метров кубических";
                }
            }
        }
        public class Train : Transport, ICloneable
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
            public new void DoClone()
            {
                Console.WriteLine($"Интерфейс {numberoftrain}");
            }
            public class Express : Train
            {
                public int priceexp;
                public int PriceExpress { get; set; }
                public Express()
                {

                }
                public Express(int a = 0)
                {
                    price = a;
                }
                public override string ToString()
                {
                    return $"{GetType()} {priceexp} ";
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
            sealed public class Carriage : Train, ICloneable
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
                public new void DoClone()
                {
                    Console.WriteLine($"Интерфейс {amountofplaces}");
                }
            }
        }

    }
    class Printer
    {
        public void IAmPrinting(Transport someobj)
        {
            Console.WriteLine($"Тип объекта - " + someobj.GetType());
            Console.WriteLine(someobj.ToString());
        }
    }
    public class TransportAgency
    {
        public string Name { get; set; }
        public Transport.Car car;
        public Transport tr;
        public TransportAgency()
        {

        }
        public TransportAgency(Transport.Car cars, Transport transport)
        {
            this.car = cars;
            this.tr = transport;
        }
        public TransportAgency(Transport.Car c, Transport t, string nm)
        {
            this.car = c;
            this.tr = t;
            this.Name = nm;
        }
        private List<Transport> _container;
        public Transport this[int index]
        {
            get { return _container[index]; }
            set { _container[index] = value; }
        }
        public override string ToString()
        {
            return base.ToString() + $"\nName: {Name}";
        }
        public void AddItem(Transport transport) => _container.Add(transport);
        public void AddItem(Transport.Car car) => _container.Add(car);

        public void Delete(Transport transport) => _container.Remove(transport);
        public void Delete(Transport.Car car) => _container.Remove(car);

        public void Print()
        {
            for (int i = 0; i < _container.Count - 1; i++)
            {
                Console.WriteLine(_container[i]);
            }
        }
    }
    public class TransportController
    {
        public void Sum(TransportAgency transportAgency)
        {
            int sum = 0;
            for (int i = 0; i < transportAgency.tr.transports.Length; i++)
            {
                sum += transportAgency.tr.transports[i].Price;
            }
            Console.WriteLine(sum);
        }
        public void SortByFuel(TransportAgency transportAgency)
        {
            Transport.Car temp = null;
            for (int i = 1; i < transportAgency.car.cars1.Length - 1 ; i++)
            {
                if (transportAgency.car.cars1[i].Volume > transportAgency.car.cars1[i + 1].Volume)
                {
                    temp = transportAgency.car.cars1[i];
                    transportAgency.car.cars1[i]= transportAgency.car.cars1[i + 1];
                    transportAgency.car.cars1[i + 1] = temp;
                }
            }
        }
        public void BySpeed(TransportAgency transportAgency)
        {
            Console.WriteLine("Введите минимальную и максимальную скорость");
            int min = 0, max = 0;
            min = Console.Read();
            max = Console.Read();
            Transport temp = null;
            for (int i = 0; i < transportAgency.tr.transports.Length; i++)
            {
                if (transportAgency.tr.transports[i].MinSpeed == min && transportAgency.tr.transports[i].MaxSpeed == max)
                {
                    temp = transportAgency.tr.transports[i];
                }
            }
            Console.WriteLine(temp);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Transport transport = new Transport("transport", 10000, 60, 120, 8);
            transport.DoClone();
            Transport.Car car = new Transport.Car("car", 20000, 55, 100, 8);
            car.DoClone();
            Transport.Train train = new Transport.Train(222);
            train.DoClone();
            Transport.Car.Motor motor = new Transport.Car.Motor(30);
            motor.DoClone();
            Transport.Train.Motor motor1 = new Transport.Train.Motor(40);
            Transport.Train.Express express = new Transport.Train.Express(555);
            express.DoClone();
            Transport.Train.Carriage carriage = new Transport.Train.Carriage(60);
            carriage.DoClone();
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

            dynamic[] arrayOfTransport = new dynamic[] { train, transport, carriage, car };
            Printer printer = new Printer();
            printer.IAmPrinting(train);
            printer.IAmPrinting(car);
            printer.IAmPrinting(carriage);

            Transport transport1 = new Transport("transport", 15000, 80, 120, 9);
            Transport transport2 = new Transport("transport", 17000, 30, 90, 9);

            Transport.Car car2 = new Transport.Car("car", 30000, 120, 200, 20);


            TransportAgency agency = new TransportAgency();
            agency.AddItem(car);
            agency.AddItem(transport1);
            agency.AddItem(transport2);
            agency.AddItem(car2);

            TransportController controller = new TransportController();
            controller.Sum(agency);
            controller.BySpeed(agency);
            controller.SortByFuel(agency);


        }
    }
}
