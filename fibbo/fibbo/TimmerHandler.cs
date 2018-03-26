﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace fibbo
{
    public static class TimmerHandler
    {
        public static string[] getTimmerArray(int iterations)
        {
            string[] timeArray = new string[iterations];
            Stopwatch sw = new Stopwatch();
            //double strong;
            int[] csv = CSVHandle.ImportCSV("./Dane.csv");
            //int[] newcsv = new int[iterations];
            //int fibbo;
            for (int i = 2; i < iterations; i++)
            {
                System.Console.Write("\nIteracja: " + (i-2));
                sw.Start();
                Algorithms.Quick_Sort(csv,0,i);
                sw.Stop();
                timeArray[i-2] = string.Format(i + ";" + sw.Elapsed.TotalMilliseconds);
                sw.Restart();
                Console.Clear();
            }
 
            return timeArray;
        }
    }
}
