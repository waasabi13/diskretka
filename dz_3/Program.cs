using System;
using System.Collections.Generic;
using System.IO;
//Дано множество {a,b,c,d,e,f}. Построить все слова длины 5, в которых ровно одна
//буква повторяется 2 раза, остальные буквы не повторяются. Вывод в файл.
//- Дано множество {a, b, c, d, e, f}. Построить все слова длины 6, в которых ровно 2
//буквы повторяются 2 раза, остальные буквы не повторяются. Вывод в файл.
namespace dz_3
{
    class Program
    {
        static void OneWord()
        {
            StreamWriter sw = new StreamWriter("OneWord.txt");
            int sw0 = 0;
            int n = 5;
            string w = "_____";
            char[] word = w.ToCharArray();

            for (char c = 'a'; c <= 'f'; c++)
            {
                for (int pos1 = 0; pos1 < n; pos1++)
                {
                    for (int pos2 = pos1 + 1; pos2 < n; pos2++)
                    {

                        word[pos1] = c;
                        word[pos2] = c;

                        int[] other = new int[3];

                        for (int i = 0, j = 0; i < n; i++)
                        {
                            if (i != pos1 && i != pos2)
                            {
                                other[j] = i;
                                j++;
                            }

                        }
                        for (char c1 = 'a'; c1 <= 'f'; c1++)
                        {
                            for (char c2 = 'a'; c2 <= 'f'; c2++)
                            {
                                for (char c3 = 'a'; c3 <= 'f'; c3++)
                                {


                                    if (c1 != c2 && c1 != c3 && c2 != c3 && c1 != c && c2 != c && c3 != c)//проверка на то что буквы в other не совпадают между собой и не совпадают с выбранной в "c"
                                    {
                                            word[other[0]] = c1;
                                            word[other[1]] = c2;
                                            word[other[2]] = c3;

                                            sw.WriteLine(word);
                                            sw0++;
                                        
                                    }

                                }
                            }
                        }

                    }

                }

            }
            sw.WriteLine(sw0);
            sw.Close();
        }
        static void TwoWord()
        {
            StreamWriter sw = new StreamWriter("Two.txt");
            int sw1 = 0;
            int n = 6;
            string w = "______";
            char[] word = w.ToCharArray();

            for (char c = 'a'; c <= 'f'; c++)
            {
                c++;
                char m = c++;
                for (m = 'a';  m <= 'f'; m++)
                {
                    if (m != c)
                    {
                        for (int pos1 = 0; pos1 < n; pos1++)
                        {
                            for (int pos2 = pos1 + 1; pos2 < n; pos2++)
                            {
                                for (int pos21 = 0; pos21 < n; pos21++)
                                {
                                    for (int pos22 = pos21 + 1; pos22 < n; pos22++)
                                    {
                                        if (pos1 == pos21 || pos1 == pos22 || pos2 == pos21 || pos2 == pos22)
                                            continue;
                                        word[pos1] = c;
                                        word[pos2] = c;
                                        word[pos21] = m;
                                        word[pos22] = m;

                                        int[] other = new int[2];
                                        for (int i = 0, j = 0; i < n; i++)
                                        {
                                            if (i != pos1 && i != pos2 && i != pos21 && i != pos22)
                                            {
                                                other[j] = i;
                                                j++;
                                            }
                                        }

                                        for (char c1 = 'a'; c1 <= 'f'; c1++)
                                        {
                                            for (char c2 = 'a'; c2 <= 'f'; c2++)
                                            {
                                                if (c1 != c2)
                                                {
                                                    if (c1 != c && c2 != c && c1 != m && c2 != m)
                                                    {
                                                        word[other[0]] = c1;
                                                        word[other[1]] = c2;
                                                        sw.WriteLine(word);
                                                        sw1++;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }

                            }

                        }
                    }
                }

            }
            sw.WriteLine(sw1);
            sw.Close();
        }
        static void Main(string[] args)
        {
            OneWord();
            TwoWord();
        }
    }
}
