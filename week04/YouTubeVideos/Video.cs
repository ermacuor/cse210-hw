class Video
{
    public string Title;
    public string Author;
    public int Length;
    public List<Comment> Comments;

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
        Comments = new List<Comment>();
    }

    public int GetCommentCount()
    {
        return Comments.Count;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {Title}, Author: {Author}, Lenght: {Length} secs");
        Console.WriteLine($"Comments ({GetCommentCount()}):");
        
        foreach (var comment in Comments)
        {
            comment.DisplayComment();
        }
    }
}

