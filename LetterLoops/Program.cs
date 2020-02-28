using System;

namespace LetterLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            var finalString = "";

            Console.WriteLine("Enter a random string:");
            var userEntry = Console.ReadLine();

            for (int i = 1; i <= userEntry.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {                           
                    if (j == 0)
                    {
                        var upperString = userEntry.ToUpper();
                        finalString += upperString[i - 1];
                    }
                    else
                    finalString += userEntry[i-1];
                }
                if (i != userEntry.Length)
                {
                    finalString += "-";
                }
            }

            Console.WriteLine($"Output is: {finalString}");
            Console.ReadLine();
        }
    }
}
