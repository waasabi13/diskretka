using System;
using System.IO;
namespace DM8
{
    //    Построить алгоритм проверки, является преобразование из графа 1 в граф 2
    //автоморфизмом.Графы вводятся в виде таблицы смежности вершин.
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader graph1 = new StreamReader("graph1.txt"); //файл смежности вершин 1 графа
            StreamReader graph2 = new StreamReader("graph2.txt"); //файл смежности вершин 2 графа
            string s_graph1 = graph1.ReadToEnd();
            string s_graph2 = graph2.ReadToEnd();
            if (s_graph1 == s_graph2)
                Console.WriteLine("Данное преобразование является автоморфизмом");
            else Console.WriteLine("Данное преобразование не является автоморфизмом");
        }
    }
}
