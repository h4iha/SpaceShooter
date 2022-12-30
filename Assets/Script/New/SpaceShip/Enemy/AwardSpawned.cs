using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class AwardSpawned : MonoBehaviour
{
    private GameManager gameManager;
    private void Start()
    {
        gameManager = GameManager.Instance;
        // score
        //gameManager.AddScores(enemy.Level * 100);
        // spawn item

        int rd = UnityEngine.Random.Range(0, 100);
        if (rd < 70)
        {
            return;
        }
        else if (rd <75)
        {
            //SpawnItem(gameManager.);
            return;
        }
        else if (rd <85)
        {
            //SpawnItem(gameManager.);
            return;
        }
        else
        {
            //SpawnItem(gameManager.);
        }
    }
    private void SpawnItem(GameObject awardPrefab)
    {
        Vector3 rotation = new Vector3(0, 0, -90);
        Instantiate(awardPrefab, transform.position, Quaternion.Euler(rotation));
    }
}

