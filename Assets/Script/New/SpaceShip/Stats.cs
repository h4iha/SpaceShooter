using Unity.VisualScripting;
public class Stats
{
    private int maxLives;
    private int currentLives;
    private int maxHP;
    private int currentHP;
    private int levelLaserBeam;
    private int speedProjectTile;
    private float rateOfFire;
    private int levelShield;

    public Stats(int level)
    {
        this.maxLives = 1;
        this.maxHP = level * 5;
        this.levelLaserBeam = 1;
        this.speedProjectTile = 100;
    }
    public Stats(int maxLives, bool isPlayer)
    {
        this.maxLives = maxLives;
        this.maxHP = 1;
        this.levelLaserBeam = 1;
        this.speedProjectTile = 200;
        this.rateOfFire = 3;
        this.levelShield = 0;
    }
    public int MaxLives { get { return maxLives; } }
    public int MaxHP { get { return maxHP; } }
    public int SpeedProjectTile { get { return speedProjectTile; } }
    public int LevelLaserBeam { get { return levelLaserBeam; } }
    public float RateOfFire { get { return rateOfFire; } }
    public int LevelShield { get { return levelShield; } }
    public int CurrentLives { get { return currentLives; } }
    public int CurrentHP { get { return currentHP; } }
    public void ChangeLevelLaserBeam(int value = 1)
    {
        StatsChanger statsChanger = new StatsChanger(4, levelLaserBeam);
        levelLaserBeam = statsChanger.CurrentValue;
    }
    public void ChangeLevelShield(int value = 1)
    {
        StatsChanger statsChanger = new StatsChanger(4, levelLaserBeam);
        levelShield = statsChanger.CurrentValue;
    }
    public void ChangeLive(int value = 1)
    {
        StatsChanger statsChanger = new StatsChanger(4, levelLaserBeam);
        currentLives = statsChanger.CurrentValue;
    }
    public void ChangeHP(int value = 1)
    {
        StatsChanger statsChanger = new StatsChanger(4, levelLaserBeam);
        currentHP = statsChanger.CurrentValue;
    }
}
public class StatsChanger
{
    private int maxValue;
    private int currentValue;

    public StatsChanger(int maxIndex, int currentValue)
    {
        this.maxValue = maxIndex;
        this.currentValue = 0;
    }

    public void ChangeValue(int value = 1)
    {
        currentValue += value;
        if (currentValue > maxValue)
        {
            currentValue = maxValue;
        }
        if (currentValue < 0)
        {
            currentValue = 0;
        }
    }

    public int CurrentValue { get { return currentValue; } }
}