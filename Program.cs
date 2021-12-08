using System;
using System.Collections.Generic;


/*
 * Lab1 #1 Виводить на екран введене число з клавіатури в зворотному порядку (1234->4321)
*/

/*
namespace PD_22_Sokolovskiy_Adrei
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, dec = 10;
            Console.Write("Enter a number: ");
            n = Convert.ToInt32(Console.ReadLine());
            while (n % dec > 0)
            {
                Console.Write(n % 10);
                n /= dec;
            }
        }
    }
}
*/

/*
 * Lab1 #2 Виводить будь-яку строку в зворотному порядку (АБВ->ВБА)
*/

/*
namespace PD_22_Sokolovskiy_Adrei
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            s = Console.ReadLine();
            for (int i = s.Length - 1; i >= 0; i--)
            {
                Console.Write(s[i]);
            }
        }
    }
}
*/

/*
 * Lab1 #3 Дробові числа виводяться в зворотному порядку і ціла частина і дробова (123.456->321.654)
 */

/*
namespace PD_22_Sokolovskiy_Adrei
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string [] numbers = input.Split('.');
            for (int i = numbers[0].Length - 1; i >= 0; i--)
                Console.Write(numbers[0][i]);
            Console.Write('.');
            for (int i = numbers[1].Length - 1; i >= 0; i--)
                Console.Write(numbers[1][i]);
        }
    }
}
*/

/*
 * Lab1 #4 Реалізувати метод, що буде масив повертати задом навпаки (Використання Array.Reverse() заборонено!)
 */

/*
namespace PD_22_Sokolovskiy_Adrei
{
    class Program
    {
        static void Main(string[] args)
        {
            const int size = 6;
            int[] arr = new int[size];
            Console.WriteLine("Enter 6 numbers: ");
            for (int i = 0; i < size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            arr = ArrReverse(arr);
            for (int i = 0; i < size; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
        public static int[] ArrReverse(int[] arr)
        {
            for (int i = 0; i < arr.Length / 2; i++)
            {
                int temp = arr[i];
                arr[i] = arr[arr.Length - i - 1];
                arr[arr.Length - i - 1] = temp;
            }
            return arr;
        }
    }
}
*/

/*
 * Lab1 #5 Виконати пункт 4 з використанням ключових слів ref i out
 */

/*
namespace PD_22_Sokolovskiy_Adrei
{
    class Program
    {
        const int size = 6;
        static void Main(string[] args)
        {
            int[] arr = new int[size];
            int[] arr1;
            ArrReverse1(out arr1);
            Console.WriteLine("[ref]Enter 6 numbers: ");
            for (int i = 0; i < size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            ArrReverse(ref arr);
            Console.WriteLine("[ref]");
            for (int i = 0; i < size; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("\n[out]");
            for (int i = 0; i < size; i++)
            {
                Console.Write(arr1[i] + " ");
            }
        }
        public static void ArrReverse(ref int[] arr)
        {
            for (int i = 0; i < arr.Length / 2; i++)
            {
                int temp = arr[i];
                arr[i] = arr[arr.Length - i - 1];
                arr[arr.Length - i - 1] = temp;
            }
        }
        public static void ArrReverse1(out int[] arr1)
        {
            arr1 = new int[size];
            Console.WriteLine("[out]Enter 6 numbers: ");
            for (int i = 0; i < size; i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < arr1.Length / 2; i++)
            {
                int temp = arr1[i];
                arr1[i] = arr1[arr1.Length - i - 1];
                arr1[arr1.Length - i - 1] = temp;
            }
        }
    }
}
*/

/*
 * Lab2 #1 Перевірити істинність вислову: "Дане ціле число є парним двозначним числом".
 */

/*
namespace PD_22_Sokolovskiy_Adrei
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            if (a < 100 && a > 9 && a % 2 == 0)
                Console.WriteLine("True");
            else
                Console.WriteLine("False");
        }
    }
}
*/

/*
 * Lab2 #2 Перевірити істинність вислову: "Дане ціле число є непарним тризначним числом". 
 */

/*
namespace PD_22_Sokolovskiy_Adrei
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            if (a < 1000 && a > 99 && a % 2 != 0)
                Console.WriteLine("True");
            else
                Console.WriteLine("False");
        }
    }
}
*/

/*
 * Lab2 #3 Перевірити істинність вислову: "Серед трьох даних цілих чисел є хоч би одна пара співпадаючих". 
 */

/*
namespace PD_22_Sokolovskiy_Adrei
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            if (a == b || a ==c || b == c)
                Console.WriteLine("True");
            else
                Console.WriteLine("False");
        }
    }
}
*/

