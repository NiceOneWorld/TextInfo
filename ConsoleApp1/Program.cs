using System;
using System.Linq;


namespace dz_03
{
    class Program
    {
        static void TextInfo(string str)
        {
            Console.WriteLine($"\n Общее колл. символов: {str.Length}");
            Console.WriteLine($" пробелов: {str.Count(char.IsWhiteSpace)}");
            Console.WriteLine($" цифр: {str.Count(char.IsDigit)}");
            Console.WriteLine($" знаков припинания: {str.Count(char.IsPunctuation)}");
            Console.WriteLine($" букв и пробелов: {str.Length - str.Count(char.IsDigit) - str.Count(char.IsPunctuation)}");
        }

        static void Main(string[] args)
        {
            //// Task 1
            Console.WriteLine("/ Task - 1 ");
            Console.WriteLine(" Введите текст -> ");
            string text1 = Console.ReadLine();
            TextInfo(text1);

            ////// Task 2
            Console.WriteLine("\n/ Task - 2 ");
            Console.WriteLine(" Введите текст -> ");
            string text2 = Console.ReadLine();
            Console.WriteLine(" Введите один символ -> ");
            string symbol = Console.ReadLine();
            text2 = text2.Replace(symbol, symbol.ToUpper());
            Console.WriteLine(text2);
            text2 = text2.Substring(0, text2.LastIndexOf(symbol.ToUpper()));
            Console.WriteLine(text2);

            //// Task 3
            Console.WriteLine("\n/ Task - 3 ");
            string text3 = "Hello world world world";
            Console.WriteLine(text3);
            text3 = string.Join(" ", text3.Split(' ').Distinct());
            Console.WriteLine(text3);

            // Task 4
            Console.WriteLine("\n/ Task - 4");
            string text4 = "jhdjasd asdasd sdsd";
            Console.WriteLine(text4);
            string[] strs = text4.Split();
            for (int i = 0; i < strs.Length; i++)
            {
                if ((strs[i].Length) > 1)
                {
                    for (int j = 1; j < strs[i].Length; j++)
                    {
                        if (strs[i][0] == strs[i][j])
                        {
                            strs[i] = strs[i].Remove(j--, 1);
                        }
                    }
                }
            }
            string buf = string.Empty;
            for (int i = 0; i < strs.Length; i++)
            {
                buf += strs[i] + " ";
            }
            text4 = buf;
            Console.WriteLine(text4);

            // Task 5
            // Преобразовать все слова по правилу: удалить в слове только
            // последние вхождения каждого символа.
            Console.WriteLine("\n/ Task - 5");
            string text5 = "jhdjasd asdasd sdsd";
            Console.WriteLine(text5);
            string[] arr = text5.Split();
            for (int i = 0; i < arr.Length; i++)
            {
                string tmp = string.Empty;
                for (int j = 0; j < arr[i].Length; j++)
                {
                    int pos = arr[i].LastIndexOf(arr[i][j]);
                    if (pos != j && pos != -1)
                    {
                        if (tmp.IndexOf(arr[i][j]) == -1)
                        {
                            arr[i] = arr[i].Remove(pos, 1);
                            tmp += arr[i][j];
                        }
                    }
                }
            }
            string tmp1 = string.Empty;
            for (int i = 0; i < arr.Length; i++)
            {
                tmp1 += arr[i] + " ";
            }
            text5 = tmp1;
            Console.WriteLine(text5);



        }
    }
}

