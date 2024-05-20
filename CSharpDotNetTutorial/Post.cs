using System;
namespace CSharpDotNetTutorial;

public class Post
{
    private string Title { get; }
    private string Description;
    public DateTime Created;
    private int Votes;

    public Post(string title, string description)
    {
        this.Title = title;
        this.Description = description;
        this.Created = DateTime.Now;
    }

    public void UpVote()
    {
        this.Votes += 1;
    }

    public void DownVote()
    {
        this.Votes -= 1;
    }

    public int CurrentVote()
    {
        return this.Votes;
    }
}