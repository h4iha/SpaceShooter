using System;
using System.Runtime;
public class HealthSystem
{
    private int maxValue;
    private int currentValue;
    private Action onDeath;
    private Action onReceiveDamage;
    private Action<int> onChangeHitPoint;
    public HealthSystem(int maxLives, Action onDeath)
    {
        // lives
        this.maxValue = maxLives;
        this.currentValue = maxValue;
        this.onDeath = onDeath;
    }
    public HealthSystem(int maxHitPoint, Action onDeath, Action onReceiveDamage)
    {
        // hp
        this.maxValue = maxHitPoint;
        this.currentValue = maxValue;
        this.onDeath = onDeath;
        this.onReceiveDamage = onReceiveDamage;
    }
    public HealthSystem(int maxHitPoint, Action onDeath, Action onReceiveDamage, Action<int> onChangeHitPoint)
    {
        // shield
        this.maxValue = maxHitPoint;
        this.currentValue = maxHitPoint;
        this.onDeath = onDeath;
        this.onReceiveDamage = onReceiveDamage;
        this.onChangeHitPoint = onChangeHitPoint;
    }
    public void ReceiDamage(int damage = 1)
    {
        if (currentValue <= damage)
        {
            currentValue = 0;
            onDeath?.Invoke();
        }
        else
        {
            currentValue -= damage;
            onReceiveDamage?.Invoke();
        }
        onChangeHitPoint?.Invoke(currentValue);
    }
    public void Heal(int hpHeal = 1)
    {
        currentValue += hpHeal;
        onChangeHitPoint?.Invoke(currentValue);
    }
    public int GetHitPoint{ get { return currentValue; } }
}
