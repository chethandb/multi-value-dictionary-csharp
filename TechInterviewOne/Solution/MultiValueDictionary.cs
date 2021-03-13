using System;
using System.Collections;
using System.Collections.Generic;
using TechInterviewOne.Problem1;

namespace TechInterviewOne.Solution
{
    public class MultiValueDictionary<K, V> : IMultiValueDictionary<K, V>
    {
        private readonly Dictionary<K, List<V>> keyValuePairs;

        public MultiValueDictionary()
        {
            keyValuePairs = new Dictionary<K, List<V>>();
        }

        public IEnumerable<V> this[K key]
        {
            get
            {
                if (keyValuePairs.ContainsKey(key))
                    return keyValuePairs[key];
                else
                    throw new KeyNotFoundException();
            }
        }

        public V Add(K key, V value)
        {

            if (keyValuePairs.ContainsKey(key))
            {
                if (keyValuePairs[key].Contains(value))
                {
                    throw new InvalidOperationException();
                }

                keyValuePairs[key].Add(value);
            }
            else
            {
                keyValuePairs.Add(key, new List<V>() { value });
            }

            return value;
        }

        public void Clear()
        {
            keyValuePairs.Clear();
        }

        public bool ContainsKey(K key)
        {
            return keyValuePairs.ContainsKey(key);
        }

        public bool ContainsValue(K key, V value)
        {
            if (!keyValuePairs.ContainsKey(key)
                || !keyValuePairs[key].Contains(value))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public IEnumerable<KeyValuePair<K, V>> Items()
        {
            var items = new List<KeyValuePair<K, V>>();
            foreach (var item in keyValuePairs)
            {
                var tVal = keyValuePairs[item.Key];
                foreach (var val in tVal)
                {
                    items.Add(new KeyValuePair<K, V>(item.Key, val));
                }
            }

            return items;
        }

        public IEnumerable<K> Keys()
        {
            return keyValuePairs.Keys;
        }

        public bool Remove(K key, V value)
        {
            if (keyValuePairs.ContainsKey(key)
                && keyValuePairs[key].Contains(value))
            {
                keyValuePairs[key].Remove(value);

                if (!(keyValuePairs[key].Count > 0))
                {
                    keyValuePairs.Remove(key);
                }

                return true;
            }
            return false;
        }

        public bool RemoveAll(K key)
        {
            if (keyValuePairs.ContainsKey(key))
            {
                keyValuePairs[key].Clear();

                keyValuePairs.Remove(key);

                return true;
            }
            return false;
        }

        public IEnumerable<V> Values()
        {
            var tValues = keyValuePairs.Values;

            var listValues = new List<V>();

            foreach (var items in tValues)
            {
                foreach (var item in items)
                {
                    listValues.Add(item);
                }
            }

            return listValues;
        }

        public IEnumerator<KeyValuePair<K, V>> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

    }
}
