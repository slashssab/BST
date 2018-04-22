using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists_n_Heaps.StateCommands.HeapSort
{
    public class HeapSort
    {
        private int heapSize = 6;


        private void BuildHeap(List<Word> arr)
        {
            heapSize = arr.Count - 1;
            for (int i = heapSize / 2; i >= 0; i--)
            {
                Heapify(arr, i);
            }
        }

        private void Swap(List<Word> arr, int x, int y)//function to swap elements
        {
            Word temp = arr[x];
            arr[x] = arr[y];
            arr[y] = temp;
        }
        private void Heapify(List<Word> arr, int index)
        {
            int left = 2 * index;
            int right = 2 * index + 1;
            int largest = index;
            
            if (left <= heapSize && Encoding.ASCII.GetBytes(arr[left].eng)[0] > Encoding.ASCII.GetBytes(arr[index].eng)[0])
            {
                largest = left;
            }

            if (right <= heapSize && Encoding.ASCII.GetBytes(arr[right].eng)[0] > Encoding.ASCII.GetBytes(arr[largest].eng)[0])
            {
                largest = right;
            }

            if (largest != index)
            {
                Swap(arr, index, largest);
                Heapify(arr, largest);
            }
        }
        public void PerformHeapSort(List<Word> arr)
        {
            BuildHeap(arr);
            for (int i = arr.Count - 1; i >= 0; i--)
            {
                Swap(arr, 0, i);
                heapSize--;
                Heapify(arr, 0);
            }
            DisplayArray(arr);
        }
        private void DisplayArray(List<Word> arr)
        {
            for (int i = 0; i < arr.Count; i++)
            { Console.Write("[{0}]", arr[i].eng); }
        }
    }
}
