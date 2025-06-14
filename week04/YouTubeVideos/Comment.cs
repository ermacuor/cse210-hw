class Comment
{
    public string CommenterName;
    public string Text;

    public Comment(string commenterName, string text)
    {
        CommenterName = commenterName;
        Text = text;
    }

    public void DisplayComment()
    {
        Console.WriteLine($"- {CommenterName}: {Text}");
    }
}
