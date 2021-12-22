using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//- Дано множество { a,b,c,d,e,f }. Построить все слова длины 5, в которых ровно две
//буквы a.Вывод в файл.
//-Дано множество
//{ a,b,c,d,e,f}. Построить все слова длины 5, в которых ровно 2
//буквы a, остальные буквы не повторяются. Вывод в файл.
namespace dz_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            int n = 5; // длина слова
            string w = "_____";
            char[] word = w.ToCharArray();
            StreamWriter swS = new StreamWriter("Povtorov.txt");
            StreamWriter swW = new StreamWriter("BezPovtor.txt");
            int sws = 0, sww = 0;
            for (int pos1 = 0; pos1 < n; pos1++)
            {
                for (int pos2 = pos1 + 1; pos2 < n; pos2++)
                {

                    word[pos1] = 'a';
                    word[pos2] = 'a';

                    int[] other = new int[3];//массив для позиций других букв
                    for (int i = 0, j = 0; i < n; i++)
                    {
                        if (i != pos1 && i != pos2)
                        {
                            other[j] = i;
                            j++;
                        }
                    }
                    for (char c1 = 'b'; c1 <= 'f'; c1++)//выбор букв
                    {
                        for (char c2 = 'b'; c2 <= 'f'; c2++)
                        {
                            for (char c3 = 'b'; c3 <= 'f'; c3++)
                            {

                                word[other[0]] = c1;
                                word[other[1]] = c2;
                                word[other[2]] = c3;
                                swS.WriteLine(word);
                                sws++;//с учетом повторов

                              
                            }
                        }
                    }

                }

            }
            for (int pos1 = 0; pos1 < n; pos1++)
            {
                for (int pos2 = pos1 + 1; pos2 < n; pos2++)
                {

                    word[pos1] = 'a';
                    word[pos2] = 'a';

                    int[] other = new int[3];//массив для позиций других букв
                    for (int i = 0, j = 0; i < n; i++)
                    {
                        if (i != pos1 && i != pos2)
                        {
                            other[j] = i;
                            j++;
                        }
                    }
                    for (char c1 = 'b'; c1 <= 'f'; c1++)//выбор букв
                    {
                        for (char c2 = 'b'; c2 <= 'f'; c2++)
                        {
                            for (char c3 = 'b'; c3 <= 'f'; c3++)
                            {
                                if (c1 != c2 && c1 != c3 && c2 != c3)// без повторов
                                {
                                    word[other[0]] = c1;
                                    word[other[1]] = c2;
                                    word[other[2]] = c3;
                                    swW.WriteLine(word);
                                    sww++;

                                }
                            }
                        }
                    }
                }
            }
            swW.WriteLine(sww);
            swS.WriteLine(sws);
            swW.Close();
            swS.Close();
            Console.WriteLine(list.Count);
        }
    }
}
