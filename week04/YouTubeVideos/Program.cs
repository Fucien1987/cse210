using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("How to Learn C#", "Academy", 420);
        video1._comments.Add(new Comment("John", "Great video!"));
        video1._comments.Add(new Comment("Mary", "This help me a lot."));
        video1._comments.Add(new Comment("Peter", "Very easy to understand."));

        Video video2 = new Video("Visit Haiti", "Travel World", 360);
        video2._comments.Add(new Comment("James", "Haiti is beautiful!"));
        video2._comments.Add(new Comment("Sarah", "I would love to visit."));
        video2._comments.Add(new Comment("David", "Great information."));

        Video video3 = new Video("Programming Basics", "Tech Learning", 500);
        video3._comments.Add(new Comment("Mike", "Excellent explanation."));
        video3._comments.Add(new Comment("Anna", "Very useful for beginners."));
        video3._comments.Add(new Comment("Chris", "Thank for sharing!"));

        List<Video> videos = new List<Video> {video1, video2, video3};

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._length} seconds");
            Console.WriteLine($"Number of comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video._comments)
            {
                Console.WriteLine($"- {comment._commenterName}: {comment._text}");
            }
            Console.WriteLine();
        }
    }
}