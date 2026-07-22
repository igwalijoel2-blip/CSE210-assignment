using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        List<Video> videos = new List<Video>();


        Video video1 = new Video(
            "How to Learn C#",
            "Programming Academy",
            600
        );

        video1.AddComment(new Comment(
            "Joel",
            "This tutorial helped me understand classes."
        ));

        video1.AddComment(new Comment(
            "Sarah",
            "Very clear explanation."
        ));

        video1.AddComment(new Comment(
            "David",
            "I enjoyed this lesson."
        ));



        Video video2 = new Video(
            "Introduction to Python",
            "Code World",
            720
        );

        video2.AddComment(new Comment(
            "John",
            "Python is easy to learn."
        ));

        video2.AddComment(new Comment(
            "Mary",
            "Great examples."
        ));

        video2.AddComment(new Comment(
            "Peter",
            "Waiting for more videos."
        ));



        Video video3 = new Video(
            "Building Your First Website",
            "Web Masters",
            900
        );

        video3.AddComment(new Comment(
            "Anna",
            "The HTML section was useful."
        ));

        video3.AddComment(new Comment(
            "James",
            "I built my first website."
        ));

        video3.AddComment(new Comment(
            "Chris",
            "Excellent teaching style."
        ));



        Video video4 = new Video(
            "Object Oriented Programming",
            "Software School",
            800
        );

        video4.AddComment(new Comment(
            "Mike",
            "Abstraction makes programming easier."
        ));

        video4.AddComment(new Comment(
            "Lucy",
            "Classes are powerful."
        ));

        video4.AddComment(new Comment(
            "Daniel",
            "Good explanation."
        ));



        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);



        foreach (Video video in videos)
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine(video.GetDisplayText());
        }

    }
}