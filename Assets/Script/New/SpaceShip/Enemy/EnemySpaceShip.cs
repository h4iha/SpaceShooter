using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpaceShip : MonoBehaviour
{
    [SerializeField] private Sprite[] spaceShipSprites;
    [SerializeField] private Sprite[] laserBeamSprites;
    [SerializeField] private Fire fire;
    [SerializeField] private LaserBeam laserBeamPrefab;
    [SerializeField] private Transform laserBeamPlace;
    private Stats stats;
    private LaserBeam laserBeam;
    private Health HP;
    private void Awake()
    {
        UpdateStats();
        UpdateLaserBeam();
        UpdateFire();
    }
    private void UpdateStats()
    {
        stats = new Stats(1);
        HP = new Health(stats.MaxHP, HandleDeath);
    }
    private void UpdateLaserBeam()
    {
        laserBeam = Instantiate(laserBeamPrefab, laserBeamPlace);
        laserBeam.SetDamage = stats.LevelLaserBeam;
        laserBeam.tag = TagLaserBeam.Player.ToString();
    }
    private void UpdateFire()
    {
        //fire = this.AddComponent<Fire>();
        fire.IsAutomatic = true;
        fire.LaserBeamPrefab = laserBeam.gameObject;
        fire.RateOfFire = 3;
        fire.SpeedProjectTile = 100;
    }
    private void HandleDeath()
    {
        SpawnAward();
        Destroy(gameObject);
    }
    private void SpawnAward()
    {
        Instantiate(laserBeam, transform.position, transform.rotation);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        string tagCollision = TagLaserBeam.Enemy.ToString();
        if (collision.CompareTag(tagCollision))
        {
            HP.ReceiDamage();
        }
    }
    
}
