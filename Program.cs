using System;

public class Program
{
    public static void Main()
    {
        //Constants
        const string TempUser = "Please dear user input a decimal temperature: ";
        const string ConverUser = "What type of convertion do you want to do:";
        const string InputErrorMessage = "Invalid input. Please enter a number between 0 and 3.";
        const string CelFar = "{0} degrees Celsius is {1} degrees Fahrenheit.";
        const string FarCel = "{0} degrees Fahrenheit is {1} degrees Celsius.";
        const string Kevin = "{0} degrees Celsius is {1} degrees Kelvin.";
        const string TriesExcd = "Too many invalid attempts. Exiting program.";


        //Variables
        string[] Menu = { "1: Celsius to Fahrenheit", "2: Fahrenheit to Celsius", "3: Celsius to Kelvin", "0: Exit" };
        double temp = 0, op = 0;
        bool validInput;
        int tries = 0;

        //Program
        Console.WriteLine(TempUser);
        temp = Convert.ToDouble(Console.ReadLine()); //Hector the maginificant helped me with the use of convert.
        Console.WriteLine(ConverUser);
        MenuFunction(Menu);
        do
        {
            
            validInput = true;
            try
            {
                op = Convert.ToInt32(Console.ReadLine());
                if (op < 0 || op > 3)
                {
                    Console.WriteLine(InputErrorMessage);
                    validInput = false;
                    tries++;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine(InputErrorMessage);
                validInput = false;
                tries++;
            }
            catch (Exception)
            {
                Console.WriteLine(InputErrorMessage);
                validInput = false;
                tries ++;
            }

            if (validInput)
            {
                Console.WriteLine();
            }

            switch (op)
            {
                case 1:
                    FunCelFar(CelFar, temp);
                    break;
                case 2:
                    FunFarCel(FarCel, temp);
                    break;
                case 3:
                    FunKal(Kevin, temp);
                    break;
            }
        } while (op != 0 && tries < 3);

        if (tries >= 3)
        {
            Console.WriteLine(TriesExcd);
        }

        static void MenuFunction(string[] Menu)
        {
            for (int i = 0; i < Menu.Length; i++)
            {
                Console.WriteLine(Menu[i]);
            }
        }

        static void FunCelFar(string CelFar, double temp)
        {
            double fahr = 0;
            fahr = (temp * 9 / 5) + 32;
            Console.WriteLine(CelFar, temp, fahr);
        }

        static void FunFarCel(string FarCel, double temp)
        {
            double cel = 0;
            cel = ((temp - 32) * (5 / 9));
            Console.WriteLine(FarCel, temp, cel);
        }

        static void FunKal(string Kevin, double temp)
        {
            double kel = 0;
            kel = temp + 273.15;
            Console.WriteLine(Kevin, temp, kel);
        }
    }

}

