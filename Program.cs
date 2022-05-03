using System;

namespace PA1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string  outputPassword = PasswordScrambler();
            Console.WriteLine($"Your new password is {outputPassword}.");
        }
        static string PasswordScrambler()
        {
            Console.WriteLine("What is your current password?");
            string userInput = Console.ReadLine();
            char[] temp = new char[99];
            temp = userInput.ToCharArray();
            Console.WriteLine("How many characters long is your password?");
            int stringLength = int.Parse(Console.ReadLine());
            char currLetter = temp[0];
            string outputPassword = "";
            int count = 1;
            int loopCount = 1;
            while (loopCount < stringLength)
            {
                if (currLetter == temp[loopCount])
                {
                    count++;
                    loopCount++;
                }
                else
                {
                    outputPassword += count.ToString();
                    outputPassword += currLetter;
                    currLetter = temp[loopCount];
                    count = 1;
                    loopCount++;
                }
            }
            outputPassword += count.ToString();
            outputPassword += currLetter;
            return outputPassword;
        }
    }
}
