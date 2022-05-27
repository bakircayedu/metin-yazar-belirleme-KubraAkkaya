using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev_2_3
{
    public class Heap
    {
        private HeapDugumu[] heapArray;
        private int maxSize;
        private int currentSize;

        public Heap(int maxHeapSize)
        {
            maxSize = maxHeapSize;
            currentSize = 0;
            heapArray = new HeapDugumu[maxSize];

        }

        public bool IsEmpty()
        {
            if (currentSize == 0)
                return true;
            return false;
        }

        public bool Insert(object value)
        {
            HeapDugumu newHeapDugumu = new HeapDugumu(value);

            if (currentSize == maxSize)
                return false;
            //for (int i = 0; i < currentSize; i++)
            //{
            //    if (heapArray[i].value.kelime == value)
            //    {
            //        heapArray[i].value.sayisi++;
            //        MoveToUp(i);
            //        return true;
            //    }
            //}
            //Kelime kelime = new Kelime(value, 1);

            heapArray[currentSize] = newHeapDugumu;
            MoveToUp(currentSize++);
            return true;
        }
        public void MoveToUp(int index)
        {
            int parent = (index - 1) / 2;
            HeapDugumu bottom = heapArray[index];
            while (index > 0 && heapArray[parent].value.sayisi < bottom.value.sayisi)
            {
                heapArray[index] = heapArray[parent];
                index = parent;
                parent = (parent - 1) / 2;
            }
            heapArray[index] = bottom;
        }

        public void DisplayHeap()
        {
            Console.WriteLine();
            Console.Write("Heap içerisindeki elemanlar: ");
            for (int i = 0; i < currentSize; i++)
            {
                if (heapArray[i] != null)
                    Console.Write(heapArray[i].Deger + " ");
                else
                    Console.Write("-- ");

            }
            Console.WriteLine();
            int emptyLeaf = 32;
            int itemsPerRow = 1;
            int column = 0;
            int j = 0;
            string separator = ".................";
            Console.WriteLine(separator + separator);
            while (currentSize > 0)
            {
                if (column == 0)
                    for (int i = 0; i < emptyLeaf; i++)
                        Console.Write(" ");
                Console.Write(heapArray[j].Deger);
                if (++j == currentSize)
                    break;
                if (++column == itemsPerRow)
                {
                    emptyLeaf /= 2;
                    itemsPerRow *= 2;
                    column = 0;
                    Console.WriteLine();
                }
                else
                    for (int i = 0; i < emptyLeaf * 2 - 2; i++)
                        Console.Write(" ");
            }
            Console.WriteLine("\n" + separator + separator);
        }

        public HeapDugumu RemoveMax() //Remove max value HeapDugumu
        {
            if (heapArray[0] == null)
                return null;
            HeapDugumu root = heapArray[0];
            heapArray[0] = heapArray[--currentSize];
            MoveToDown(0);
            return root;
        }

        public void MoveToDown(int index)
        {
            int largerChild;
            HeapDugumu top = heapArray[index];
            while (index < currentSize / 2)
            {
                int leftChild = 2 * index + 1;
                int rightChild = leftChild + 1;
                //find larger child
                if (rightChild < currentSize && heapArray[leftChild].value.sayisi < heapArray[rightChild].value.sayisi)
                    largerChild = rightChild;
                else largerChild = leftChild;

                if (top.value.sayisi >= heapArray[largerChild].value.sayisi)
                  //  break;
                heapArray[index] = heapArray[largerChild];
                index = largerChild;

            }
            heapArray[index] = top;
        }

        public Kelime[] Sort()
        {
            Kelime[] sorted = new Kelime[currentSize];
            int i = 0;
            while (!IsEmpty())
                sorted[i++] = RemoveMax().value;
            return sorted;

        }   
    }
}
