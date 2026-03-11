using System;

class AchievementSystem
{
    public void Achievement(object sender, GameEventArgs e)
    {
        if (e.Data is string s)
        {
            Console.WriteLine($"업적달성: {s}점");
        }
    }
}






