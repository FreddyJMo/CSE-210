using System;

public class Activity
{
    private string _startActivity, _description, endActivity, _nameActivity;
    private int _numSectoRun, _counter, _duration;

    public Activity(string nameActivity, string startActivity, string description, string endActivity, int counter, int duration)
    {
        _startActivity = startActivity;
        _description = description;
        _endActivity = endActivity;
        _counter = counter;
        _duration = duration;
        _nameActivity = nameActivity;

        Activity a1 = new Activity("Breathing", "Start info", "Description");
    }

    public string GetActivityName()
    {
        return _nameActivity;
    }
    public string StartingMessage(string nameActivity, string description): base()
    {
        Console.WriteLine($"This activity is the {_nameActivity}. {_description}");
        Console.WriteLine($"How many seconds would you like to do the {_nameActivity} for?");
        Console.Write();
    }
    public string EndingMessage()
    {
        //return
    }

    public void Spinner(int numSecondsToRun)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        while (stopwatch.EllapsedMillisecond / 1000 < numSecondsToRun)
        {
            spinnerCounter++;
            switch(spinnerCounter %4 )
            {
                case 0 : Console.Write("/"); break;
                case 1 : Console.Write("-"); break;
                case 2 : Console.Write("\\"); break;
                case 3 : Console.Write("|"); break;
            }
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            Thread.Sleep(200);
        }
        Console.Write("");
    }
    public void CountDown(int numSecondsToRun)
    {
        for (int i = 1; i <= numSecondsToRun; i++)
        {
            Console.Write(string.Format("You may begin in {0}", i));
            Console.SetCursorPosition(0, Console.CursorTop);
            Thread.Sleep(1000);
        }
    }

}