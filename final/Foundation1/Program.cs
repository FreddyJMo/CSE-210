using System;

class Program
{
    static void Main(string[] args)
    {
        // Video list
        List<Video> videosList = new List<Video>();

        // Create an instance of the class Video and assign it to the video1 variable
        Video video1 = new Video();
        video1._title = "business of the 21st century";
        video1._author = "Robert Kiyosaki";
        video1._duration = 455;
        Comment comment1Video1 = new Comment();
        comment1Video1._text = "Explains the E - S - B - I categories clearly yet visually! Loved it.";
        comment1Video1._author = "Joni Craw";
        Comment comment2Video1 = new Comment();
        comment2Video1._text = "This was very helpful thank you.";
        comment2Video1._author = "Jennifer Nava";
        Comment comment3Video1 = new Comment();
        comment3Video1._text = "I read the book and found some fundamentals explained to improve finances. It is especially a good read for those who have little or no knowledge of finance and accounting. ";
        comment3Video1._author = "Fernando Rodriguez";

        // Repeating the process for video2
        Video video2 = new Video();
        video2._title = "C# Abstract Classes - What They Are, How to Use Them, and Best Practices";
        video2._author = "IAmTimCorey";
        video2._duration = 1198;
        Comment comment1Video2 = new Comment();
        comment1Video2._text = "WOW! clear and concise the best explanation I have found of abstract classes";
        comment1Video2._author = "User-ut2";
        Comment comment2Video2 = new Comment();
        comment2Video2._text = "Thank you that is great.";
        comment2Video2._author = "Idris Cadir";
        Comment comment3Video2 = new Comment();
        comment3Video2._text = "Thank you for always explaining things in a calm and structured way!";
        comment3Video2._author = "Louisee Olson";

        // Repeating the process for video3
        Video video3 = new Video();
        video3._title = "How I Would Learn To Code";
        video3._author = "Namanh Kapur";
        video3._duration = 822;
        Comment comment1Video3 = new Comment();
        comment1Video3._text = "Seeing Coding as a tool for problem solving showed me such a fresh perspective! Grateful for this, man - keep it up!";
        comment1Video3._author = "Gsicht Sgrab";
        Comment comment2Video3 = new Comment();
        comment2Video3._text = "This is one of the best self taught videos I’ve watched!";
        comment2Video3._author = "Maira Paula";

        // Add comments associated with the video1
        video1._commentsList.Add(comment1Video1);
        video1._commentsList.Add(comment2Video1);
        video1._commentsList.Add(comment3Video1);
        // Same process with video2
        video2._commentsList.Add(comment1Video2);
        video2._commentsList.Add(comment2Video2);
        video2._commentsList.Add(comment3Video2);
        // Same process with video3
        video3._commentsList.Add(comment1Video3);
        video3._commentsList.Add(comment2Video3);

        // Add to the videosList each video
        videosList.Add(video1);
        videosList.Add(video2);
        videosList.Add(video3);

        foreach (Video video in videosList)
        {
            video.DisplayDetails();
            video.DisplayComments();
        }

    }
}
