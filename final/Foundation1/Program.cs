using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("How to Grow Tomatos", "Diane Lish", 120);
        
        Comment comment1 = new Comment("@EvaLish", "Thank you for this informational video!");
        video1.AddComment(comment1);
        Comment comment2 = new Comment("@JacksonLish", "Yummy my tomatos turned out so good this year. Thank you!");
        video1.AddComment(comment2);
        Comment comment3 = new Comment("@MarianLish", "I'm so excited to grow tomato plants this year! I will definitely reference this video!");
        video1.AddComment(comment3);

        videos.Add(video1);


        Video video2 = new Video("Come to Disney with us!", "Tyler Lish", 300);

        Comment comment4 = new Comment("@EvaLish", "Looks like so much fun!");
        video2.AddComment(comment4);
        Comment comment5 = new Comment("@JacksonLish", "I want to go to Disney!");
        video2.AddComment(comment5);
        Comment comment6 = new Comment("@MarianLish", "We are going to Disney next year! I'm going to try those churros!");
        video2.AddComment(comment6);

        videos.Add(video2);


        Video video3 = new Video("Look at This Giant Bug!", "Lanie Lish", 60);

        Comment comment7 = new Comment("@EvaLish", "Ew! It's Huge!");
        video3.AddComment(comment7);
        Comment comment8 = new Comment("@JacksonLish", "That thing is gigantic!");
        video3.AddComment(comment8);
        Comment comment9 = new Comment("@MarianLish", "Just burn the whole house down! *Shutter*");
        video3.AddComment(comment9);   
        Comment comment10 = new Comment("@DianeLish", "I hope you didn't kill it! Its kind of cool.");
        video3.AddComment(comment10);

        videos.Add(video3);

        Console.Clear();

        foreach (Video video in videos)
        {
            Console.WriteLine("---------------");
            video.Display();
        }



    }
}