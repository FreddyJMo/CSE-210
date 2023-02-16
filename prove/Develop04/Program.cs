
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
        Program a1 = new Program();
        a1._controller.Run();
    }
}