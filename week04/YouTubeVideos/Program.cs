// CSE 210 - Introduction to Programming
// Exercise 1 - Practice with Program Class associated with the Video Class andComment Class
// Author: Tom Gibb
// Date: 05-29-2026

// This is a simple program that will be used to test the functionality of the Program class.

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        // Create a video object
        
        Video myVideo = new("My First Video", "Tom Gibb", 120);
        
        // Create some comment objects
        
        Comment comment1 = new("Alice", "Great video!", DateTime.Now, 10, 2, new List<string> { "Thanks!", "I agree!" }, false, false);
        Comment comment2 = new("Bob", "I didn't like this video.", DateTime.Now, 2, 15, new List<string> { "Why not?", "I liked it!" }, false, false);
        Comment comment3 = new("Charlie", "Can you make more videos like this?", DateTime.Now, 5, 1, new List<string> { "Sure!", "I will try!" }, false, false);

        // Add comments to the video
        myVideo.AddComment(comment1);
        myVideo.AddComment(comment2);
        myVideo.AddComment(comment3);

        // Display the video information and comments
        myVideo.DisplayVideoInfo();

        // Create another video object
        
        Video anotherVideo = new("My Second Video", "Tom Gibb", 240);
        
        // Create some comment objects
        
        Comment comment4 = new("Dave", "This video is amazing!", DateTime.Now, 20, 1, new List<string> { "Thank you!", "I appreciate it!" }, false, true);
        Comment comment5 = new("Eve", "I didn't find this video helpful.", DateTime.Now, 3, 10, new List<string> { "Why not?", "I found it helpful!" }, true, false);
        
        // Add comments to the second video
        
        anotherVideo.AddComment(comment4);
        anotherVideo.AddComment(comment5);

        // Display the second video information and comments
        
        anotherVideo.DisplayVideoInfo();

        // Create a third video object
        
        Video thirdVideo = new("My Third Video", "Tom Gibb", 180);
        
        // Create some comment objects
        
        Comment comment6 = new("Frank", "This video is okay.", DateTime.Now, 5, 5, new List<string> { "I see.", "Thanks for the feedback!" }, false, false);
        Comment comment7 = new("Grace", "I learned a lot from this video.", DateTime.Now, 15, 2, new List<string> { "That's great!", "I'm glad you found it useful!" }, true, false);
        Comment comment8 = new("Heidi", "I don't understand this video.", DateTime.Now, 1, 20, new List<string> { "What part is confusing?", "I can try to explain!" }, false, true);
        
        // Add comments to the third video
        
        thirdVideo.AddComment(comment6);
        thirdVideo.AddComment(comment7);

        // Display the third video information and comments
        thirdVideo.DisplayVideoInfo();


        // Wait for user input before closing the console
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();




    }
}