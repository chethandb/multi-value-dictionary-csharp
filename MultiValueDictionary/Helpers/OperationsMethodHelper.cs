using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechInterviewOne.Solution;
using static MultiValueDictionary.Helpers.OperationsHelper;

namespace MultiValueDictionary.Helpers
{
    public static class OperationsMethodHelper
    {
        /// <summary>
        /// Evaluates the selected operation and takes action
        /// </summary>
        /// <param name="multiValueDictionary"></param>
        /// <param name="inputWords"></param>
        public static void EvaluateSelectedOperation(MultiValueDictionary<string, string> multiValueDictionary, string[] inputWords)
        {
            switch (inputWords[0].ToUpper().Trim())
            {
                case nameof(Operations.ADD):
                    Add(multiValueDictionary, inputWords);
                    break;

                case nameof(Operations.REMOVE):
                    Remove(multiValueDictionary, inputWords);
                    break;

                case nameof(Operations.REMOVEALL):
                    RemoveAll(multiValueDictionary, inputWords);
                    break;

                case nameof(Operations.CLEAR):
                    Clear(multiValueDictionary);
                    break;

                case nameof(Operations.KEYS):
                    Keys(multiValueDictionary);
                    break;

                case nameof(Operations.KEYEXISTS):
                    KeyExists(multiValueDictionary, inputWords);
                    break;

                case nameof(Operations.VALUEEXISTS):
                    ValueExists(multiValueDictionary, inputWords);
                    break;

                case nameof(Operations.MEMBERS):
                    Members(multiValueDictionary, inputWords);
                    break;

                case nameof(Operations.ALLMEMBERS):
                    AllMembers(multiValueDictionary);
                    break;

                case nameof(Operations.ITEMS):
                    Items(multiValueDictionary);
                    break;

                default:
                    Console.WriteLine(MessageStringsHelper.INVALID_INPUT);
                    break;
            }
        }

        /// <summary>
        /// ITEMS
        /// Returns all keys in the dictionary and all of their values.Returns nothing if there are none.Order is not guaranteed.
        /// </summary>
        /// <param name="multiValueDictionary"></param>
        public static void Items(MultiValueDictionary<string, string> multiValueDictionary)
        {
            var itemsResult = multiValueDictionary.Items();
            if (itemsResult.Count() < 1)
            {
                Console.WriteLine(MessageStringsHelper.EMPTY_SET);
            }
            DisplayKeyValueItems(itemsResult);
        }

        /// <summary>
        /// ALLMEMBERS
        /// Returns all the values in the dictionary.Returns nothing if there are none.Order is not guaranteed.
        /// </summary>
        /// <param name="multiValueDictionary"></param>
        public static void AllMembers(MultiValueDictionary<string, string> multiValueDictionary)
        {
            var allMembersResult = multiValueDictionary.Values();
            if (allMembersResult.Count() < 1)
            {
                Console.WriteLine(MessageStringsHelper.EMPTY_SET);
            }
            else
            {
                DisplayItems(allMembersResult);
            }
        }

        /// <summary>
        /// MEMBERS
        /// Returns the collection of strings for the given key.Return order is not guaranteed.Returns an error if the key does not exists.
        /// </summary>
        /// <param name="multiValueDictionary"></param>
        /// <param name="inputWords"></param>
        public static void Members(MultiValueDictionary<string, string> multiValueDictionary, string[] inputWords)
        {
            var membersResult = multiValueDictionary[inputWords[1]];
            DisplayItems(membersResult);
        }

        /// <summary>
        /// VALUEEXISTS
        /// Returns whether a value exists within a key.Returns false if the key does not exist.
        /// </summary>
        /// <param name="multiValueDictionary"></param>
        /// <param name="inputWords"></param>
        public static void ValueExists(MultiValueDictionary<string, string> multiValueDictionary, string[] inputWords)
        {
            Console.WriteLine(multiValueDictionary.ContainsValue(inputWords[1], inputWords[2]));
        }

