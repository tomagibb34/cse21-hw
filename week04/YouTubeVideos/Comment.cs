// CSE 210 - Introduction to Programming
// Exercise 1 - Practice with Video Class Comment Class
// Author: Tom Gibb
// Date: 05-29-2026

// This is a simple program that will be used to test the functionality of the Comment class.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

public class Comment
{
    private string _commenterName;
    private string _commentText;
    private DateTime _commentDate;
    private int _likes;
    private int _dislikes;
    private List<string> _replies;
    private bool _isEdited;
    private bool _isPinned;

    // Constructor to initialize the commenter's name and comment text
    public Comment(string commenterName, string commentText, DateTime commentDate, int likes, int dislikes, List<string> replies, bool isEdited, bool isPinned)
    {
        _commenterName = commenterName;
        _commentText = commentText;
        _commentDate = commentDate;
        _likes = likes;
        _dislikes = dislikes;
        _replies = replies;
        _isEdited = isEdited;
        _isPinned = isPinned;
    }

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