/*
 * Lab2 #4 Перевірити істинність вислову: "Серед трьох даних цілих чисел є хоч би одна пара взаємно протилежних". 
 */

/*
namespace PD_22_Sokolovskiy_Adrei
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            if (a + b == 0 || a + c == 0 || b + c == 0)
                Console.WriteLine("True");
            else
                Console.WriteLine("False");
        }
    }
}
*/



/*
 * Lab2 #5 Перевірити істинність вислову: "Сума цифр даного тризначного числа є парним числом". 
 */

/*
namespace PD_22_Sokolovskiy_Adrei
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            if ((a % 10 + (a % 100 - a % 10) / 10 + a / 100) % 2 == 0)
                Console.WriteLine("True");
            else
                Console.WriteLine("False");
        }
    }
}
*/

/*
 * Lab2 #6 Перевірити істинність вислову: "Перевірити істинність вислову: "Сума двох перших цифр 
 * даного чотиризначного числа рівна сумі двох його останніх цифр". ". 
 */

/*
namespace PD_22_Sokolovskiy_Adrei
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            if (a % 10 + (a % 100 - a % 10) / 10 == (a % 100 - a % 10) / 10 + a / 100)
                Console.WriteLine("True");
            else
                Console.WriteLine("False");
        }
    }
}
*/


/*
 * Lab3 #17 Дано дійсне число R і масив розміру N. Знайти елемент масиву, який найближчий (найдальший) від даного числа. 
 */

/*
namespace PD_22_Sokolovskiy_Adrei
{
    class Program
    {
        static void Main(string[] args)
        {
            const int size = 10;
            int[] arr = new int[size];
            int R;
            int ind = 0;
            Console.WriteLine("Enter R: ");
            R = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Enter element #" + (i + 1) + ": ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int min = R - arr[ind];
            for (int i = 1; i < size; i++)
            {
                if (Math.Abs(arr[i] - R) < min)
                {
                    ind = i;
                    min = Math.Abs(arr[i] - R);
                }
            }
            Console.WriteLine("The closest element to " + R + " in current array is " + arr[ind]);
        }
    }
}
*/


/*
 * Lab4 Використовуючи інтерфейси або спадкування реалізуйте еволюцію: дисковий телефон -> 
 * кнопочний телефон –>мобільний телефон з чорно-> білим екраном – >мобільний телефон з 
 * кольоровим екраном – >смартфон. (краще спадкування)
 */

