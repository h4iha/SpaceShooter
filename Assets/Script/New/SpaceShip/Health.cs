using System;
using System.Runtime;
public class Health
{
    private int maxHitPoint;
    private int currentHitPoint;
    private Action onDeath;
    private Action<int> onChangeHitPoint;
    public Health(int maxHitPoint, Action onDeath)
    {
        this.maxHitPoint = maxHitPoint;
        this.currentHitPoint = maxHitPoint;
        this.onDeath = onDeath;
    }
    public Health(int maxHitPoint, int currentHitPoint, Action onDeath)
    {
        this.maxHitPoint = maxHitPoint;
        this.currentHitPoint = currentHitPoint;
        this.onDeath = onDeath;
    }
    public Health(int maxHitPoint, Action onDeath, Action<int> onChangeHitPoint)
    {
        this.maxHitPoint = maxHitPoint;
        this.currentHitPoint = maxHitPoint;
        this.onDeath = onDeath;
        this.onChangeHitPoint = onChangeHitPoint;
    }

    public void ReceiDamage(int damage = 1)
    {
        if (currentHitPoint <= damage)
        {
            currentHitPoint = 0;
            onDeath?.Invoke();
        }
        else
        {
            currentHitPoint -= damage;
        }
        onChangeHitPoint?.Invoke(currentHitPoint);
    }
    public void Heal(int hpHeal = 1)
    {
        currentHitPoint += hpHeal;
        onChangeHitPoint?.Invoke(currentHitPoint);
    }
    public int GetHitPoint{ get { return currentHitPoint; } }
}
