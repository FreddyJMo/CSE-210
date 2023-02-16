using System;

public class ChecklistGoal : Goals
{
    protected int _actualNumberOfTimes, _numberOfTimes, _bonusPoints;

    public ChecklistGoal(string type, string name, string description, int points, int numberOfTimes) : base(type, name, description, points)
    {
        _numberOfTimes = numberOfTimes;
        _actualNumberOfTimes = 0;
    }

    public int GetNumberOfTimes()
    {
        return _numberOfTimes;
    }

    public int GetBonusPoints()
    {
        return _bonusPoints;
    }

    public int GetActualNumberOfTimes()
    {
        return _actualNumberOfTimes;
    }

    public override void SetCompleted(bool completed)
    {
        if (_actualNumberOfTimes == _numberOfTimes)
        {
            _completed = completed;
        }
    }

    public override string MakeDescription(int goalIndex, bool saveToFile)
    {
        if (saveToFile)
        {
            return $"{goalIndex}. | {_type} | {_name} | {_description} | {_points} | {_completed} | {_actualNumberOfTimes}/{_numberOfTimes}";
        }

        return $"{goalIndex}. [] {_name} ({_description})\n{_actualNumberOfTimes}/{_numberOfTimes}";
    }

}