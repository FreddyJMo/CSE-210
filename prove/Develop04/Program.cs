using System;

public class Program
{
    static void Main(string[] args)
    {
        Activity activity = new Activity();
        int _choice = 0;
        while (_choice != 4)
        {
            //User Menu
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine("Select a choice from the menu");
            _choice = int.Parse(Console.ReadLine());

            switch (_choice)
            {
                case 1:
                    //Breathing Activity
                    activity.RunBreathingActivity();
                    break;
                case 2:
                    //Reflection Activity
                    activity.RunReflectionActivity();
                    break;
                case 3:
                    //Listing Activity
                    activity.RunListingActivity();
                    break;
                case 4:
                    //End program
                    Console.WriteLine("Thanks for participating. Have a mindful day.");
                    break;
            }
        }
    }
}