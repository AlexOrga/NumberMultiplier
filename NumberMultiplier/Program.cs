using System;

namespace NumberMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a comma separated string of numbers");
            var userInput = Console.ReadLine();
            var userInputArray = userInput.Split(",");

            Console.WriteLine("Multiply these values or square each one individually? Enter 'multiply' or 'square' and then press the Enter key.");
            string multOrSquare = Console.ReadLine();

            if (multOrSquare == "multiply")
            {
                int numberBank = 0;

                for (int i = 0; i < userInputArray.Length; i++)
                {
                    int currentNumber = int.Parse(userInputArray[i]);
                    if (i == 0)
                    {
                        numberBank = currentNumber;
                    }
                    else
                    {
                        numberBank = numberBank * currentNumber;
                    }
                }
                Console.WriteLine(numberBank);
            }
            else if (multOrSquare == "square")
            {
                string stringToReturn = "";
                for (int i = 0; i < userInputArray.Length; i++)
                {
                    int currentNumber = int.Parse(userInputArray[i]);
                    int squaredCurrent = currentNumber * currentNumber;
                    stringToReturn += squaredCurrent.ToString();

                    if((i + 1) < userInputArray.Length)
                    {
                        stringToReturn += ",";
                    }
                }

                Console.WriteLine(stringToReturn);
            }
            else
            {
                Console.WriteLine("You had 1 job and you screwed it up!!");
            }

            Console.WriteLine("Press Enter to Exit");
            Console.ReadLine();
        }
    }
}
