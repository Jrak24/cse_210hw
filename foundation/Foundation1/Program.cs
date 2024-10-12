class Program
{
    static void Main(string[] args)
    {
        // Create videos
        Video video1 = new Video("C# Programming Tutorial", "John Doe", 1200);
        Video video2 = new Video("Learn Python in 10 Minutes", "Jane Smith", 600);
        Video video3 = new Video("Top 10 Coding Tips", "Alice Johnson", 900);

        // Add comments to video1
        video1.AddComment(new Comment("User1", "Great tutorial!"));
        video1.AddComment(new Comment("User2", "Very helpful, thanks!"));
        video1.AddComment(new Comment("User3", "I learned a lot!"));

        // Add comments to video2
        video2.AddComment(new Comment("User4", "Quick and to the point."));
        video2.AddComment(new Comment("User5", "Python is amazing!"));

        // Add comments to video3
        video3.AddComment(new Comment("User6", "Thanks for the tips!"));
        video3.AddComment(new Comment("User7", "Very informative video."));
        video3.AddComment(new Comment("User8", "Loved it!"));

        // Create a list of videos
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display video details and comments
        foreach (Video video in videos)
        {
            Console.WriteLine(video.GetVideoDetails());
            video.DisplayComments();
            Console.WriteLine();
        }
    }
}
