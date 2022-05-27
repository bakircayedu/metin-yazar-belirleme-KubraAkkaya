using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev_2_3
{
    public class HashMap
    {
        HashEntry[] table;
        int tableSize = 10;
        public HashMap()
        {
            table = new HashEntry[tableSize];
            for (int i = 0; i < tableSize; i++)
            {
                table[i] = null;
            }
        }

        public void Add(int key, object value)
        {
            int hash = (key % tableSize);
            while (table[hash] != null && table[hash].Anahtar != key)
            {
                hash = (hash + 1) % tableSize;
            }
        }

        public object Get(int key)
        {
            int hash = (key % tableSize);
            while (table[hash] != null && table[hash].Anahtar != key)
                hash = (hash + 1) % tableSize;
            if (table[hash] == null)
                return null;
            else
                return table[hash].Deger;
        }

        //ayrık zincirleme kısmı 

        /*
        public void add(int value)
        {
            int hash = value % table.Length;

            if (table[hash] == null)
            {
                LinkedList<Integer> toAdd = new LinkedList<Integer>();
                toAdd.add(value);
                table[hash] = toAdd;
            }
            else
            {
                table[hash].add(value);
            }
        }

        public Boolean remove(int value)
        {
            int hash = value % table.Length;

            if (table[hash] == null)
            {
                return false;
            }
            else
            {
                if (table[hash].contains(value))
                {
                    int linkedListLocation = table[hash].indexOf(value);
                    table[hash].remove(linkedListLocation);

                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        */
    }
}
