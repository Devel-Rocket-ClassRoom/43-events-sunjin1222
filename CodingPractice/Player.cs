using System;

class Player
{
    public event Action<int> DamageTaken;
    private int _health = 100;

    public void TakeDamage(int damage)
    {
        _health -= damage;
        Console.WriteLine($"플레이어 체력: {_health}");
        DamageTaken?.Invoke(_health);
    }
}

  
    



// 4. 이벤트 해제



// 5. 람다식 이벤트 핸들러


// 6. Action 대리자 활용



// 7. 표준 이벤트 패턴 (EventArgs)



// 8. 실전 예제 - 연료 경고 시스템



// 9. 이벤트 접근자

// 10. static 이벤트

