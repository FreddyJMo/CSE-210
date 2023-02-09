using System;

public class Goals
{
    // Class attributes
    protected string _name, _description, _achievement, _type;
    protected int _points, _awardedPoints;
    protected bool _completed;

    // Constructor
    public Goals(string type, string name, string description, int points)
    {
        _type = type;
        _name = name;
        _description = description;
        _points = points;
        _achievement = "";
        _awardedPoints = 0;
        _completed = false;
    }

    public string GetGoalType()
    {
        return _type;
    }

    public string GetName()
    {
        return _name;
    }
    public void SetName(string name)
    {
        _name = name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public int GetPoints()
    {
        return _points;
    }

    public void SetPoints(int points)
    {
        _points = points;
    }

    public string GetAchievement()
    {
        return _achievement;
    }

    public void SetAchievement(string achievement)
    {
        _achievement = achievement;
    }

    public virtual void SetCompleted(bool completed)
    {
        _completed = completed;
    }

    public virtual string MakeDescription(int goalIndex, bool saveToFile)
    {
        string checkmark = "";

        if (saveToFile)
        {
            return $"{goalIndex}. | {_type} | {_name} | {_description} | {_points} | {_completed}";
        }

        if (_completed && _type != "Eternal")
        {
            checkmark = "x";
        }

        return $"{goalIndex}. [{checkmark}] {_name} ({_description})\n";
    }

}