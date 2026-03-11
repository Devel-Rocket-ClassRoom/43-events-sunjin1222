using System;

// README.md를 읽고 아래에 코드를 작성하세요.
Console.WriteLine("코드를 작성하세요.");

ChatRoom chat = new();

ChatLogger chatLogger = new();

NotificationService service = new();



chat.MessageReceived += chatLogger.Chat;
chat.MessageReceived += service.emergency;


chat.SendMessage("철수", "안녕하세요");
chat.SendMessage("영희", "긴급회의가 있습니다");
chat.SendMessage("민수", "점심 뭐 먹을까요?");

class ChatRoom
{
    public event Action<string, string> MessageReceived;

    public void SendMessage(string sender, string message)
    {
        MessageReceived?.Invoke(sender,message);
    }
}



class ChatLogger
{
    public void Chat(string sender,string message)
    {
        Console.WriteLine($"[로그] {sender}: {message}");
    }
}



class NotificationService
{
    public  void emergency(string sender,string message)
    {
        if (message.Contains("긴급"))
        {
            Console.WriteLine("[알림] 긴급 메시지 수신!");
        }
    }
}