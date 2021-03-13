using System;
using TechInterviewOne.Problem1;

namespace TechInterviewOne.Problem2
{
    public static class MultiValueDictionaryExtensions
    {
        public static IMultiValueDictionary<K, V> Union<K, V>(this IMultiValueDictionary<K, V> first, IMultiValueDictionary<K, V> second)
        {
            // INSTRUCTIONS :
            // * Return all items from "first" and "second" in a new Multivalue Dictionary

            throw new NotImplementedException();
        }

        public static IMultiValueDictionary<K, V> Intersection<K, V>(this IMultiValueDictionary<K, V> first, IMultiValueDictionary<K, V> second)
        {
            // INSTRUCTIONS :
            // * Return only the items that exist in BOTH "first" and "second" in a new Multivalue Dictionary

            throw new NotImplementedException();
        }

        public static IMultiValueDictionary<K, V> Except<K, V>(this IMultiValueDictionary<K, V> first, IMultiValueDictionary<K, V> second)
        {
            // INSTRUCTIONS :
            // Return the items that exist in "first" but NOT in "second"

            throw new NotImplementedException();
        }

        public static IMultiValueDictionary<K, V> Distinct<K, V>(this IMultiValueDictionary<K, V> first, IMultiValueDictionary<K, V> second)
        {
            // INSTRUCTIONS :
            // Return only the items that exist in "first" OR "second", but not both

            throw new NotImplementedException();
        }
    }
}
