using BST.heap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
    class Program
    {
        static public void CheckDeleteMax(Heap heap)
        {
            int prev = int.MaxValue;
            for (int i = 1; i < heap.HeapSize; i++)
            {
                if (heap.Max() > prev) throw new Exception("Error in Heap");
                prev = heap.Max();
                heap.DeleteMax();
              
            }
        }

        static void Main(string[] args)
        {
            Heap heap = new Heap();
            Random RandomNumber = new Random();
            for (int i = 0; i < 1000; i++)
            {
                heap.Insert(RandomNumber.Next(1000));
            }
            heap.Check();
            CheckDeleteMax(heap);
            heap.DispData(heap);

            Console.ReadLine();
            heap.DeleteMax();
  
        }
    }
    
}
