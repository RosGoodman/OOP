
using System.Collections.Generic;

namespace BuildingsCreator.HashTable
{
    class HashTable<T>
    {
        private static Item<T>[] items;

        public HashTable(int size)
        {
            items = new Item<T>[size];

            for (int i = 0; i < items.Length; i++)
            {
                items[i] = new Item<T>(i);
            }
        }

        public static void Add(T item)
        {
            var key = GetHash(item);
            items[key].nodes.Add(item);
        }

        public static List<T> Get(T item)
        {
            var key = GetHash(item);
            return items[key].nodes;
        }

        private static int GetHash(T item)
        {
            return item.GetHashCode() % items.Length;
        }
    }
}
