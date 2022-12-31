public class DamageSystem
{
    private int damage; 
    public DamageSystem(int levelLaserBeam = 1)
    {
        damage = levelLaserBeam;
    }
    public void IncreaseDamage(int damageIncreased = 1)
    {
        damage += damageIncreased;
    }
}
