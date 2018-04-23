using Lists_n_Heaps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST.heap
{
    public class Heap
    {
        private IList<Word> data;
        public int HeapSize;

        public Heap()
        {
            data = new List<Word>();
            //dodaję zerowy element ponieważ zaczynamy wypełniać tablicę od indeksu 1
            data.Add(new Word(" ", " "));
        }

        public void DispData(Heap _heap)
        {
            foreach (Word element in _heap.data)
            {
                Console.WriteLine("Eng:{0}, Pl:{1}", element.eng, element.pl);
            }
        }

        private void Swap(int index0, int index1)
        {
            Word aux = data[index0];
            data[index0] = data[index1];
            data[index1] = aux;
        }

        public void Insert(Word n)
        {
            HeapSize++;
            data.Add(n);
            //data[HeapSize] == n;
            int Index = HeapSize;
            while (Index > 1)
            {
                if (Encoding.ASCII.GetBytes(n.eng)[0] > Encoding.ASCII.GetBytes(data[Index / 2].eng)[0]) Swap(Index, Index / 2);
                else break;
                Index = Index / 2;
            }
        }

        public void MoveDownHeap(int topIndex)
        {
            int index = topIndex;
            Word n = data[topIndex];
            while (index * 2 <= HeapSize)
            {
                int indexGreater;
                if ((index * 2 < HeapSize) && (Encoding.ASCII.GetBytes(data[index * 2 + 1].eng)[0] > Encoding.ASCII.GetBytes(data[index * 2].eng)[0]))
                    indexGreater = index * 2 + 1;
                else
                    indexGreater = index * 2;
                if (Encoding.ASCII.GetBytes(n.eng)[0] < Encoding.ASCII.GetBytes(data[indexGreater].eng)[0])
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
                if (Encoding.ASCII.GetBytes(data[i].eng)[0] < Encoding.ASCII.GetBytes(data[2 * i].eng)[0]) throw new Exception("Error in Heap");
                if (2 * i + 1 <= HeapSize)
                    if (Encoding.ASCII.GetBytes(data[i].eng)[0] < Encoding.ASCII.GetBytes(data[2 * i + 1].eng)[0]) throw new Exception("Error in Heap");
            }
        }
        public Word Max()
        {
            return data[1];
        }

        public void PokazKopiec(int index)
        {
            if (index < HeapSize)
                Console.WriteLine("         " + data[index].eng);
            int a = index * 2;
            if ((a + 1) < HeapSize)
                Console.WriteLine("     " + data[a].eng + " - " + data[a + 1].eng);
            if (((a + 1) * 2 + 1) < HeapSize)
                Console.WriteLine(data[a * 2].eng + " - " + data[a * 2 + 1].eng + " - " + data[(a + 1) * 2].eng + " - " + data[(a + 1) * 2 + 1].eng);
        }
    }
}
