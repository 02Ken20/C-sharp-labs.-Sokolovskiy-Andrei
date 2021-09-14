using System;

namespace Лабораторная_Сшарп__1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Завдання №1
            /*
             double l, g = 9.8, t;
             Console.WriteLine("Введiть довжину маятнику");
             l = Convert.ToDouble(Console.ReadLine());
             t = 2 * 3.1415 * Math.Sqrt(l / g);
             Console.WriteLine($"Перiод маятнику: {t} секунд");
             */
            //Завдання №2
            /*
            double I, U , R;
            Console.WriteLine("Введiть напругу: ");
            U = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введiть опiр: ");
            R = Convert.ToDouble(Console.ReadLine());
            I = U / R;
            Console.WriteLine($"Сила струму: {I} ампер");
            */
            //Завдання №3
            /*
            double I, U, R;
            Console.WriteLine("Введiть силу струму: ");
            I = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введiть опiр: ");
            R = Convert.ToDouble(Console.ReadLine());
            U = I * R;
            Console.WriteLine($"Напруга: {U} вольт");
            */

            //Завдання №4
            /*
            double r, r1, r2, r3;
            Console.WriteLine("Введiть значення першого резистора: ");
            r1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введiть значення другого резистора: ");
            r2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введiть значення третього резистора: ");
            r3 = Convert.ToDouble(Console.ReadLine());
            r = r1 + r2 + r3;
            Console.WriteLine($"Опiр: {r} Ом");
            */

            //Завдання №5
            /*
            double r, r1, r2, r3;
            Console.WriteLine("Введiть значення першого резистора: ");
            r1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введiть значення другого резистора: ");
            r2 = Convert.ToDouble(Console.ReadLine());
            r = 1 / (1/r1 + 1 / r2);
            Console.WriteLine($"Опiр: {r} Ом");
            */

            //Завдання №6
            /*
            double v,r,h,s;
            Console.WriteLine("Введiть значення радiуса цилiндра: ");
            r = Convert.ToDouble(Console.ReadLine());
            s = 3.1415 * r * r;
            Console.WriteLine("Введiть значення висоти цилiндра: ");
            h = Convert.ToDouble(Console.ReadLine());
            v = s*h;
            Console.WriteLine($"Об'єм: {v} cm^3");
            */


            //Завдання №7
            /*
            double v, r, h, s;
            Console.WriteLine("Введiть значення радiуса конуса: ");
            r = Convert.ToDouble(Console.ReadLine());
            s = 3.1415 * r * r;
            Console.WriteLine("Введiть значення висоти конуса: ");
            h = Convert.ToDouble(Console.ReadLine());
            v = (1.0/3.0) * (s * h);
            Console.WriteLine($"Об'єм: {v} cm^3");
            */

            //Завдання №8
            /*
            double v, r, s;
            Console.WriteLine("Введiть значення радiуса кулi: ");
            r = Convert.ToDouble(Console.ReadLine());
            s = 4 * 3.1415 * r * r;
            v = 4.0 / 3.0 * 3.1415 * r * r * r;
            Console.WriteLine($"Об'єм: {v} cm^3 ; Площа: {s} cm^2");
            */

            //Завдання №9
            /*
            double a, t, s;
            Console.WriteLine("Введiть значення часу: ");
            t = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введiть значення прискорення: ");
            a = Convert.ToDouble(Console.ReadLine());
            s = a * t * t / 2;
            Console.WriteLine($"Вiдстать: {a} m");
            */

            //Завдання №10
            /*
            double t,h,v;
            Console.WriteLine("Введiть значення висоти: ");
            h = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введiть початкову швидкiсть: ");
            v = Convert.ToDouble(Console.ReadLine());
            t = Math.Sqrt((h - v) * 2 / 9.8);
            Console.WriteLine($"Час: {t} c");
            */

            //Завдання №11
            /*
            int seconds, hours, mins;
            Console.WriteLine("Введiть час в секундах: ");
            seconds = Convert.ToInt32(Console.ReadLine());
            hours = seconds / 3600;
            mins = seconds % 3600 / 60;
            seconds = seconds % 3600 % 60;
            Console.WriteLine($"Час: {hours} год., {mins} хв. та {seconds} сек.");
            */

            //Завдання №12

            /*
            double t, v1,t1,v2,t2;
            Console.WriteLine("Введiть кiлькiсть лiтрiв першого розчину: ");
            v1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введiть температуру першого розчину: ");
            t1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введiть кiлькiсть лiтрiв другого розчину: ");
            v2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введiть температуру другого розчину: ");
            t2 = Convert.ToInt32(Console.ReadLine());
            t = (v1 * t1 + v2 * t2) / (v1 + v2);
            Console.WriteLine($"Температура розчину: {t} градусiв");
            */

            //Завдання №13
            /*
            double r, s, n;
            Console.WriteLine("Введiть радiус вписаного кола: ");
            r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введiть кiлькiсть кутiв многокутника: ");
            n = Convert.ToInt32(Console.ReadLine());
            s = r * r * n * Math.Tan(3.1415 / n);
            Console.WriteLine($"Площа многокутника: {s} cm^2");
            */

            //Завдання №14
            /*
            double a1, a2, v01, v02, s, t, a, b, D;
            Console.WriteLine("Введiть прискорення 1-го тiла: ");
            a1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введiть прискорення 2-го тiла: ");
            a2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введiть швидкiсть 1-го тiла: ");
            v01 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введiть швидкiсть 2-го тiла: ");
            v02 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введiть вдстань мiж тiлами: ");
            s = Convert.ToDouble(Console.ReadLine());
            a = (a1 + a2) / 2;
            b = v01 + v02;
            if (a == 0)
                t = s / b;
            else
            {
                D = b * b + 4 * a * s;
                t = (-b + Math.Sqrt(D)) / (2 * a);
            }
            Console.WriteLine($"Час: {t} c");
            */

            //Завдання №15

            double x, answer;
            Console.WriteLine("Введiть x: ");
            x = Convert.ToDouble(Console.ReadLine());
            answer = 2 * Math.Pow(x, 4) - 3 * Math.Pow(x, 3) + 4 * Math.Pow(x, 2) - 5 * x + 6;
            Console.WriteLine($"Вiдповiдь: {answer}");
        }
    }
}
