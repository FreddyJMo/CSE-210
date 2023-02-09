using System;

public class ListingActivity : Activity
{
    public string _listingPrompt, _responsePrompt = "";

    public void RunListing()
    {
        //Display start message
    }
    public void ProvidePrompt()
    {
        Random rnd = new Random();
        List<string> prompts = new List<string>();
        prompts.Add("Who are people that you appreciate?");
        prompts.Add("What are personal strenghts of yours?");
        prompts.Add("Who are people that you have helped this week?");
        prompts.Add("When have you felt the Holy Ghost this month?");
        prompts.Add("Who are some of your personal heroes?");

        int index = rnd.Next(0,4);
        Console.WriteLine(prompts[index]);
        _listingPrompt = prompts[index];
    }
    public void EnterResponse()
    {
        _responsePrompt = Console.ReadLine();
    }

    public int ListAndCount()
    {
        //Count method
    }

}