using System;

public class Activity
{
    protected string _startMessage, _name;
    protected int _duration;
    protected bool _completed;
    public const string wellDoneMessage = "Well Done!!";
    public const string preparationMessage = "Get Ready...";
    public const int spinnerDuration = 5;

    public Activity()
    {
        _duration = 0;
        _completed = false;
    }

    public string GetStartMessage()
    {
        return _startMessage;
    }
    
    public void SetStartMessage(string startMessage)
    {
        _startMessage = startMessage;
    }

    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    public bool Completed()
    {
        return _completed;
    }
    public void SetCompleted(bool completed)
    {
        _completed = completed;
    }

}