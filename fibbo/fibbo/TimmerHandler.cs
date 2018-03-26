using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace fibbo
{
    public static class TimmerHandler
    {
        public static string[] getTimmerArray(int iterations, int rodzajFunkcji)
        {
            string[] timeArray = new string[iterations];
            Stopwatch sw = new Stopwatch();
            //double strong;
            int[] csv = CSVHandle.ImportCSV("./Dane.csv");
            //int[] newcsv = new int[iterations];
            //int fibbo;

            switch (rodzajFunkcji)
            {
                case 1:
                    for (int i = 2; i < iterations; i++)
                    {
                        System.Console.Write("\nIteracja: " + (i - 2));
                        sw.Start();
                        Algorithms.Quick_Sort(csv, 0, i);
                        sw.Stop();
                        timeArray[i - 2] = string.Format(i + "," + sw.Elapsed.TotalMilliseconds);
                        sw.Restart();
                        Console.Clear();
                    }
                    break;

                case 2:
                    for (int i = 2; i < iterations; i++)
                    {
                        System.Console.Write("\nIteracja: " + (i - 2));
                        sw.Start();
                        Algorithms.BubbleSort(csv, i);
                        sw.Stop();
                        timeArray[i - 2] = string.Format(i + "," + sw.Elapsed.TotalMilliseconds);
                        sw.Restart();
                        Console.Clear();
                    }
                    break;

                case 3:
                    for (int i = 2; i < iterations; i++)
                    {
                        System.Console.Write("\nIteracja: " + (i - 2));
                        sw.Start();
                        Algorithms.Strong(i);
                        sw.Stop();
                        timeArray[i - 2] = string.Format(i + "," + sw.Elapsed.TotalMilliseconds);
                        sw.Restart();
                        Console.Clear();
                    }
                    break;

                case 4:
                    for (int i = 2; i < iterations; i++)
                    {
                        System.Console.Write("\nIteracja: " + (i - 2));
                        sw.Start();
                        Algorithms.F(i);
                        sw.Stop();
                        timeArray[i - 2] = string.Format(i + "," + sw.Elapsed.TotalMilliseconds);
                        sw.Restart();
                        Console.Clear();
                    }
                    break;

                //case 5:
                //    Algorithms.heap
                //    break;


                default:
                    throw new Exception("to nie jest poprawny wybór");
          
            }
 
            return timeArray;
        }
    }
}
