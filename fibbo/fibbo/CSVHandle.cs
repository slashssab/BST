using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace fibbo
{
    public static class CSVHandle
    {
        public static Random random = new System.Random();

        public static int[] ImportCSV(string _filePath)
        {
            string reader = System.IO.File.ReadAllText(_filePath);
            reader = reader.Replace('\n', '\r');
            string[] lines = reader.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            int[] numbers_a = new int[lines.Length];

            for (int i = 0; i <= numbers_a.Length - 1; i++)
            {
                numbers_a[i] = Convert.ToInt32(lines[i]);
            }
            return numbers_a;
        }

        public static void SaveArrayAsCSV<T>(string fileName, T[] arrayToSave)
        {
            string[] newArray = new string[arrayToSave.Length];
            for (int i = 0; i <= newArray.Length - 1; i++)
            {
                newArray[i] = Convert.ToString(arrayToSave[i]);
            }

            File.WriteAllText(@fileName, string.Join("\r", arrayToSave));
        }

        public static void CreatedimArray(int size, string fileName)
        {
            string[] newArray = new string[size];
            for (int i = 0; i <= size - 1; i++)
            {
                newArray[i] = Convert.ToString(random.Next(0, size));
            }

            File.WriteAllText(@fileName, string.Join("\r", newArray));
        }
    }
}
