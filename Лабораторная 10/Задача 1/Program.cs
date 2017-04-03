using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Задача_1
{
    class Program
    {
        static void Main(string[] args)
        {

            string filename = "out.html";
            StreamWriter writer = new StreamWriter(filename);
            writer.Write("<!DOCTYPE html>\n<html>\n<head>\n    <meta charset=\"utf - 8\"/>\n<head/>\n<body>\n    <h1>Мой первый векторный рисунок</h1>\n\n    <svg width=\"800\" height=\"600\">\n        <circle cx=\"50\" cy=\"50\" r=\"40\" stroke=\"green\"\n		stroke-width=\"4\" fill=\"yellow\"/>\n    </svg>\n</body>\n</html>\n\n");


            writer.Close();
            System.Diagnostics.Process.Start(filename);
        }


    }
}
