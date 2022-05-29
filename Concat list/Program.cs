using System;
using System.Collections.Generic;

namespace Concat_list
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] list1 = { "1", "2", "1"};
            string[] list2 = { "2", "3"};
           List<string> list = new List<string>();

            ConnectList(list, list1);
            ConnectList(list, list2);
            WithdrawList(list);

            Console.WriteLine();

            CreateProcess(list);
        }
        static void WithdrawList(List<string> list)
        {
            foreach (var namber in list)
            {
                Console.Write($"{namber} ");
            }
        }
        static void CreateProcess(List<string> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                bool distinct = true;

                for (int j = 0; j < i; j++)
                {
                    if (list[j] == list[i])
                    {
                        distinct = false;
                        break;
                    }
                }
                if (distinct)
                {
                    foreach (var namber in list[i])
                    {
                        Console.Write($"{namber} ");
                    }
                }
            }
        }
        static List<string> ConnectList(List<string> list, string[] list1)
        {
            for (int i = 0; i < list1.Length; i++)
            {
                list.Add(list1[i]);
            }

            list.Sort();
            return list;
        }
    }
}

/*Задача:
 * Есть два массив строк. Надо их объеденить в одну коллекцию, исключив повторения, не используя Linq.
 * Пример: {"1", "2", "3"} + {"3", "2"} => {"1", "2", "3"} */