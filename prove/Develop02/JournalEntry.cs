class JournalEntry
{
public string prompt;
public string response;
public DateTime date;


    public JournalEntry(string prompt, string response, DateTime date)
    {
        this.prompt = prompt;
        this.response = response;
        this.date = date;
    }

    public override string ToString()
    {
        return $"{prompt}\n{response}\n{date}";
    }

    public static JournalEntry FromString(string str)
    {
        string[] parts = str.Split('\n');
            if (parts.Length != 3)
    {
        // handle error
        return null;
    }
    return new JournalEntry(parts[0], parts[1], DateTime.Parse(parts[2]));
    }
}