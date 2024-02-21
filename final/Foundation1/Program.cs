using System;

class Program
{

    static void Main(string[] args)
    {

        Video vid1 = new Video("Unbreakable Ice Cream Safe", "Mark Roper", 97);
        vid1.AddComment(new Comment("User1", "Am I the only one who remembers this video being longer than this?"));
        vid1.AddComment(new Comment("User2", "This guy looks like he is not getting any older"));
        vid1.AddComment(new Comment("User3", "Keep it up!"));


        Video vid2 = new Video("The Avoongers Movie Trailer", "Laugh over Life", 84);
        vid2.AddComment(new Comment("User4", "Wow. . . Just wow!"));
        vid2.AddComment(new Comment("User5", "Finally, the Avengers being actual good heroes for once."));
        vid2.AddComment(new Comment("User6", "Still better than what Disney makes nowadays."));


        Video vid3 = new Video("Change a Tire with an Animal", "Tasks with pets", 240);
        vid3.AddComment(new Comment("User7", "Mind is Blown!"));
        vid3.AddComment(new Comment("User8", "I didn't know pets were multipurpose! LOL"));
        vid3.AddComment(new Comment("User9", "Call PETA"));


        List<Video> videos = new List<Video> { vid1, vid2, vid3 };


        foreach (Video video in videos)
        {

            System.Console.WriteLine($"Title: {video._title}");
            System.Console.WriteLine($"Author: {video._author}");
            System.Console.WriteLine($"Length: {video._length} seconds");
            System.Console.WriteLine($"Number of comments: {video.GetNumberofComments()}");
            System.Console.WriteLine("Comments: ");


            foreach (Comment comment in video.GetComments())
            {

                System.Console.WriteLine($"- {comment._name}: {comment._text}");

            }
            
            System.Console.WriteLine();
            
        }
    }
}