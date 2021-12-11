using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace What

{
    class Program
    {
        static void Main(string[] args)
        {

            bool work = true;

            while (work)
            {
                Console.WriteLine("Введите дробь с помошью знака  ");

                Console.WriteLine("введите число");
                int a;
                while (!int.TryParse(Console.ReadLine(), out a))
                {
                    Console.WriteLine("Ошибка ввода! Введите нужное число");
                }
                Console.WriteLine("введите число");

                int b;
                while ((!int.TryParse(Console.ReadLine(), out b) || b == 0))
                {
                    Console.WriteLine("Ошибка ввода! Введите нужное число");
                }

                Fraction f = new Fraction(a, b);
                Console.WriteLine("f = {0};\n", f);
                Console.Write("Что нужно сделать? \nНажмите 1 чтобы умножить \nНажмите 2 чтобы сложить\nНажмите 3 чтобы вычесть\nНажмите 4 чтобы поделить\nНажмите 5 чтобы сравнить\n");
                int vvod;
                while ((!int.TryParse(Console.ReadLine(), out vvod) || vvod > 3 || vvod < 0))
                {
                    Console.WriteLine("Ошибка ввода! Введите нужное число");
                }
                switch (vvod)
                {
                    case 1:
                        int n;
                        while (!int.TryParse(Console.ReadLine(), out n))
                        {
                            Console.WriteLine("Ошибка ввода! Введите нужное число");
                        }
                        Console.WriteLine("введите число");

                        Fraction f3 = f + n;
                        Console.WriteLine("f3 = {0} + {1} = {2};\n", f, n, f3);
                        break;

                    case 2:
                        Console.WriteLine("Введите дробь с помошью знака  ");

                        int c;
                        while (!int.TryParse(Console.ReadLine(), out c))
                        {
                            Console.WriteLine("Ошибка ввода! Введите нужное число");
                        }
                        Console.WriteLine("введите число");
                        int d;
                        while (!int.TryParse(Console.ReadLine(), out d))
                        {
                            Console.WriteLine("Ошибка ввода! Введите нужное число");
                        }
                        
                        Fraction f5 = new Fraction(c, d);
                        Fraction f4 = f - f5;
                        Console.WriteLine("f2 = {0} - {1} = {2};\n", f, f5, f4);

                        break;

                    case 3:
                        Console.WriteLine("Введите дробь с помошью знака  ");

                        int  m;
                        while (!int.TryParse(Console.ReadLine(), out m))
                        {
                            Console.WriteLine("Ошибка ввода! Введите нужное число");
                        }
                        Console.WriteLine("введите число");
                        int v;
                        while (!int.TryParse(Console.ReadLine(), out v))
                        {
                            Console.WriteLine("Ошибка ввода! Введите нужное число");
                        }
                        Fraction f9 = new Fraction(m, v);
                        Fraction f6 = f / f9;
                        Console.WriteLine("f2 = {0} / {1} = {2};\n", f, f9, f6);
                        break;

                    case 4:
                        Fraction f7 = new Fraction(3, 4);
                        if (f == f7) Console.WriteLine("{0} = {1};\n", f, f7);
                        else Console.WriteLine("{0} != {1};\n", f, f7);
                        break;

                    case 5:
                        Fraction f8 = new Fraction(1, 9);
                        if (f != f8) Console.WriteLine("{0} != {1};\n", f, f8);
                        else Console.WriteLine("{0} == {1};\n", f, f8);

                        break;

                    case 6:
                        work = false;
                        break;


                     




                }
            } 

            

           

            



            Console.ReadKey();
        }
    }
}
