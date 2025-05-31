using System;
public class PromptGenerator
{
    public List<string> _prompts = new List<string>
    {
        "What is one thing I learned today that surprised me?",
        "What moment made me smile the most today?",
        "How did I step outside of my comfort zone today?",
        "What is something I wish I had said or done differently todaY?",
        "How did I express kindness or gratitude today?",
        "What is one small victory I achieved today?",
        "If I could relive one moment from today, what would it be?",
        "Who made an impact on me today, and why?",
        "How did I handle a challenge or setback today?",
        "What is one goal I want to set for myself tomorrow?"
    };
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}