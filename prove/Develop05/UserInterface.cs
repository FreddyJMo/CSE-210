using System;

public class UserInterface
{
    private string _chosenGoalTypeChoice;
    private List<object> _currentGoalDetailsList;

    public UserInterface()
    {
        _currentGoalDetailsList = new List<object>();
    }

    public string GetGoalChosenGoalType()
    {
        return _chosenGoalTypeChoice;
    }

    public List<object> GetGoalDetailsList()
    {
        return _currentGoalDetailsList;
    }

    public void DisplayScore(int awardedPoints)
    {
        Console.WriteLine($"\nYou have {awardedPoints} points.");
    }

    public void DisplayMenu()
    {
        Console.WriteLine("\nMenu Options:");
        List<string> MainMenu = new List<string>()
        { "Create New Goal", "List Goals", "Save Goals", "Load Goals", "Record Event", "Quit" };

        for (int i = 0; i < MainMenu.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {MainMenu[i]}");
        }
    }

    public string ChooseMenuOption()
    {
        string chosenOption = "";

        DisplayMenu();
        Console.Write("Select a choice from the menu: ");
        chosenOption = Console.ReadLine();

        return chosenOption;
    }

    public void ChooseGoalType()
    {
        List<string> GoalTypeMenu = new List<string>()
        { "Simple Goal", "Eternal Goal", "Checklist Goal"};

        Console.WriteLine("The types of goals are:");

        for (int i = 0; i < GoalTypeMenu.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {GoalTypeMenu[i]}");
        }

        _currentGoalDetailsList = new List<object>();
        Console.Write("Which type of goal would you like to create? ");
        _chosenGoalTypeChoice = Console.ReadLine();
        _currentGoalDetailsList.Add(_chosenGoalTypeChoice);
        if (!ValidateGoalDetails())
        {
            Console.WriteLine("Invalid goal type choice: please enter 1-3.");
            return;
        }

        ReadGoalDetails();
    }

    public bool ValidateGoalDetails()
    {
        if (!_chosenGoalTypeChoice.Contains("1")
            && !_chosenGoalTypeChoice.Contains("2")
            && !_chosenGoalTypeChoice.Contains("3"))
        {
            Console.WriteLine("Invalid entry: please enter the correct menu option.");
            return false;
        }

        return true;
    }

    public void ReadGoalDetails()
    {
        int numberOfTimes = 0;
        int bonusPoints = 0;

        Console.Write("What is the name of the goal? ");
        string name = Console.ReadLine();
        _currentGoalDetailsList.Add(name);
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        _currentGoalDetailsList.Add(description);
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());
        _currentGoalDetailsList.Add(points);

        if (_chosenGoalTypeChoice == "3")
        {
            Console.Write("How many times this goal need to be accomplished for a bonus? ");
            numberOfTimes = int.Parse(Console.ReadLine());
            _currentGoalDetailsList.Add(numberOfTimes);
            Console.Write("What is the bonus for accomplishing it that many times? ");
            bonusPoints = int.Parse(Console.ReadLine());
            _currentGoalDetailsList.Add(bonusPoints);
        }
    }

    public void DisplayGoal(int goalIndex, string goalType, string goalDescription)
    {
        string[] goalDescriptionList = goalDescription.Split("\n");
        Console.Write($"{goalDescriptionList[0]}");
        if (goalType == "Checklist")
        {
            Console.Write($" -- Currently completed: {goalDescriptionList[1]}");
        }

        Console.WriteLine();
    }

    public string ReadFileName(bool save)
    {
        Console.Write("What is the file name for the goal file? ");
        string fileName = Console.ReadLine();
        string process = save ? "sav" : "load";
        Console.WriteLine($"{fileName} has been {process}ed");
        return fileName;
    }

}