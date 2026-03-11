using System;

// README.md를 읽고 아래에 코드를 작성하세요.
Console.WriteLine("코드를 작성하세요.");

ChatRoom Chat = new();

ChatLogger ChatLogger = new();

NotificationService Service = new();



Chat.MessageReceived += ChatLogger.Chat;
Chat.MessageReceived += Service.emergency;


Chat.SendMessage("철수", "안녕하세요");
Chat.SendMessage("영희", "긴급회의가 있습니다");
Chat.SendMessage("민수", "점심 뭐 먹을까요?");
