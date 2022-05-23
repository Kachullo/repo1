using System;

namespace Урок_второй
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Мои задачи");
            Console.WriteLine("=================================");
            Console.WriteLine("1 -> Задача 1");
            Console.WriteLine("2 -> Задача 2");
            Console.WriteLine("0 -> Завершение работы приложения");
            Console.WriteLine("=================================");

            Console.Write("Введите номер задачи: ");
            int number = int.Parse(Console.ReadLine());


            switch (number)
            {
                case 2:
                    Task2();
                    break;

                case 0:
                    Console.WriteLine("Завершение работы приложения ...");
                    Console.ReadKey();
                    return;

                case 1:
                    Task1();
                    break;

                default:
                    Console.WriteLine("Некорректный номер задачи,\nповторите попытку ввода ...");
                    Console.ReadKey();
                    break;
            }


        }



        static void Task2()
        {
            Console.WriteLine("Какой порядковый номер текущего месяца?");
            string manth = Console.ReadLine();
            int x = int.Parse(manth);
            
            switch (x)
            {



                case 1: manth = "Январь"; break;
                case 2: manth = "Февраль"; break;
                case 3: manth = "Март"; break;
                case 4: manth = "Апрель"; break;
                case 5: manth = "Май"; break;
                case 6: manth = "Июнь"; break;
                case 7: manth = "Июль"; break;
                case 8: manth = "Август"; break;
                case 9: manth = "Сентябрь"; break;
                case 10: manth = "Октябрь"; break;
                case 11: manth = "Ноябрь"; break;
                case 12: manth = "Декабрь"; break;
            }
            Console.WriteLine(manth);
        }
        
        
        static void Task1()
        {
            Console.Write("Какая минимальная температура за сутки?");
            string mintemp = Console.ReadLine();
            double x = double.Parse(mintemp);

            Console.Write("Какая максимальная температура за сутки?");
            string maxtemp = Console.ReadLine();
            double y = double.Parse(maxtemp);

            double z = (y + x) / 2;

            Console.Write($"Средняя температура за сутки ");
            Console.Write(z);



        }






    }
}
