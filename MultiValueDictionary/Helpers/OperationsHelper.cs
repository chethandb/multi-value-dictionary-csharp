using System;
using System.Collections.Generic;
using System.Text;

namespace MultiValueDictionary.Helpers
{
    public static class OperationsHelper
    {
        public static string OperationDescriptions(Operations operation)
        {
            string operationDesc = "";
            switch (operation)
            {
                case Operations.ADD:
                    operationDesc = "Add a member to a collection for a given key. \nDisplays an error if the value already existed in the collection.";
                    break;
                case Operations.REMOVE:
                    operationDesc = "Removes a value from a key.\n If the last value is removed from the key, they key is removed from the dictionary.\n If the key or value does not exist, displays an error.";
                    break;
                case Operations.REMOVEALL:
                    operationDesc = "Removes all value for a key and removes the key from the dictionary.\n Returns an error if the key does not exist.";
                    break;
                case Operations.CLEAR:
                    operationDesc = "Removes all keys and all values from the dictionary.";
                    break;
                case Operations.KEYEXISTS:
                    operationDesc = "Returns whether a key exists or not.";
                    break;
                case Operations.VALUEEXISTS:
                    operationDesc = "Returns whether a value exists within a key.\n Returns false if the key does not exist.";
                    break;
                case Operations.KEYS:
                    operationDesc = "Returns all the keys in the dictionary.\n Order is not guaranteed.";
                    break;
                case Operations.MEMBERS:
                    operationDesc = "Returns the collection of strings for the given key.\n Return order is not guaranteed.\n Returns an error if the key does not exists.";
                    break;
                case Operations.ALLMEMBERS:
                    operationDesc = "Returns all the values in the dictionary.\n Returns nothing if there are none.\n Order is not guaranteed.";
                    break;
                case Operations.ITEMS:
                    operationDesc = "Returns all keys in the dictionary and all of their values.\n Returns nothing if there are none.\n Order is not guaranteed.";
                    break;
            };

            return operationDesc;
        }

        public enum Operations
        {
            ADD = 1,
            REMOVE,
            REMOVEALL,
            CLEAR,
            KEYEXISTS,
            VALUEEXISTS,
            KEYS,
            MEMBERS,
            ALLMEMBERS,
            ITEMS
        }
    }
}
