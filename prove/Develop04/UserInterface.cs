using System;
using System.Diagnostics;

public class UserInterface
{
    private string _activityName;
    private int _activityDuration;
    BreathingActivity breathing = new BreathingActivity();
    public UserInterface(){}
    public void DisplayMenu()
    {
        Console.WriteLine("Menu Options: ");
        List<string> activitiesMenu = new List<string>()
        { "Breathing", "Reflection", "Listing", "Quit" };

        for (int i = 0; i < activitiesMenu.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {activitiesMenu[i]}");
        }
    }

    public int GetActivityDuration()
    {
        return _activityDuration;
    }

    public void ChooseMenuOption(
        string breathingName,  string breathingStartMessage, string reflectionName, string reflectionStartMessage, string reflectionPrompt, string reflectionQuestion, string listingName, string listingStartMessage, string listingPrompt
        
        
    )
    {
        string chosenOption = "";
        while (chosenOption != "4")
        {
            DisplayMenu();
            Console.Write("Select choice from the menu: ");
            chosenOption = Console.ReadLine();
            switch (chosenOption)
            {
                case "1":
                    _activityName = breathingName;
                    DisplayBreathingActivity(breathingStartMessage);
                    break;
                case "2":
                    _activityName = reflectionName;
                    DisplayReflectionActivity(reflectionStartMessage, reflectionPrompt, reflectionQuestion);
                    break;
                case "3":
                    _activityName = listingName;
                    DisplayListingActivity(listingStartMessage, listingPrompt);
                    break;
                case "4":
                    Console.WriteLine("Thank you for using our program.");
                    break;
            }
        }
    }

    public void DisplayStartingMessage(string startMessage)
    {
        Console.WriteLine($"\n{startMessage}");
        Console.Write("\nHow long, in seconds, would you like for your session? ");
        _activityDuration = int.Parse(Console.ReadLine());
    }

    public void DisplayBreathingActivity(string breathingStartMessage)
    {
        DisplayStartingMessage(breathingStartMessage);
        Console.Clear();
        Console.WriteLine($"{Activity.preparationMessage}");
        DisplaySpinner(Activity.spinnerDuration);

        DateTime currentTime = DateTime.Now;
        DateTime breathingDuration = currentTime.AddSeconds(_activityDuration);


        while (currentTime < breathingDuration)
        {
            Console.Write($"\n\n{BreathingActivity.breatheInMessage}");
            DisplayCountDown(BreathingActivity.breatheInDuration);
            Console.Write($"\n{BreathingActivity.breatheOutMessage}");
            DisplayCountDown(BreathingActivity.breatheOutDuration);
            currentTime = DateTime.Now;
        }
        DisplayEndingMessage();
    }

    public void DisplayReflectionActivity(string reflectionStartMessage, string prompt, string question)
    {
        DisplayStartingMessage(reflectionStartMessage);
        Console.Clear();
        Console.WriteLine($"{Activity.preparationMessage}");
        DisplaySpinner(Activity.spinnerDuration);
        Console.WriteLine("\nConsider the following prompt:"
        + $"\n\n--- {prompt} ---"
        + "\n\nWhen you have something in mind, press enter to continue.");

        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        DisplayCountDown(ReflectionActivity.reflectionDuration);
        Console.Clear();
        Console.Write(question + " ");
        DisplaySpinner(Activity.spinnerDuration);
        DisplayEndingMessage();
    }

    public void DisplayListingActivity(string listingStartMessage, string prompt)
    {
        DisplayStartingMessage(listingStartMessage);
        Console.Clear();
        Console.WriteLine($"{Activity.preparationMessage}");
        DisplaySpinner(Activity.spinnerDuration);
        Console.WriteLine("\nList as many responses you can to the following prompt:"
        + $"\n--- {prompt} ---");
        Console.Write("You may begin in: ");
        DisplayCountDown(ReflectionActivity.reflectionDuration);
        DisplayUserEntryList();
        DisplayEndingMessage();
    }

    public void DisplayUserEntryList()
    {
        DateTime currentTime = DateTime.Now;
        DateTime listingDuration = currentTime.AddSeconds(_activityDuration);

        int activitiesCounter = 0;
        Console.WriteLine();

        while (currentTime < listingDuration)
        {
            Console.Write("> ");
            Console.ReadLine();
            ++activitiesCounter;
            currentTime = DateTime.Now;
        }

        Console.WriteLine($"You listed {activitiesCounter} items");
    }

    public void DisplaySpinner(int numSecondsToRun)
    {
        int spinnerCounter = 0;
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        while (stopwatch.ElapsedMilliseconds / 1000 < numSecondsToRun)
        {
            spinnerCounter++;
            switch (spinnerCounter % 4)
            {
                case 0: Console.Write("/"); break;
                case 1: Console.Write("-"); break;
                case 2: Console.Write("\\"); break;
                case 3: Console.Write("|"); break;
            }
            Console.Write("\b");
            Thread.Sleep(200);
        }
        Console.Write(" ");
    }

    public void DisplayCountDown(int countDownDuration)
    {
        Console.Write(" ");
        for (int i = countDownDuration; i > 0; i--)
        {
            Console.Write("\b" + i);
            Thread.Sleep(1000);
        }
        Console.Write("\b ");
    }

    public void DisplayEndingMessage()
    {
        const int spinnerDuration = 4;
        Console.WriteLine($"\n\n{Activity.wellDoneMessage}");
        DisplaySpinner(spinnerDuration);
        Console.WriteLine($"\nYou have completed another {_activityDuration} seconds of the {_activityName} Activity.");
        DisplaySpinner(spinnerDuration);
        Console.Clear();
    }
}