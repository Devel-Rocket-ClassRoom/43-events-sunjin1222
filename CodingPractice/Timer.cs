using System;

class Timer
{
    public event Action Tick;
    private int _count;

    public void Start()
    {
        for (int i = 0; i < 3; i++)
        {
            _count++;
            Console.WriteLine($"타이머: {_count}초");
            Tick?.Invoke();
        }
    }
}




// 5. 람다식 이벤트 핸들러


// 6. Action 대리자 활용



// 7. 표준 이벤트 패턴 (EventArgs)



// 8. 실전 예제 - 연료 경고 시스템



// 9. 이벤트 접근자

// 10. static 이벤트