        /// <summary>
        /// KEYEXISTS
        /// Returns whether a key exists or not.
        /// </summary>
        /// <param name="multiValueDictionary"></param>
        /// <param name="inputWords"></param>
        public static void KeyExists(MultiValueDictionary<string, string> multiValueDictionary, string[] inputWords)
        {
            Console.WriteLine(multiValueDictionary.ContainsKey(inputWords[1]));
        }

        /// <summary>
        /// KEYS
        /// Returns all the keys in the dictionary.Order is not guaranteed.
        /// </summary>
        /// <param name="multiValueDictionary"></param>
        public static void Keys(MultiValueDictionary<string, string> multiValueDictionary)
        {
            var keysResult = multiValueDictionary.Keys();
            if (keysResult.Count() < 1)
            {
                Console.WriteLine(MessageStringsHelper.EMPTY_SET);
            }
            else
            {
                DisplayItems(keysResult);
            }
        }

        /// <summary>
        /// CLEAR
        /// Removes all keys and all values from the dictionary.
        /// </summary>
        /// <param name="multiValueDictionary"></param>
        public static void Clear(MultiValueDictionary<string, string> multiValueDictionary)
        {
            multiValueDictionary.Clear();
            Console.WriteLine(MessageStringsHelper.CLEARED);
        }

        /// <summary>
        /// REMOVEALL
        /// Removes all value for a key and removes the key from the dictionary.Returns an error if the key does not exist.
        /// </summary>
        /// <param name="multiValueDictionary"></param>
        /// <param name="inputWords"></param>
        public static void RemoveAll(MultiValueDictionary<string, string> multiValueDictionary, string[] inputWords)
        {
            var removeAllResult = multiValueDictionary.RemoveAll(inputWords[1]);
            if (removeAllResult)
            {
                Console.WriteLine(MessageStringsHelper.REMOVED);
            }
            else
            {
                Console.WriteLine(MessageStringsHelper.ERROR_KEY_DO_NOT_EXIST);
            }
        }

        /// <summary>
        /// REMOVE
        /// Removes a value from a key.If the last value is removed from the key, they key is removed from the dictionary. If the key or value does not exist, displays an error.
        /// </summary>
        /// <param name="multiValueDictionary"></param>
        /// <param name="inputWords"></param>
        public static void Remove(MultiValueDictionary<string, string> multiValueDictionary, string[] inputWords)
        {
            if (!multiValueDictionary.ContainsKey(inputWords[1]))
            {
                Console.WriteLine(MessageStringsHelper.ERROR_KEY_DO_NOT_EXIST);
            }
            else
            {
                var removeResult = multiValueDictionary.Remove(inputWords[1], inputWords[2]);

                if (removeResult)
                {
                    Console.WriteLine(MessageStringsHelper.REMOVED);
                }
                else
                {
                    Console.WriteLine(MessageStringsHelper.ERROR_VALUE_DO_NOT_EXIST);
                }
            }
        }

        /// <summary>
        /// ADD
        /// Add a member to a collection for a given key.Displays an error if the value already existed in the collection.
        /// </summary>
        /// <param name="multiValueDictionary"></param>
        /// <param name="inputWords"></param>
        public static void Add(MultiValueDictionary<string, string> multiValueDictionary, string[] inputWords)
        {
            var addResult = multiValueDictionary.Add(inputWords[1], inputWords[2]);
            if (addResult != null)
            {
                Console.WriteLine(MessageStringsHelper.ADDED);
            }
        }

        /// <summary>
        /// Displays items to console
        /// </summary>
        /// <param name="itemsToDisplay"></param>
        public static void DisplayItems(IEnumerable<string> itemsToDisplay)
        {
            int count = 0;
            foreach (var item in itemsToDisplay)
            {
                Console.WriteLine($"{++count}) {item}");
            }
        }

        /// <summary>
        /// Displays key-value pairs to console
        /// </summary>
        /// <param name="keyValuePairs"></param>
        public static void DisplayKeyValueItems(IEnumerable<KeyValuePair<string, string>> keyValuePairs)
        {
            int count = 0;
            foreach (var item in keyValuePairs)
            {
                Console.WriteLine($"{++count}) {item.Key}: {item.Value}");
            }
        }
    }
}
