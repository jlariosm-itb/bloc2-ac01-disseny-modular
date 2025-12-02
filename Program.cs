using System;

public class Program
{
    const string CostMessage = "Parking cost: ";
    const string HourPrompt = "Please enter the hours you parked: ";
    const string MinutePrompt = "Please enter the minutes you parked: ";
    const string InvalidInputMessage = "Invalid input. Please enter valid hours and minutes.";
    const double FirstHourRate = 3.50;
    const double SecondToFifthHourRate = 2.00;
    const double SixthHourOnwardRate = 1.50;

    public static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        int hours = 0;
        int minutes = 0;

        Console.Write(HourPrompt);
        while (!int.TryParse(Console.ReadLine(), out hours) || hours < 0)
        {
            Console.WriteLine(InvalidInputMessage);
            Console.Write(HourPrompt);
        }

        Console.Write(MinutePrompt);
        while (!int.TryParse(Console.ReadLine(), out minutes) || minutes < 0 || minutes >= 60)
        {
            Console.WriteLine(InvalidInputMessage);
            Console.Write(MinutePrompt);
        }

        double totalCost = CalculateParkingCost(hours, minutes);

        Console.WriteLine(CostMessage + totalCost + "€");
    }

    public static double CalculateParkingCost(int hours, int minutes)
    {
        double totalCost = 0;
        double additionalHours = minutes / 60.0;
        double totalHours = hours + additionalHours;

        if (totalHours <= 1)
        {
            totalCost = FirstHourRate;
        }
        else if (totalHours <= 5)
        {
            totalCost = FirstHourRate + (totalHours - 1) * SecondToFifthHourRate;
        }
        else
        {
            totalCost = FirstHourRate + (4 * SecondToFifthHourRate) + (totalHours - 5) * SixthHourOnwardRate;
        }

        return Math.Round(totalCost, 2);
    }
}
