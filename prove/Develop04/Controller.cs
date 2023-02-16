using System;

public class Controller
{
    private BreathingActivity _breathing;
    private ReflectionActivity _reflection;
    private ListingActivity _listing;
    private UserInterface _userInterface;
    public Controller()
    {
        _breathing = new BreathingActivity();
        _reflection = new ReflectionActivity();
        _listing = new ListingActivity();
        _userInterface = new UserInterface();
    }

    public void Run()
    {
        _reflection.GenerateRandomPrompt();
        _reflection.GenerateRandomQuestion();
        _listing.GenerateRandomPrompt();
        _userInterface.ChooseMenuOption(
            _breathing.GetName(),
            _breathing.GetStartMessage(),
            _reflection.GetName(),
            _reflection.GetStartMessage(),
            _reflection.GetPrompt(),
            _reflection.GetQuestion(),
            _listing.GetName(),
            _listing.GetStartMessage(),
            _listing.GetPrompt()
        );
    }

}