using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heapp
{
    class Heap
    {
        private IList<int> data;
        public int HeapSize;

        public Heap()
        {
            data = new List<int>();
            //dodaję zerowy element ponieważ zaczynamy wypełniać tablicę od indeksu 1
            data.Add(0);
        }

        public void DispData(Heap _heap)
        {
            foreach (int element in _heap.data)
            {
                Console.WriteLine(element);
            }
        }

        private void Swap(int index0, int index1)
        {
            int aux = data[index0];
            data[index0] = data[index1];
            data[index1] = aux;
        }

        public void Insert(int n)
        {
            HeapSize++;
            data.Add(n);
            //data[HeapSize] == n;
            int Index = HeapSize;
            while (Index > 1)
            {
                if (n > data[Index / 2]) Swap(Index, Index / 2);
                else break;
                Index = Index / 2;
            }
        }

        public void MoveDownHeap(int topIndex)
        {
            int index = topIndex;
            int n = data[topIndex];
            while (index * 2 <= HeapSize)
            {
                int indexGreater;
                if ((index * 2 < HeapSize) && (data[index * 2 + 1] > data[index * 2]))
                    indexGreater = index * 2 + 1;
                else
                    indexGreater = index * 2;
                if (n < data[indexGreater])
                    Swap(index, indexGreater);
                else break;
                index = indexGreater;
            }
        }

        public void DeleteMax()
        {
            data[1] = data[HeapSize];
            data.RemoveAt(HeapSize);
            HeapSize--;
            MoveDownHeap(1);
        }

        public void Construct(int index)
        {
            if (2 * index <= HeapSize / 2) Construct(2 * index);
            if (2 * index + 1 <= HeapSize / 2) Construct(2 * index + 1);
            MoveDownHeap(index);
        }

        public void Check()
        {
            for (int i = 1; i <= HeapSize / 2; i++)
            {
                if (data[i] < data[2 * i]) throw new Exception("Error in Heap");
                if (2 * i + 1 <= HeapSize)
                    if (data[i] < data[2 * i + 1]) throw new Exception("Error in Heap");
            }
        }
        public int Max()
        {
            return data[1];
        }
        public void PokazKopiec(int index)
        {
            if (index < HeapSize)
                Console.WriteLine("         "+data[index]);
            int a = index * 2;
            if ((a+1)< HeapSize)
                Console.WriteLine("     "+data[a]+" - "+data[a+1]);
            if(((a + 1) * 2 + 1)<HeapSize)
                Console.WriteLine(data[a * 2] + " - " + data[a * 2+1] + " - "+ data[(a+1) * 2] + " - " + data[(a + 1) * 2 + 1]);
        }

        public static void glowneMenu()
        {
            Heap heap = new Heap();
            ConsoleKeyInfo iter;
            bool exit=false;
            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("Witaj, którą czynność chcesz wykonać:");
                Console.WriteLine("1. Wypełnij kopiec (1000 losowych wartosci z zakresu 0-1000)");
                Console.WriteLine("2. Usuń największą wartość w kopcu");
                Console.WriteLine("3. Wyświetl kopiec");
                Console.WriteLine("4. Wyjdź do menu głównego");
                heap.Check();
                iter = Console.ReadKey();
                
                if (iter.KeyChar == '1')
                {
                    Random RandomNumber = new Random();
                    for (int i = 0; i < 1000; i++)
                    {
                        heap.Insert(RandomNumber.Next(1000));
                    }
                }
                if (iter.KeyChar == '2') { heap.DeleteMax(); }
                //if (iter.KeyChar == '3') { heap.DispData(heap); Console.ReadKey(); }
                if (iter.KeyChar == '3')
                {
                    Console.WriteLine("Jaki indeks pokazać?");
                    heap.PokazKopiec(Convert.ToInt32(Console.ReadLine()));
                    Console.ReadKey();
                }
                if (iter.KeyChar == '4') { exit = true; }

                //Console.ReadLine();

            }
        }
    }
}
