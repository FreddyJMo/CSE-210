using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Freddy Mota", "Divisions");
        Console.WriteLine(a1.GetStudentName());
        Console.WriteLine(a1.GetTopic());

        MathAssignment a2 = new MathAssignment("Freddy Mota", "Fractions", "7.3", "8-19");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAsignment a3 = new WritingAsignment("Freddy Mota", "European History", "The Causes of World War II by Mary Waters");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}