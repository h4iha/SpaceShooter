using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Details : MonoBehaviour
{
    [Header("Tag")]
    [SerializeField] private TagName[] enemyTags;
    List<string> listEnemyTags = new List<string>();
    // stats
    private Stats stats;
    // health
    private HealthSystem livesSystem;
    private HealthSystem hpSystem;
    private DamageSystem damageSystem;

    // Hp
    public Action onReceiveDamage;
    public Action onDeath;
    // Lives
    public Action onGameOver;
    // Increase
    public Action<int> onIncreaseLives;
    public Action<int> onIncreaseLevelLaserBeam;
    public Action<int> onIncreaseLevelShield;
    // Decrease
    public Action<int> onDecreaseLevelLaserBeam;
    public Action<int> onDecreaseLevelShield;
    private void Awake()
    {
        foreach(TagName child in enemyTags)
        {
            listEnemyTags.Add(child.ToString());
        }
        onIncreaseLevelLaserBeam = HandleIncreaseLevelLaserBeam;
        onIncreaseLevelShield = HandleIncreaseLevelShield;
        onIncreaseLives = HandleIncreaseLives;
    }
    public void CreateNewStats(Stats stats)
    {
        this.stats = stats;
        livesSystem = new HealthSystem(stats.MaxLives, onGameOver);
        hpSystem = new HealthSystem(stats.MaxHP, onDeath, onReceiveDamage);
        damageSystem = new DamageSystem(stats.LevelLaserBeam);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(listEnemyTags.Contains(collision.tag))
        {
            hpSystem.ReceiDamage();
        }
    }
    private void HandleIncreaseLevelLaserBeam(int value = 1)
    {
        stats.ChangeLevelLaserBeam(+value);
    }
    private void HandleIncreaseLevelShield(int value = 1)
    {
        stats.ChangeLevelShield(+value);
    }
    private void HandleIncreaseLives(int value = 1)
    {
        stats.ChangeLive(+1);
    }
}
