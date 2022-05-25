using System;
using System.Collections.Generic;

namespace Concat_list
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list1 = new List<string> { "1", "2", "1" };
            List<string> list2 = new List<string> { "3", "2" };
            List<string> list = new List<string>();

            ConnectList(list, list1);
            ConnectList(list, list2);
            WithdrawList(list);

            Console.WriteLine();

            CreateProcess(ref list, ref list1, ref list2);
        }
        static void WithdrawList(List<string> list)
        {
            foreach (var item in list)
            {
                Console.Write($"{item} ");
            }
        }
        static void CreateProcess(ref List<string> list, ref List<string> list1, ref List<string> list2)
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
                    foreach (var item in list[i])
                    {
                        Console.Write($"{item} ");
                    }
                }
            }
        }
        static List<string> ConnectList(List<string> list, List<string> list1)
        {
            for (int i = 0; i < list1.Count; i++)
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