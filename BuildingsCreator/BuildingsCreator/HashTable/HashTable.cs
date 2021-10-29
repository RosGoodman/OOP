
using System.Collections.Generic;

namespace BuildingsCreator.HashTable
{
    /// <summary> Класс описывающий Хэш-таблицу. </summary>
    /// <typeparam name="T"> Класс содержащийся в таблице. </typeparam>
    class HashTable<T> where T : class
    {
        //т.к. номера зданий уникальны, то достаточно простого массива, а не List<T>[]
        private static T[] items;

        /// <summary> Создать экземпляр класса HashTable. </summary>
        /// <param name="size"> Размер таблицы. </param>
        public HashTable(int size)
        {
            items = new T[size];
        }

        /// <summary> Добавить экземпляр класса в таблицу. </summary>
        /// <param name="item"> Класс T. </param>
        /// <param name="key"> Ключ для записи. </param>
        public static void Add(T item, int key)
        {
            var hashKey = GetHash(key);
            items[hashKey] = item;
        }

        /// <summary> Получить экзмпляр класса Т по ключу. </summary>
        /// <param name="key"> Ключ для поиска значения. </param>
        /// <returns> Экземпляр класса Т. </returns>
        public static T Get(int key)
        {
            var hashKey = GetHash(key);
            return items[hashKey];
        }

        /// <summary> Проверить наличие в таблице по ключу. </summary>
        /// <param name="key"> Ключ для поиска экземпляра. </param>
        /// <returns> Наличие в таблице. </returns>
        public static bool Search(int key)
        {
            var hashKey = GetHash(key);
            var item = items[hashKey];

            if (item == null)
                return false;
            else
                return true;
        }

        /// <summary> Удалить экземпляр по ключу. </summary>
        /// <param name="key"> Ключ для поиска. </param>
        public static void Delete(int key)
        {
            var hashKey = GetHash(key);
            items[hashKey] = default;
        }

        /// <summary> Получить хэш-код. </summary>
        /// <param name="item"> Значение для создания ключа. </param>
        /// <returns> HashKey. </returns>
        private static int GetHash(int item)
        {
            return item.GetHashCode() % items.Length;
        }
    }
}
