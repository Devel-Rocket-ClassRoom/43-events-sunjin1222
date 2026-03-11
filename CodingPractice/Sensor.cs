using System;

class Sensor
{
    public event Action<string> Alert;

    public void Detect(string message)
    {
        Console.WriteLine($"감지: {message}");
        Alert?.Invoke(message);
    }
}

      

// 6. Action 대리자 활용



// 7. 표준 이벤트 패턴 (EventArgs)



// 8. 실전 예제 - 연료 경고 시스템



// 9. 이벤트 접근자

// 10. static 이벤트

