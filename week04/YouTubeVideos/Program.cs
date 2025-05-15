using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        Video video1 = new Video();
        Video video2 = new Video();
        Video video3 = new Video();

        video1._title = "Reading the King Follet Discourse in Context";
        video1._author = "Read It BoM";
        video1.ConvertToSec("2:05:06");
        video1.CreateComment("Through the Mist", "Awesome, excellent points.");
        video1.CreateComment("leroythomas", "Great work thank you");
        video1.CreateComment("AbrahamicAstronomy", "Well done. I wish every quote miner would watch this.");
        videos.Add(video1);

        video2._title = "Oliver Cowdery's testimony during his excommunication: irrefutable";
        video2._author = "Read It BoM";
        video2.ConvertToSec("0:04:41");
        video2.CreateComment("RichardHolmes", "Thank you for sharing this.");
        video2.CreateComment("leroythomas", "I've never heard of this before.");
        video2.CreateComment("AbrahamicAstronomy", "Interesting.");
        videos.Add(video2);

        video3._title = "The Hypostatic Union";
        video3._author = "Read It BoM";
        video3.ConvertToSec("0:05:20");
        video3.CreateComment("Through the Mist", "Thanks for coming onto my podcast");
        video3.CreateComment("leroythomas", "Nice Work!");
        video3.CreateComment("AbrahamicAstronomy", "I've never thought of this before.");
        videos.Add(video3);

        foreach (var video in videos)
        {
            video.DisplayVideo();
            Console.WriteLine();
        }

    }
}