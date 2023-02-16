using System;

public class GoalsList
{
    private string _fileName;
    private Goals _currentGoal;
    private List<Goals> _goalsList;
    private List<object> _currentGoalDetailsList;

    public GoalsList()
    {
        _goalsList = new List<Goals>();
    }

    public List<Goals> GetGoalsList()
    {
        return _goalsList;
    }

    public void SetFileName(string fileName)
    {
        _fileName = fileName;
    }
    public void SetGoalDetailsList(List<object> goalDetailsList)
    {
        _currentGoalDetailsList = goalDetailsList;
    }

    public void CreateGoal()
    {
        switch (_currentGoalDetailsList[0])
        {
            case "1":
                _currentGoal = new Simple(
                    "Simple",
                    _currentGoalDetailsList[1].ToString(),
                    _currentGoalDetailsList[2].ToString(),
                    int.Parse(_currentGoalDetailsList[3].ToString())
                );
                break;
            case "2":
                _currentGoal = new EternalGoal(
                    "Eternal",
                    _currentGoalDetailsList[1].ToString(),
                    _currentGoalDetailsList[2].ToString(),
                    int.Parse(_currentGoalDetailsList[3].ToString())
                );
                break;
            case "3":
                _currentGoal = new ChecklistGoal(
                    "Checklist",
                    _currentGoalDetailsList[1].ToString(),
                    _currentGoalDetailsList[2].ToString(),
                    int.Parse(_currentGoalDetailsList[3].ToString()),
                    int.Parse(_currentGoalDetailsList[4].ToString())
                );
                break;
        }
        _goalsList.Add(_currentGoal);
    }

    public void SaveToFile()
    {
        List<string> linesToFileList = new List<string>();

        int lineCounter = 0;

        foreach (Goals goal in _goalsList)
        {
            linesToFileList.Add(goal.MakeDescription(++lineCounter, true));
        }

        File.WriteAllLines(_fileName, linesToFileList);
    }

    public void LoadFromFile()
    {
        StreamReader streamReader = new StreamReader(_fileName);

        _goalsList.Clear();

        while (!streamReader.EndOfStream)
        {
            string goalDetails = streamReader.ReadLine();
            string[] goalDetailsList = goalDetails.Split(" | ");
            if (goalDetailsList.Length == 6)
            {
                _goalsList.Add(new Goals(goalDetailsList[1], goalDetailsList[2], goalDetailsList[3], int.Parse(goalDetailsList[4])));
            }
            else
            {
                _goalsList.Add(new ChecklistGoal(goalDetailsList[1], goalDetailsList[2], goalDetailsList[3],
                    int.Parse(goalDetailsList[4]), int.Parse(goalDetailsList[6].Split("/")[1])));
            }

        }
        streamReader.Close();

    }

}