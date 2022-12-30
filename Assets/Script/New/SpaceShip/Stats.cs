public class Stats
{
    private int maxLives;
    private int maxHP;
    private int levelLaserBeam;
    private int speedProjectTile;
    private float rateOfFire;
    public Stats(int level = 1, int levelLaser = 1, int maxLives = 1, int speedProjectTile = 100)
    {
        this.maxHP = level * 5;
        this.levelLaserBeam = levelLaser;
        this.maxLives = maxLives;
        this.speedProjectTile = speedProjectTile;
    }
    public Stats(int maxLives, int maxHP, int levelLaser, int speedProjectTile, float rateOfFire)
    {
        this.maxLives = maxLives;
        this.maxHP = maxHP;
        this.levelLaserBeam = levelLaser;
        this.speedProjectTile = speedProjectTile;
        this.rateOfFire = rateOfFire;
    }
    public int MaxLives { get { return maxLives; } }
    public int MaxHP { get { return maxHP; } }
    public int LevelLaserBeam { get { return levelLaserBeam; } }
    public int SpeedProjectTile { get { return speedProjectTile; } }
    public float RateOfFire { get { return rateOfFire; } }

    public void IncreaseLevelLaserBeam(int value = 1)
    {
        levelLaserBeam += value;
    }
    public void ResetLevelLaserBeam()
    {
        levelLaserBeam = 0;
    }
}
