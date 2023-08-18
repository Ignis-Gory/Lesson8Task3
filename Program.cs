using System;
using System.Collections.Generic;

namespace HomeWork8Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> checkOnRepeat = new HashSet<int>();
            do
            {
                Console.WriteLine("Введите число, что хотите добавить в коллекцию");
                string number = Console.ReadLine();
                if (number == "")
                {
                    break;
                }
                else if (checkOnRepeat.Contains(int.Parse(number)))
                {
                    Console.WriteLine("Такое число уже есть, введить дургое число");
                }
                else
                {
                    checkOnRepeat.Add(int.Parse(number));
                }
            } while (true);
            

            foreach (var item in checkOnRepeat)
            {
                Console.Write(item + "\t");
            }
            Console.WriteLine();
        }
    }
}
