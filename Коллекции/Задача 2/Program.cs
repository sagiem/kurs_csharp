using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "\nТри девицы Три под окном\nПряли поздно вечерком.\n\"Кабы я была царица, —\nГоворит одна девица, —\nТо на весь крещеный мир\nПриготовила б я пир\".\n\"Кабы я была царица, —\nГоворит ее сестрица, —\nТо на весь бы мир одна\nНаткала я полотна\".\n\"Кабы я была царица, —\nТретья молвила сестрица, —\nЯ б для батюшки-царя\nРодила богатыря\".\n";
            string[] arr = str.Split(new char[] { ' ', '\n', '\"', ',', '.' });
            Dictionary<string, int> dir = new Dictionary<string, int>();
           

            for (int i = 0; i < arr.Length; i++ )
            {
                string temp =  arr[i].ToLower();
                if(temp=="")
                {
                    continue;
                }

                if (dir.ContainsKey(temp))
                {
                    int val = dir[temp];
                    val++;
                    dir[temp] = val;


                }
                else
                {
                    dir.Add(temp, 0);
                }
            }

                Console.WriteLine(String.Join(" ", dir));
        }
    }
}