/*
namespace PD_22_Sokolovskiy_Adrei
{
    class Program
    {

        class rotary_telephone 
        {
            protected string number { get; set; }
            protected bool number_entered = false;
            public void enter_number()
            {
                Console.WriteLine("Enter a phone number: ");
                number = Console.ReadLine();
                number_entered = true;
            }
            public virtual void call_number()
            {
                if (number_entered)
                Console.WriteLine($"Calling by the number {number}...Success!");
                else
                {
                    Console.WriteLine("You must enter the number before calling!");
                    enter_number();
                }
            }
        };
        class push_button_telephone : rotary_telephone 
        {
            bool sim_is_inserted = false;
            public void press_buttons()
            {
                if (sim_is_inserted)
                    enter_number();
                else
                {
                    Console.WriteLine("You need to insert SIM card before entering numbers!");
                    insert_sim_card();
                    press_buttons();
                }
            }
            public override void call_number()
            {
                if (sim_is_inserted && number_entered)
                    Console.WriteLine($"Calling by the number {number}...Success!");
                else
                {
                    Console.WriteLine("You must enter the number and insert SIM-card before calling!");
                    enter_number();
                    insert_sim_card();
                }
            }
            public void insert_sim_card()
            {
                Console.WriteLine("Insert SIM card? yes/no");
                string check;
                check = Console.ReadLine();
                if (check == "yes")
                    sim_is_inserted = true;
            }
            public void remove_sim_card()
            {
                Console.WriteLine("Remove SIM card? yes/no");
                string check;
                check = Console.ReadLine();
                if (check == "yes")
                {
                    sim_is_inserted = false;
                    Console.WriteLine("SIM card was successfully removed!");
                }
            }
        };

        class white_black_telephone : push_button_telephone 
        {
            protected bool white_black_display = true;
        };

        class colorful_telephone : white_black_telephone 
        {
            protected bool colorful_screen = false;
            public void switch_colors()
            {
                Console.WriteLine("Switch the diplay to colorful? yes/no");
                string switcher;
                switcher = Console.ReadLine();
                if (switcher == "yes")
                {
                    white_black_display = false;
                    colorful_screen = true;
                }
                    
            }

            public void switch_color_default()
            {
                if (colorful_screen)
                    colorful_screen = false;
                else
                    colorful_screen = true;
            }
        };

        class smartphone : colorful_telephone 
        {
            bool no_buttons = false;
            bool good_camera = false;
            bool IOS_Android_system = false;
            bool programs = false;
            string s_upgrade;
  
            public void upgrade()
            {
                this.switch_color_default();
                Console.WriteLine("Do you want to upgrade from push-button telephone with colorful screen to a smartphone? yes/no");
                s_upgrade = Console.ReadLine();
                if (s_upgrade == "yes")
                {
                    string upgrade_options;
                    Console.WriteLine("Which of the following things do you want to upgrade (IOS or Android system will be automatically implemented)? No buttons, good camera, installed multiple programs. 1 " +
                    "to incluce a technology and 0 to pass (for example: 101 means no buttons and installed programs");
                    upgrade_options = Console.ReadLine();
                    IOS_Android_system = true;
                    switch (upgrade_options)
                    {
                        case "000":
                            break;
                        case "001":
                            programs = true; break;
                        case "010":
                            good_camera = true; break;
                        case "011":
                            good_camera = true;
                            programs = true; break;
                        case "100":
                            no_buttons = true; break;
                        case "101":
                            no_buttons = true;                            
                            programs = true;
                            break;
                        case "110":
                            no_buttons = true;
                            good_camera = true;                            
                            break;
                        case "111":
                            no_buttons = true;
                            good_camera = true;
                            programs = true; break;
                    }
                    Console.Write("Now you have colorful screen, IOS/Andriod system, ");
                    if (no_buttons)
                        Console.Write(" no buttons, ");
                    if (good_camera)
                        Console.Write("good camera and ");
                    if (programs)
                        Console.Write("installed programs");
                }
            }
        };

        static void Main(string[] args)
        {
            rotary_telephone r = new rotary_telephone();
            push_button_telephone pbt = new push_button_telephone();
            colorful_telephone ct = new colorful_telephone();
            smartphone s = new smartphone();
            int option;
            bool quit = true;
            Console.Write("You have a rotary telephone.");
            while (quit)
            {
                Console.WriteLine(" Do you want to call or enter a phone number? 0 - quit, 1 - enter a number, 2 - call");
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 0: quit = false; break;
                    case 1: r.enter_number(); break;
                    case 2: r.call_number(); break;
                    default: Console.WriteLine("Incorrect input!"); break;
                }
            }
            quit = true;
            Console.Write("Now you have a push-button telephone.");
            while (quit)
            {
                Console.WriteLine(" Do you want to call or enter a phone number? 0 - quit, 1 - enter a number using buttons, 2 - call, 3 - insert SIM card, 4 - remove SIM card");
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 0: quit = false; break;
                    case 1: pbt.press_buttons(); break;
                    case 2: pbt.call_number(); break;
                    case 3: pbt.insert_sim_card(); break;
                    case 4: pbt.remove_sim_card(); break;
                    default: Console.WriteLine("Incorrect input!"); break;
                }
            }
            quit = true;
            Console.Write("Now you have a push-button telephone with colorful and white-black screen opitons.");
            while (quit)
            {
                Console.WriteLine("Do you want to call or enter a phone number? 0 - quit, 1 - enter a number, 2 - call, 3 - insert SIM card, 4 - remove SIM card, 5 - switch screen colors");
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 0: quit = false; break;
                    case 1: ct.enter_number(); break;
                    case 2: ct.call_number(); break;
                    case 3: ct.insert_sim_card(); break;
                    case 4: ct.remove_sim_card(); break;
                    case 5: ct.switch_colors(); break;
                    default: Console.WriteLine("Incorrect input!"); break;
                }
            }         
            quit = true;
            Console.WriteLine("Now you have a push-button telephone with colorful screen and an option to upgrade to a smartphone. ");
            while (quit)
            {
                Console.WriteLine("Do you want to call or enter a phone number? 0 - quit, 1 - enter a number, 2 - call, 3 - insert SIM card, 4 - remove SIM card, 5 - upgrade");
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 0: quit = false; break;
                    case 1: s.enter_number(); break;
                    case 2: s.call_number(); break;
                    case 3: s.insert_sim_card(); break;
                    case 4: s.remove_sim_card(); break;
                    case 5: s.upgrade(); break;
                    default: Console.WriteLine("Incorrect input!"); break;
                }
            }
        }
    }
}
*/
