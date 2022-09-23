using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    internal class HashTable3<K, V>
    {
        private int size;
        private LinkedList<KeyValue<K, V>>[] items;
        public HashTable3(int size)
        {
            this.size = size;
            items = new LinkedList<KeyValue<K, V>>[size];
        }
        public int GetArrayPosition(K Key)
        {
            int position = Key.GetHashCode() % size;
            return Math.Abs(position);
        }
        public void Add(K Key, V Value)
        {
            int position = GetArrayPosition(Key);
            LinkedList<KeyValue<K, V>> linkedlist = GetLinkedList(position);
            KeyValue<K, V> item = new KeyValue<K, V>() { Key = Key, Value = Value };
            linkedlist.AddLast(item);
        }
        public LinkedList<KeyValue<K, V>> GetLinkedList(int Position)
        {
            LinkedList<KeyValue<K, V>> linkedlist = items[Position];
            if (linkedlist == null)
            {
                linkedlist = new LinkedList<KeyValue<K, V>>();
                items[Position] = linkedlist;
            }
            return linkedlist;
        }
        //UC3
        //Remove the words Avoidable
        public V Get(K key)
        {
            int position = GetArrayPosition(key);

            LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);

            foreach (KeyValue<K, V> item in linkedList)
            {
                if (item.Key.Equals(key))
                {
                    return item.Value;
                }
            }
            return default(V);
        }
        public void Remove(K key)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);
            bool itemFound = false;
            KeyValue<K, V> foundItem = default(KeyValue<K, V>);
            foreach (KeyValue<K, V> item in linkedList)
            {
                if (item.Key.Equals(key))
                {
                    itemFound = true;
                    foundItem = item;
                }
            }
            if (itemFound)
            {
                linkedList.Remove(foundItem);
            }
        }
        public void Display()
        {
            foreach (var linkedlist in items)
            {
                if (linkedlist != null)
                    foreach (KeyValue<K, V> KeyValue in linkedlist)
                    {
                        Console.WriteLine(KeyValue.Key + " " + KeyValue.Value);
                    }
            }
        }
    }
}
