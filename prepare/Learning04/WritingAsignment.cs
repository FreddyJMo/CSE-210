using System;

public class WritingAsignment : Assignment
{
    private string _tittleString = "";

   public WritingAsignment(string studentName, string topic, string tittleString)
    : base (studentName, topic) 
    {
        _tittleString = tittleString;
    }

    public string GetWritingInformation()
    {
        return $"{_tittleString}";
    }
}