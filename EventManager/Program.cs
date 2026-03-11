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






