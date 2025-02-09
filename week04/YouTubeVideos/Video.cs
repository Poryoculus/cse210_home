using System.ComponentModel;
using System.Globalization;
using System.Net;
using System.Runtime.CompilerServices;

public class Video
{
    private string _name;
    private string _author;
    private double _videoDuration;
    private List<Comment> _comments;

    public Video(string name, string author, double videoDuration)
    {
        _name = name;
        _author = author;
        _videoDuration = videoDuration;
        _comments = new List<Comment>();

    }

    public int GetNumberOfComments()
    {
        int numberOfComments = _comments.Count;
        return  numberOfComments;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    //Display all the Comments of the video
    public string DisplayAllComments()
    {
        foreach (Comment item in _comments)
        {
            Console.WriteLine($"{item._name}: ");
            Console.WriteLine(item._commentText);
            Console.WriteLine("");
        }
        return "okay";
    }
    public void DisplayVideoInformation()
    {
        Console.WriteLine($"\nVideo's name: {_name}, Duration: {_videoDuration}");
        Console.WriteLine($"Author: {_author}");
    }
}