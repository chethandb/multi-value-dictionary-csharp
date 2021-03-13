using MultiValueDictionary.Helpers;
using System;
using System.Collections.Generic;
using TechInterviewOne.Solution;

namespace MultiValueDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            bool endProgram = false;
            MultiValueDictionary<string, string> multiValueDictionary = new MultiValueDictionary<string, string>();

            // displays menu item for the console application
            MenuHelper.DisplayMenu();

            while (!endProgram)
            {
                Console.Write(MessageStringsHelper.CONSOLE_ARROW);
                string inputString = Console.ReadLine();

                try
                {
                    string[] inputWords = inputString.Split(' ');

                    // eleminate possibility of nulls or empty spaces
                    if (inputWords.Length >= 1
                        && !string.IsNullOrWhiteSpace(inputWords[0]))
                    {
                        OperationsMethodHelper.EvaluateSelectedOperation(multiValueDictionary, inputWords);
                    }                    
                }
                catch (InvalidOperationException)
                {
                    Console.WriteLine(MessageStringsHelper.ERROR_VALUE_EXIST);
                }
                catch (KeyNotFoundException)
                {
                    Console.WriteLine(MessageStringsHelper.ERROR_KEY_DO_NOT_EXIST);
                }
                catch (Exception e)
                {
                    Console.WriteLine(string.Format(MessageStringsHelper.ERROR_GENERAL, e.Message));
                }
                finally
                {
                    if (inputString.ToLower() == MessageStringsHelper.EXIT)
                    {

                        endProgram = true;
                    }
                }
            }
            return;
        }
    }
}
