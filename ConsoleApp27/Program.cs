using System;

namespace ConsoleApp27
{
    class Program
    {
        static void Main(string[] args)
        {
            //7.2
            //это шутка какая то или я не понял задание 
            //средний уровнь 12 задание 
            string line = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
            Console.WriteLine(line);
            //это базовый уровень 12 
            Console.Write("введите строку: ");
            string str = Console.ReadLine();
            int result = 0;
            for (int i = 0; i < str.Length; ++i)
                result += ((int)str[i]);
            Console.WriteLine(result);
        }
    }
}
