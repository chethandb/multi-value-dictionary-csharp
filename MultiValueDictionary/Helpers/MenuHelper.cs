using System;
using static MultiValueDictionary.Helpers.OperationsHelper;

namespace MultiValueDictionary.Helpers
{
    public static class MenuHelper
    {
        public static void DisplayMenu()
        {
            // Display MENU           
            Console.WriteLine("---------------------------------------------------------------------------------------");
            Console.WriteLine("\tMultiValueDictionary Console Application in C#\r");
            Console.WriteLine("\tChoose an operation from the following menu:");
            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.WriteLine("\t\t\tMENU");
            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.WriteLine($"\n=> {nameof(Operations.ADD)} \n {OperationDescriptions(Operations.ADD)}");
            Console.WriteLine($"\n=> {nameof(Operations.REMOVE)} \n {OperationDescriptions(Operations.REMOVE)}");
            Console.WriteLine($"\n=> {nameof(Operations.REMOVEALL)} \n {OperationDescriptions(Operations.REMOVEALL)}");
            Console.WriteLine($"\n=> {nameof(Operations.CLEAR)} \n {OperationDescriptions(Operations.CLEAR)}");
            Console.WriteLine($"\n=> {nameof(Operations.KEYEXISTS)} \n {OperationDescriptions(Operations.KEYEXISTS)}");
            Console.WriteLine($"\n=> {nameof(Operations.VALUEEXISTS)} \n {OperationDescriptions(Operations.VALUEEXISTS)}");
            Console.WriteLine($"\n=> {nameof(Operations.KEYS)} \n {OperationDescriptions(Operations.KEYS)}");
            Console.WriteLine($"\n=> {nameof(Operations.MEMBERS)} \n {OperationDescriptions(Operations.MEMBERS)}");
            Console.WriteLine($"\n=> {nameof(Operations.ALLMEMBERS)} \n {OperationDescriptions(Operations.ALLMEMBERS)}");
            Console.WriteLine($"\n=> {nameof(Operations.ITEMS)} \n {OperationDescriptions(Operations.ITEMS)}\n");
            Console.WriteLine("---------------------------------------------------------------------------------------");
            Console.Write(" Pick your option and pass corresponding arguments, delimited by spaces!!");
            Console.Write("\n=> Example: To add a member to a collection for a given key: \n > ADD foo bar \n");
            Console.Write("\n=> To Quit terminal: Type 'exit' and Enter to close the app, \n or supply relevant arguments to continue interacting with the program..");
            Console.WriteLine("\n---------------------------------------------------------------------------------------\n");
        }
    }
}
