using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.ViewModels
{
    public class Pair<K, V>
    {
        public K Key { get; set; }
        public V Value { get; set; }

        public Pair()
        {
        }

        public Pair(K key, V value)
        {
            Key = key;
            Value = value;
        }
    }
}
