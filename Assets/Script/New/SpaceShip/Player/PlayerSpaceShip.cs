using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
public class PlayerSpaceShip : MonoBehaviour
{
    private GameManager gameManager;
    [Header("Sprites")]
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private Details details;
    [SerializeField] private Fire fire;
    [SerializeField] private ShieldSpaceShip shieldSpaceShip;
    [SerializeField] private ObjectDesign prefabDrawing;
    //[SerializeField] private TagLaserBeam laserTagForEnemy;
    [SerializeField] private TagName[] tagNames;
    [SerializeField] private Undying undying;
    //private string[] allTag;
    [Header("Stats")]
    private Stats stats;
    private LaserBeam laserBeamPrefab;
    private LaserBeam laserBeam;
    private Vector3 transformStart;
    private List<string> listTags = new List<string>();

    private void Awake()
    {
        gameManager = GameManager.Instance;
        //laserBeamPrefab = gameManager.P_LaserBeams[0].GetComponent<LaserBeam>();
        UpdateStats();
        UpdateLaserBeam();
        UpdateFire();
    }
    private void UpdateStats()
    {
        stats = new Stats(gameManager.CurrentLives, true);
        details.CreateNewStats(stats);
    }
    private void UpdateLaserBeam()
    {
        laserBeam = Instantiate(laserBeamPrefab, transform.position + new Vector3(10, 10, 10), transform.rotation);
        laserBeam.SetDamage = stats.LevelLaserBeam;
        laserBeam.tag = TagLaserBeam.Player.ToString();
    }
    private void UpdateFire()
    {
        //fire = this.AddComponent<Fire>();
        fire.IsAutomatic = true;
        fire.LaserBeamPrefab = laserBeam.gameObject;
        fire.RateOfFire = stats.RateOfFire;
        fire.SpeedProjectTile = stats.SpeedProjectTile;
    }
    private void HandleDeath()
    {
        transform.position = transformStart;
        undying.gameObject.SetActive(true);
    }
    private void HandleGameOver()
    {
        Destroy(gameObject);
    }
    public void PickUpLaserBeam(int value = 1)
    {
        details.onIncreaseLevelLaserBeam?.Invoke(value);
    }
    public void PickUpShield(int value = 1)
    {
        details.onIncreaseLevelShield?.Invoke(value);
    }
    public void PickUpLive(int value = 1)
    {
        details.onIncreaseLives?.Invoke(value);
    }
}
