using System;

class GameCharacter
{
    public event Action OnDeath;
    public event Action<int> OnDamaged;
    public event Action<int, string> OnAttack;

    private int _health = 100;
    private string _name;

    public GameCharacter(string name)
    {
        _name = name;
    }

    public void TakeDamage(int damage)
    {
        _health -= damage;
        OnDamaged?.Invoke(_health);

        if (_health <= 0)
        {
            OnDeath?.Invoke();
        }
    }

    public void Attack(int damage, string targetName)
    {
        OnAttack?.Invoke(damage, targetName);
    }
}


// 7. 표준 이벤트 패턴 (EventArgs)



// 8. 실전 예제 - 연료 경고 시스템



// 9. 이벤트 접근자

// 10. static 이벤트

