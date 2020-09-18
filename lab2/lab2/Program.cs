using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //task a
            bool BoolVar = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine(BoolVar);
            byte ByteVar = Convert.ToByte(Console.ReadLine());
            Console.WriteLine(ByteVar);
            sbyte SByteVar = Convert.ToSByte(Console.ReadLine());
            Console.WriteLine(SByteVar);
            int IntVar = Console.Read();
            Console.WriteLine(IntVar);
            uint UIntVar = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine(UIntVar);
            long LongVar = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine(LongVar);
            ulong ULongVar = Convert.ToUInt64(Console.ReadLine());
            Console.WriteLine(ULongVar);
            float FloatVar = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine(FloatVar);
            double DoubleVar = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(DoubleVar);
            decimal DecimalVar = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine(DecimalVar);
            char CharVar = Convert.ToChar(Console.ReadLine());
            Console.WriteLine(CharVar);
            string StringVar = Convert.ToString(Console.ReadLine());
            Console.WriteLine(StringVar);
            object ObjectVar = Console.ReadLine();
            Console.WriteLine(ObjectVar);

            //task b
            byte a = 15;
            byte b = (byte)(a + 30);

            ushort a2 = 3;
            byte b2 = (byte)a2;

            double a3 = 7.0;
            decimal b3 = (decimal)a3;

            int a4 = 10, b4 = 9;
            byte c4 = (byte)(a4 + b4);

            int a5 = 4;
            double b5 = (double)a5;



            byte d1 = 2;
            ushort e1 = d1;

            sbyte d2 = -1;
            short e2 = d2;

            sbyte d3 = 8;
            short e3 = d3;

            int d4 = 8;
            long e4 = d4;

            float d5 = 5.32f;
            double e5 = d5;

            //task c

            int i = 93;
            object o = i;

            o = 78;
            i = (int)o;

            //task d

            var i1 = 5;
            var i2 = 83.2;
            var i3 = 0.19F;
            Console.WriteLine(i1 + i2 + i3);

            //task e

            int? NullIntVar = null;
            bool? NullBoolVar = null;

            Nullable<int> NullIntVar2 = 3;
            Nullable<bool> NullBoolVar2 = null;
            
            Console.WriteLine(NullIntVar.Value);

            int? p = null;
            if (p.HasValue)
                Console.WriteLine(p.Value);
            else
                Console.WriteLine("p is equal to null");

            int? DefVar = null;
            Console.WriteLine(DefVar.GetValueOrDefault());

            //task f
            var FirstVar = 15;
            //FirstVar = 'ds';
            

            //strings
            string Str1 = "First string", Str2 = "Second string";
            int Result = String.Compare(Str1, Str2);
            if (Result < 0)
            {
                Console.WriteLine("Строка Str1 перед Str2");
            }
            else if(Result>0)
            {
                Console.WriteLine("Строка Str1 после Str2");
            }
            else
            {
                Console.WriteLine("Строки идентичны");
            }


            string st1 = "one one", st2 = "two two", st3 = "three three";
            string st4 = st1 + " " + st2;
            string st5 = String.Concat(st3, "!!!");
            Console.WriteLine(st4);
            Console.WriteLine(st5);

            string st6 = String.Copy(st2);
            Console.WriteLine(st6);

            string st7 = st1.Substring(0, 2);
            Console.WriteLine(st7);

            string[] words = Str1.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(words);

            string st8 = st2.Insert(2, st1);
            Console.WriteLine(st8);

            string s9 = st1.Remove(3, 3);
            
            int x = 3, y = 5;
            string res = $"{x} + {y} = {x + y}";
            Console.WriteLine(res);

            string? NullStr = null;
            string EmptyStr = " ";

            Console.WriteLine(String.IsNullOrEmpty(NullStr));
            Console.WriteLine(String.IsNullOrEmpty(EmptyStr));

            StringBuilder sb = new StringBuilder("Some string");
            Console.WriteLine($"Length: {sb.Length}");
            Console.WriteLine($"Capacity: {sb.Capacity}");

            sb.Remove(5,6);
            sb.Append(" new string");
            sb.Insert(0, "This is ");
            Console.WriteLine(sb);
            

            //arrays

            int[,] array = { { 1, 3 }, { 2, 8 } };
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }


            string[] arrString = { "one", "two", "three", "four"};
            Console.WriteLine($"Length of array: {arrString.Length}");
            for (int i = 0; i < arrString.Length; i++)
            {
                Console.WriteLine($"AS[{i}] = {arrString[i]}");
            }
            arrString[2] = "not three";
            for (int i = 0; i < arrString.Length; i++)
            {
                Console.WriteLine($"AS[{i}] = {arrString[i]}");
            }
            

            double[][] DoubleArray = { new double[2], new double[3], new double[4] };
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("DoubleArray[" + 0 + "][" + i + "]: ");
                DoubleArray[0][i] = double.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("DoubleArray[" + 1 + "][" + i + "]: ");

                DoubleArray[1][i] = double.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("DoubleArray[" + 2 + "][" + i + "]: ");

                DoubleArray[2][i] = double.Parse(Console.ReadLine());
            }
            foreach (double[] x in DoubleArray)
            {
                foreach (double b in x)
                    Console.Write("\t" + b);
                Console.WriteLine();
            }

   
            var UnArray = new[]{ 3, 5, 6};
            var UnString = "some str"; 
            */

            ValueTuple<int, string, char, string, ulong> tuple = (15, "string", 'h', "string too", 5324);
            Console.WriteLine($"{tuple}");
            Console.WriteLine(tuple.Item2.ToString());
            Console.WriteLine(tuple.Item3);
            Console.WriteLine(tuple.Item4.ToString());
            var (one, two, three, four, five) = tuple;
        }

    }
}
