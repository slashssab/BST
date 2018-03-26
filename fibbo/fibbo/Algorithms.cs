using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibbo
{
    public static class Algorithms
    {
        public static int F(int n)
        {
            if (n == 0) return 1;
            else if (n == 1) return 1;
            else return F(n - 1) + F(n - 2);
        }

        public static double Strong(double n)
        {
            if (n == 0) return 1;
            else return n * Strong(n - 1);
        }

        public static int[] BubbleSort(int[] _arr, int iter)
        {
            for (int i = 0; i < iter - 1; i++)
            {
                for (int j = 0; j < iter - 1; j++)
                {
                    if (_arr[j] > _arr[j + 1])
                    {
                        _arr[j] -= _arr[j + 1];
                        _arr[j + 1] += _arr[j];
                        _arr[j] = _arr[j + 1] - _arr[j];
                    }
                }
            }
            return _arr;
        }
        public static void Quick_Sort(int[] A, int left, int right)
        {
            if (left > right || left < 0 || right < 0) return;

            int index = partition(A, left, right);

            if (index != -1)
            {
                Quick_Sort(A, left, index - 1);
                Quick_Sort(A, index + 1, right);
            }
        }

        public static int partition(int[] A, int left, int right) //Used in Quick_Sort
        {
            if (left > right) return -1;

            int end = left;

            int pivot = A[right];    // choose last one to pivot, easy to code
            for (int i = left; i < right; i++)
            {
                if (A[i] < pivot)
                {
                    swap(A, i, end);
                    end++;
                }
            }
            
            swap(A, end, right);

            return end;
        }

        private static void swap(int[] A, int left, int right)
        {
            int tmp = A[left];
            A[left] = A[right];
            A[right] = tmp;
        }



    }
}
