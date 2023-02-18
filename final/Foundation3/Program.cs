using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Anytown", "Anystate", "12345");
        Lecture lecture = new Lecture("Introduction to C#", "Learn the basics of C# programming", new DateTime(2023, 3, 1), new TimeSpan(10, 0, 0), address1, "John Smith", 50);

        Address address2 = new Address("456 Elm St", "Anytown", "Anystate", "12345");
        Reception reception = new Reception("Networking Mixer", "Meet other professionals in your field", new DateTime(2023, 3, 15), new TimeSpan(18, 0, 0), address2, "rsvp@company.com");

        Address address3 = new Address("789 Oak St", "Anytown", "Anystate", "12345");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Summer Picnic", "Enjoy a picnic in the park", new DateTime(2023, 7, 4), new TimeSpan(12, 0, 0), address3, "The weather is expected to be sunny and warm.");

        Console.WriteLine("========================================");
        Console.WriteLine(">>Lectures:");
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine();

        Console.WriteLine("========================================");
        Console.WriteLine(">>Receptions:");
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine();
        
        Console.WriteLine("========================================");
        Console.WriteLine(">>Outdoor Gatherings:");
        Console.WriteLine(outdoorGathering.GetFullDetails());
        Console.WriteLine();
    }
}