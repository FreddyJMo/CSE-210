using System;
using System.Collections.Generic;

namespace FitnessTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of activities
            List<Activity> activities = new List<Activity>();

            // Add an activity of each type to the list
            activities.Add(new Running(DateTime.Parse("2023-02-16"), 20, 4.0));
            activities.Add(new Cycling(DateTime.Parse("2023-02-16"), 30, 10.0));
            activities.Add(new Swimming(DateTime.Parse("2023-02-16"), 20, 25.0));

            // Print the summary for each activity
            foreach (var activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
            }
        }
    }
}