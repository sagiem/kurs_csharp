using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Задача_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер теста");
            string a = Console.ReadLine();
            string filename, b;

            switch(a)
            {
                case "1":
                    filename = "test1.txt";
                    break;

                case "2":
                    filename = "test2.txt";
                    break;

                case "3":
                    filename = "test3.txt";
                    break;

                case "4":
                    filename = "test4.txt";
                    break;

                default:
                    Console.WriteLine("Сообщение об ошибке");
                    return;

            }

            StreamReader reader = new StreamReader(filename);

            while(!reader.EndOfStream)
            {
                b = reader.ReadLine();
                string[] arr = b.Split(',');

                int arr0=int.Parse(arr[0]);
                int arr1=int.Parse(arr[1]);
                int arr2=int.Parse(arr[2]);


                if(arr0>0&&arr1<=31&&arr1>0&&arr2>0&&arr2<=12)
                {
                    int god = arr0 - ((arr0 / 100)*100);
                    string ms;

                    switch(arr2)
                    {
                        case 1:
                            ms = "января";
                            break;

                        case 2:
                            ms = "февраля";
                            break;

                        case 3:
                            ms = "марта";
                            break;

                        case 4:
                            ms = "апреля";
                            break;

                        case 5:
                            ms = "мая";
                            break;

                        case 6:
                            ms = "июня";
                            break;

                        case 7:
                            ms = "июля";
                            break;

                        case 8:
                            ms = "августа";
                            break;

                        case 9:
                            ms = "сентября";
                            break;

                        case 10:
                            ms = "октября";
                            break;

                        case 11:
                            ms = "ноября";
                            break;

                        case 12:
                            ms = "декабря";
                            break;

                        default:
                            
                            return;


                    }

                    Console.WriteLine(arr1+" "+ms+" "+god+" г.");

                }
                else
                {
                    Console.WriteLine("невозможная дата");
                    
                }
            }


        }
    }
}
