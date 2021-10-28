using System;
using System.Collections.Generic;

namespace BuildingsCreator
{
    //public class HashTable<TKey, TValue>
    //{
    //    private List<TValue>[] items;

    //    public HashTable(int size)
    //    {
    //        items = new List<TValue>[size];
    //    }

    //    public void Add(TValue value, TKey key)
    //    {
    //        var hashKey = GetHash(key);
    //        if(items[hashKey] == null)
    //        {
    //            items[hashKey] = new List<TValue>() { value };
    //        }
    //        else
    //            items[hashKey].Add(value);
    //    }

    //    public List<TValue> Get(TKey key)
    //    {
    //        var hashKey = GetHash(key);
    //        return items[hashKey];
    //    }

    //    private int GetHash(TKey key)
    //    {
    //        //для хэша берем только 1 символ.
    //        return Convert.ToInt32(key.ToString().Substring(0, 1));
    //    }
    //}
}
