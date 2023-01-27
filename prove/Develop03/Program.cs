using System;

class Program
{
    static void Main(string[] args)
    {
        //Here we will establish the reference of the script that we are going to use
        Reference scriptureReference = new Reference("Proverbs", "3", "5-6");
        
        //We establish the verses of the scripture and pass the scripture Reference that was just created
        Scripture scripture = new Scripture (scriptureReference, "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");
        
        //We create the ScriptureMemorizer and pass the scripture we just created
        ScriptureMemorizer scriptureMemorizer = new ScriptureMemorizer(scripture);

        //We set the initial input to be empty and create a while loop
        //That will terminate when the words run out or when the user types "quit"
        string userInput = "";
        while (userInput != "quit" && scriptureMemorizer.hasWordLeft() == true)
        {
            Console.Clear();
            Console.WriteLine(string.Format("{0} {1}", scriptureReference.toString(), scriptureMemorizer.toString()));
            Console.WriteLine();
            Console.ReadLine();
            scriptureMemorizer.removeWordsFromText();
        }
    
    
    }
}
