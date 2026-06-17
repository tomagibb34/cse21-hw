// CSE 210 - Introduction to Programming
// Exercise 1 - Practice with Video Class Comment Class
// Author: Tom Gibb
// Date: 05-29-2026

// This is a simple program that will be used to test the functionality of the Comment class.

public class Comment(string commenterName, string commentText, DateTime commentDate, int likes, int dislikes, List<string> replies, bool isEdited, bool isPinned)
{
    private string _commenterName = commenterName;
    private string _commentText = commentText;
    private DateTime _commentDate = commentDate;
    private int _likes = likes;
    private int _dislikes = dislikes;
    private List<string> _replies = replies;
    private bool _isEdited = isEdited;
    private bool _isPinned = isPinned;

     // Method to display the comment in a formatted way
     public void DisplayComment()
    {
        Console.WriteLine($"{_commenterName} says: {_commentText}");
        Console.WriteLine($"Date: {_commentDate}");
        Console.WriteLine($"Likes: {_likes} | Dislikes: {_dislikes}");
        Console.WriteLine($"Replies: {_replies.Count}");
        Console.WriteLine($"Is Edited: {_isEdited}");
        Console.WriteLine($"Is Pinned: {_isPinned}");
    }
}

