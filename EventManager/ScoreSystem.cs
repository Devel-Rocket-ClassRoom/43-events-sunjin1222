using System;

class ScoreSystem
{
    public void ScoreChanged(object sender, GameEventArgs e)
    {
        if (e.Data is int i)
        {
            Console.WriteLine($"점수변경: {i}점");
        }
    }
}






