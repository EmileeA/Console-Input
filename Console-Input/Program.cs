using System;

namespace Accepting_User_Input
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.Read
            var key = Console.Read();
            char keyChar = Convert.ToChar(key);
            Console.WriteLine(keyChar);

            // Coneole.ReadKey
            ConsoleKeyInfo enteredKey;
            do
            {
                enteredKey = Console.ReadKey();
                Console.WriteLine($"You pressed the {enteredKey.Key.ToString()} key");
            } while (enteredKey.Key != ConsoleKey.Escape);

            // Console.ReadLine
            string sentence;

            do
            {
                Console.WriteLine("Type in a sentence ('quit' to exit). Press enter when done.");
                sentence = Console.ReadLine();
                Console.WriteLine($"You entered the sentence: {sentence}");
            } while (sentence != "quit");

            Console.ReadKey();
        }
    }
}