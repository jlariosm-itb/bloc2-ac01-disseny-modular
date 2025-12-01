using System;

public class Program
{
    public static void Main()
    {
       //Constants
        const string NumberOne = "Input a number please:";
        const string MinRange = "Enter the minimun number of the range:";
        const string MaxRange = "Enter the maximun number of the range:";
        const string InvalidInput = "Invalid input please try again...";
        const string ValidRange = "The number is in range.";
        const string InvalidRange = "The number isn't in range.";


        //Variables
        int num = 0, minRange = 0, maxRange = 0;

        try
        {
            num = ValidNumberInput(NumberOne);
            minRange = ValidNumberInput(MinRange);
            maxRange = ValidNumberInput(MaxRange);
        }
        catch (FormatException)
        {
            Console.WriteLine(InvalidInput);
        }

        if (NumberInRange(num, minRange, maxRange))
        {
            Console.WriteLine(ValidRange);
        }
        else
        {
            Console.WriteLine(InvalidRange);
        }
    }

    public static int ValidNumberInput(string text)
    {
        int num;
        do { 
            Console.WriteLine(text);
        }while (!Int32.TryParse(Console.ReadLine(), out num));
        return num;
    }

    public static bool NumberInRange(int num, int minRange, int maxRange)
    {
        
        if (num < maxRange && num > minRange)
        {
            return true;
        }
        else
        {
            return false;
        }
        
    }
}

