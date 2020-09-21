using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("----------1a----------\n");
            int a1; uint a2; long a3; ulong a4; short a5; ushort a6; byte a7; sbyte a8; float a9; double a10; decimal a11; char a12; bool a13; string a14; object a15;

            Console.WriteLine("Write int:");
            a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Int: {0}\n", a1);

            Console.WriteLine("Write uint:");
            a2 = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("UInt: {0}\n", a2);

            Console.WriteLine("Write long:");
            a3 = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Long: {0}\n", a3);

            Console.WriteLine("Write ulong:");
            a4 = Convert.ToUInt64(Console.ReadLine());
            Console.WriteLine("ULong: {0}\n", a4);

            Console.WriteLine("Write short:");
            a5 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Short: {0}\n", a5);

            Console.WriteLine("Write ushort:");
            a6 = Convert.ToUInt16(Console.ReadLine());
            Console.WriteLine("UShort: {0}\n", a6);

            Console.WriteLine("Write byte:");
            a7 = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Byte: {0}\n", a7);

            Console.WriteLine("Write sbyte:");
            a8 = Convert.ToSByte(Console.ReadLine());
            Console.WriteLine("SByte: {0}\n", a8);

            Console.WriteLine("Write float:");
            a9 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Float: {0}\n", a9);

            Console.WriteLine("Write double:");
            a10 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Double: {0}\n", a10);

            Console.WriteLine("Write decimal:");
            a11 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Decimal: {0}\n", a11);

            Console.WriteLine("Write char:");
            a12 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Char: {0}\n", a12);

            Console.WriteLine("Write bool:");
            a13 = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Bool: {0}\n", a13);

            Console.WriteLine("Write string:");
            a14 = Console.ReadLine();
            Console.WriteLine("String: {0}\n", a14);

            Console.WriteLine("Write object:");
            a15 = Console.ReadLine();
            Console.WriteLine("Object: {0}\n\n", a15);



            Console.WriteLine("\n----------1b----------\n");

            byte n1 = 19;
            short n2 = n1;
            int n3 = n1;
            long n4 = n1;
            ulong n5 = n1;
            Console.WriteLine("Byte: {0}, short: {1}, int: {2}, long: {3}, ulong: {4}\n", n1, n2, n3, n4, n5);

            int a = 4;
            byte b = (byte)(a);
            Console.WriteLine("Int: {0}, byte: {1}\n", a, b);

            short c = 4;
            long d = (long)(c);
            Console.WriteLine("Short: {0}, long: {1}\n", c, d);

            short e = 5;
            byte f = (byte)e;
            Console.WriteLine("Short: {0}, byte: {1}\n", e, f);

            char g = '5';
            int h = (int)(g);
            Console.WriteLine("Char: {0}, int: {1}\n", g, h);

            double k = 17.5656;
            float j = (float)(k + 33);
            Console.WriteLine("Double: {0}, float: {1}\n", k, j);



            Console.WriteLine("\n----------1c----------\n");

            int z3 = 123;
            object o3 = z3;
            Console.WriteLine("Упаковка: {0}\n", o3);

            int b3 = (int)o3;
            Console.WriteLine("Распаковка: {0}\n", b3);


            Console.WriteLine("\n----------1d----------\n");

            var v1 = "string";
            var v2 = 3.5;
            Console.WriteLine("{0}: {1}", v1, v1.GetType());
            Console.WriteLine("{0}: {1}", v2, v2.GetType());




            Console.WriteLine("\n----------1e----------\n");

            Nullable<int> p = null;
            int? q = null;
            bool ie = p == q;
            Console.WriteLine("Имеет ли значение р? " + p.HasValue);
            Console.WriteLine("Равны ли переменные p и q? " + ie);


            Console.WriteLine("\n----------1f----------\n");

            var VI = 124;
            //VI = "string";



            Console.WriteLine("\n----------Строки----------\n");

            var s1 = "Volchek ";
            var s2 = "Darya ";
            var s3 = "Ivanovna ";
            var s4 = String.Compare(s1, s3);
            var s5 = String.Compare(s2, s1);
            Console.WriteLine("Сравнение строк 1 и 3: {0}\nСравнение строк 2 и 1: {1}\n", s4, s5);
            var s6 = String.Concat(s1, s2);
            Console.WriteLine("Сцепление строк 1 и 2: {0} \n", s6);
            var s7 = String.Copy(s6);
            Console.WriteLine("Копирование строки: {0} \n", s7);
            var s8 = s3.Substring(3, 3);
            Console.WriteLine("Подстрока: {0} \n", s8);
            Console.WriteLine("Split");
            string[] w = s6.Split();
            Console.WriteLine("Первая подстрока: {0}\nВторая подстрока: {1}\n", w[0], w[1]);
            var s9 = s1.Insert(4, s2);
            Console.WriteLine("Вставка подстроки в заданную позицию: {0} \n", s9);
            var s10 = s9.Remove(4, 4);
            Console.WriteLine($"Удаление подстроки с заданной позиции: {s10} \n");

            string se = "";
            string sn = null;
            Console.WriteLine("Длина строки: {0}", se.Length);
            Console.WriteLine(se == sn);
            Console.WriteLine(String.IsNullOrEmpty(sn));

            StringBuilder sb = new StringBuilder("Darya", 50);
            sb.Remove(2, 3);
            sb.Append("sha");
            sb.Insert(0, "My name is ");
            Console.WriteLine(sb);




            Console.WriteLine("\n----------Массивы----------\n");

            int[,] arr = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                    Console.Write(arr[x, y] + " ");
                Console.WriteLine();
            }



            int i;
            string[] m = { "1111111", "2222222", "3333333", "4444444", "5555555" };
            for (i = 0; i < m.Length; i++)
            {
                Console.Write(" " + m[i]);
            }
            Console.WriteLine();
            Console.WriteLine($"Длина массива: {m.Length}");
            Console.WriteLine("Введите позицию элемента и новое значение");
            m[Convert.ToInt32(Console.ReadLine()) - 1] = Console.ReadLine();
            for (i = 0; i < m.Length; i++)
            {
                Console.Write(" " + m[i]);
            }
            Console.WriteLine();




            Console.WriteLine("Ступенчатый массив\n");
            int[][] sm = new int[][]
            {
                new int[2],
                new int[3],
                new int[4]
            };
            Console.WriteLine("Введите элементы массива");
            for (int x = 0; x < sm.Length; x++)
                for (int y = 0; y < sm[x].Length; y++)
                    sm[x][y] = Convert.ToInt32(Console.ReadLine());


            for (int x = 0; x < sm.Length; x++)
            {
                for (int y = 0; y < sm[x].Length; y++)
                {
                    Console.Write("{0} ", sm[x][y]);
                }
                Console.WriteLine();
            }


            var array = new object[0];
            var str = "string";



            Console.WriteLine("\n----------Кортежи----------\n");

            (int, string, char, string, ulong) k1 = (27, "fgfgfgf", 'm', "tytytytyt", 143435564);
            Console.WriteLine("Первый кортеж: {0}", k1);
            Console.WriteLine($"Второй элемент кортежа: {k1.Item2}, четвертый элемент кортежа: {k1.Item4}");


            int first = k1.Item1;
            string second = k1.Item2;
            char third = k1.Item3;
            string fourth = k1.Item4;
            ulong fifth = k1.Item5;



            var k2 = (33, "dsdsdsds", 'o', "bnbnbnbnb", (ulong)6584798);
            Console.WriteLine("Второй кортеж: {0}", k2);
            if (k1.CompareTo(k2) == 0)
                Console.WriteLine("Кортежи равны");
            else
                Console.WriteLine("Кортежи не равны");



            Console.WriteLine("\n----------Локальная функция----------\n");

            (int, int, int, char) LocalFunction(int[] arr1, string str1)
            {
                int max = arr1.Max();
                int min = arr1.Min();
                int sum = arr1.Sum();
                char first = str1[0];
                return (max, min, sum, first);

            }
            var Arr1 = new[] { 2, 4, 67, 43, 22, 7, 39, 58 };
            string Str1 = "Darya";
            Console.WriteLine(LocalFunction(Arr1, Str1));


            Console.WriteLine("\n----------checked/unchecked----------\n");

            int l1 = Int32.MaxValue;
            int l2 = 12345;
            Console.WriteLine(Check(l1, l2));
            Console.WriteLine(Uncheck(l1, l2));

            int Check(int L1, int L2)
            {
                try
                {
                    checked
                    {
                        int result = L1 + L2;
                        return result;
                    }
                }
                catch (OverflowException message)
                {
                    Console.WriteLine(message.Message);
                }
                return 0;
            }

            int Uncheck(int L1, int L2)
            {
                try
                {
                    unchecked
                    {
                        int result = L1 + L2;
                        return result;
                    }
                }
                catch (OverflowException message)
                {
                    Console.WriteLine(message.Message);
                }
                return 0;
            }
        }
    }
}

