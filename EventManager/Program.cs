using System;
using System.Reflection;
using static System.Runtime.InteropServices.JavaScript.JSType;

// README.md를 읽고 코드를 작성하세요.
Console.WriteLine("코드를 작성하세요.");

ScoreSystem scoreSystem = new ScoreSystem();
AchievementSystem achievementSystem = new AchievementSystem();
SoundSystem soundSystem = new SoundSystem();

EventManager.OnGameEvent += soundSystem.Achievement;
EventManager.OnGameEvent += scoreSystem.ScoreChanged;
EventManager.OnGameEvent += achievementSystem.Achievement;


EventManager.TriggerEvent("ScoreChanged", 100);
EventManager.TriggerEvent("Achievement", "첫 번째 적 처치");
EventManager.TriggerEvent("GameOver", null);

class GameEventArgs : EventArgs
{
    public string EventName { get; }
    public object Data { get; }
    public GameEventArgs(string eventName, object data)
    {
        EventName = eventName;
        Data = data;
    }
}

static class EventManager
{
    static public event EventHandler<GameEventArgs> OnGameEvent;

    static public void TriggerEvent(string eventName,object data = null)
    {
        OnGameEvent?.Invoke(null, new GameEventArgs(eventName, data));
    }
}

class SoundSystem
{
    public void Achievement(object sender, GameEventArgs e)
    {
        Console.WriteLine($"[Sound] 이벤트: {e.EventName}");
    }
}

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






