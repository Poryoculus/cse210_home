using System;

class Program
{
    static void Main(string[] args)
    {
        // Video 1
        Video video1 = new Video("C# Tutorial", "John Doe", 10.5);
        video1.AddComment(new Comment("Alice", "Great video!"));
        video1.AddComment(new Comment("Bob", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Charlie", "Well explained!"));

        // Video 2
        Video video2 = new Video("Python Basics", "Sarah Smith", 15.2);
        video2.AddComment(new Comment("Dave", "Awesome tutorial!"));
        video2.AddComment(new Comment("Eve", "I finally understand loops!"));
        video2.AddComment(new Comment("Frank", "Looking forward to more content."));

        // Video 3
        Video video3 = new Video("JavaScript for Beginners", "Mike Johnson", 8.7);
        video3.AddComment(new Comment("Grace", "Thanks for the simple explanation!"));
        video3.AddComment(new Comment("Hank", "This was very clear and useful."));
        video3.AddComment(new Comment("Ivy", "Subscribed! Keep up the good work."));

        // Video 4
        Video video4 = new Video("SQL Database Basics", "Emma Brown", 12.3);
        video4.AddComment(new Comment("Jack", "Just what I needed, thanks!"));
        video4.AddComment(new Comment("Kate", "I finally get SQL joins!"));
        video4.AddComment(new Comment("Leo", "Simple and effective tutorial."));

        // Display all videos and their comments
        List<Video> videos = new List<Video> { video1, video2, video3, video4 };

        foreach (Video video in videos)
        {
            Console.WriteLine("\n====================");
            video.DisplayVideoInformation();
            Console.WriteLine($"\nTotal Comments: {video.GetNumberOfComments()}");
            video.DisplayAllComments();
        }

        // I used ChatGPT to create the videos and comments and don't use much time thinking in original ideas all the other code is mine.
    }
}