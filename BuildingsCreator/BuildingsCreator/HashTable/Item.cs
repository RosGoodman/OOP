using System.Collections.Generic;

namespace BuildingsCreator.HashTable
{
    class Item<T>
    {
        public int key { get; set; }
        public List<T> nodes { get; set; }

        public Item(int key)
        {
            this.key = key;
            nodes = new List<T>();
        }
    }
}
