using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev_2_3
{
    public class HeapSort
    {
        public void sort(object[] arr)
        {
            int n = arr.Length;

            for (int i = n / 2 - 1; i >= 0; i--)//heap oluşşturma
                heapify(arr, n, i);

            for (int i = n - 1; i > 0; i--)//heap ten tek tek eleman çıkarma
            {
                object temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;

                // azaltılmış yığında max heapify'ı çağır
                heapify(arr, i, 0);
            }
        }

        public void heapify(object[] arr, int n, int i)
        {
            int largest = i; 
            int left = 2 * i + 1; 
            int right = 2 * i + 2; 

            if (left < n )//&& arr[left] > arr[largest])  
                largest = left;

            if (right < n )//&& arr[right] > arr[largest])  
                largest = right;

            if (largest != i)
            {
                object swap = arr[i];
                arr[i] = arr[largest];
                arr[largest] = swap;

                // Etkilenen alt ağacı yinelemeli olarak yığınla
                heapify(arr, n, largest);
            }
        }

        public static void printArray(object[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");
            Console.Read();
        }

    }
}
