using System;

public class BreathingActivity : Activity
{
    public string _inMessage, _outMessage = "";

    public void RunBreathing(string inMessage, string outMessage) : base(nameActivity, description)
    {
    Console.WriteLine("Breathing Activity");
    Activity.StartingMessage("Breathing", "This activity will help you relax by walking through breathing in and out");
    } 

    public void BreathingExercise(): base(numSecondsToRun)
    {
        Console.WriteLine("Breathe In");
        Activity.CountDown(int numSecondsToRun);
        Console.WriteLine("Breathe Out");
    }

}