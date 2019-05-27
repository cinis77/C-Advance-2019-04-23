using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonuKnyga
{
    internal class GenerikKlase<T, K, V> where T : class
    {
        public T Informacija { get; set; }
        public K MyProperty { get; set; }
        public V vienas { get; set; }

        public void Metodas(T item)
        {
        }

        public T Get()
        {
            return Informacija;
        }

        public GenerikKlase()
        {
        }
    }

    internal class Pavyzdys<T, K> : IDictionary<T, K>
    {
        public K this[T key] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public ICollection<T> Keys => throw new NotImplementedException();

        public ICollection<K> Values => throw new NotImplementedException();

        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(T key, K value)
        {
            throw new NotImplementedException();
        }

        public void Add(KeyValuePair<T, K> item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(KeyValuePair<T, K> item)
        {
            throw new NotImplementedException();
        }

        public bool ContainsKey(T key)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(KeyValuePair<T, K>[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<KeyValuePair<T, K>> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool Remove(T key)
        {
            throw new NotImplementedException();
        }

        public bool Remove(KeyValuePair<T, K> item)
        {
            throw new NotImplementedException();
        }

        public bool TryGetValue(T key, out K value)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

    internal class Pavyzdys<T> : IList<T>
    {
        public T this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(T item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int IndexOf(T item)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, T item)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Dictionary<string, List<int>> TelenfonuKnyga = new Dictionary<string, List<int>>();
            TelenfonuKnyga.Add("Rokas", new List<int>() { 86000000 });
            TelenfonuKnyga.Add("Tomas", new List<int>() { 1 });
            TelenfonuKnyga.Add("Vita", new List<int>() { 786453 });
            TelenfonuKnyga["Rokas"] = new List<int>() { 12345 };
            TelenfonuKnyga.Remove("Tomas");
            GenerikKlase<string, int, char> akfa = new GenerikKlase<string, int, char>();
            foreach (var item in TelenfonuKnyga)
            {
                Console.WriteLine(item.Key + " " + item.Value.First());
            }
        }
    }
}