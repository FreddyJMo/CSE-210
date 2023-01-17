class Program
{
    static List<JournalEntry> entries = new List<JournalEntry>();
    static List<string> prompts = new List<string>(){
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If you had one thing you could do today, what would it be?"
    };
    static Random rand = new Random();

    static void Main(string[] args)
    {
        ShowMenu();
    }

    static void ShowMenu()
    {
        while (true)
        {
            Console.WriteLine("Select an option:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. View Journal");
            Console.WriteLine("3. Load journal from file");
            Console.WriteLine("4. Save journal to file");
            Console.WriteLine("5. Exit");

            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    NewEntry();
                    break;
                case 2:
                    ShowJournal();
                    break;
                case 3:
                    LoadJournal();
                    break;
                case 4:
                    SaveJournal();
                    break;
                case 5:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
            }
        }
    }

    static void NewEntry()
    {
        int promptIndex = rand.Next(prompts.Count);
        string prompt = prompts[promptIndex];
        Console.WriteLine(prompt);
        string response = Console.ReadLine();

        JournalEntry newEntry = new JournalEntry(prompt, response, DateTime.Now);
        entries.Add(newEntry);
        Console.WriteLine("Entry successfully saved.");
    }

    static void ShowJournal()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("The journal is empty.");
            return;
        }

        foreach (JournalEntry entry in entries)
        {
            if (entry == null)
            {
                // handle error
                continue;
            }
            Console.WriteLine(entry.prompt);

            Console.WriteLine(entry.prompt);
            Console.WriteLine(entry.response);
            Console.WriteLine(entry.date);
            Console.WriteLine();
        }
    }

    static void LoadJournal()
    {
        Console.WriteLine("Enter the file name:");
        string fileName = Console.ReadLine();

        if (!File.Exists(fileName))
        {
            Console.WriteLine("The file does not exists.");
            return;
        }

        string[] lines = File.ReadAllLines(fileName);
        entries = lines.Select(x => JournalEntry.FromString(x)).ToList();
        Console.WriteLine("Journal successfully loaded from file.");
        }
    static void SaveJournal()
    {
        Console.WriteLine("Enter the file name:");
        string fileName = Console.ReadLine();

        File.WriteAllLines(fileName, entries.Select(x => x.ToString()));
        Console.WriteLine("Journal successfully saved to file.");
    }
}
