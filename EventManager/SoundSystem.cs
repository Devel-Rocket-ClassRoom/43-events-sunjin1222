using System;

class SoundSystem
{
    public void Achievement(object sender, GameEventArgs e)
    {
        Console.WriteLine($"[Sound] 이벤트: {e.EventName}");
    }
}






