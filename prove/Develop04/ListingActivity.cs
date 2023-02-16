using System;

public class ListingActivity : Activity
{

    public const int listingDuration = 5;
    private string _prompt;
    protected List<string> _promptsList = new List<string> {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base()
    {
        _name = "Listing Activity";
        _startMessage = $"Welcome to the {_name} activity"
        + "\n\nThis activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public string GetPrompt()
    {
        return _prompt;
    }

    public void GenerateRandomPrompt()
    {
        Random randomPrompt = new Random();
        int chosenPromptIndex = randomPrompt.Next(5);
        _prompt = _promptsList[chosenPromptIndex];
    }

}