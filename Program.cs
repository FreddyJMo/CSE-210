using System;

class Program
{
    private Controller _controller;

    public Program()
    {
        _controller = new Controller();
    }
    static void Main(string[] args)
    {
        Program eteneralQuest = new Program();
        eteneralQuest._controller.Run();
    }
}