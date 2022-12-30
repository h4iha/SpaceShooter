using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.EventSystems.EventTrigger;

public class EnemySpawned : MonoBehaviour
{
    private GameManager gameManager;
    [Header("Enemy")]
    [SerializeField] private int levelEnemy;
    [SerializeField] private float rateOfFire;
    [Space]
    [Header("Spawn")]
    [SerializeField] private int totalEnemies;
    [SerializeField] private List<Transform> spawnPoints;
    [SerializeField] private GameObject enemyPrefab;
    [Header("Enemies")]
    [SerializeField] private Transform enemyParent;
    [SerializeField] private List<EnemySpaceShip> enemies;
    private bool isCoolDown;
    private void Start()
    {
        gameManager = GameManager.Instance;
        enemyPrefab = Resources.Load<GameObject>("Prefabs/Objects/EnemyPrefab");
        SpawnRandom();
        isCoolDown = false;
    }
    private void Update()
    {
        if (enemyParent.transform.childCount == 0)
        {
            //gameManager.DoNextRound();
            return;
        }
        if (!isCoolDown)
        {
            StartCoroutine(CoolDownFire());
        }
    }
    private void SpawnRandom()
    {
        for (int i = 0; i < totalEnemies; i++)
        {
            int random = UnityEngine.Random.Range(0, spawnPoints.Count - 1);
            Vector3 spawnPosition = spawnPoints[random].position;
            Vector3 rotation = new Vector3(0, 0, 90);
            //Enemy enemy = Instantiate(enemyPrefab, spawnPosition, Quaternion.Euler(rotation), enemyParent.transform).GetComponent<Enemy>();
            // Set Action
           // enemy.onEnemyDestroyed = HandleRemoveEnemy;
            // Set level
            //enemy.SetLevel(levelEnemy);
            // add list
            //enemies.Add(enemy);
            spawnPoints.Remove(spawnPoints[random]);
        }
    }
    //private void HandleRemoveEnemy(Enemy enemy)
    //{
    //    enemies.Remove(enemy);
    //}
    private IEnumerator CoolDownFire()
    {
        isCoolDown = true;
        int max = 0;
        for (int i = 0; i < enemies.Count; i++)
        {
            int random = UnityEngine.Random.Range(0, 3);
            if (random % 2 == 0 && max < 3)
            {
                //enemies[i].FireByEnemy();
                max++;
            }
        }
        yield return new WaitForSeconds(1 / rateOfFire);
        isCoolDown = false;
    }
}
