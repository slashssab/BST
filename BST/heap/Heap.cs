using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST.heap
{
    public class Heap
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
    }
}
