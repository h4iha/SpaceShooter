using Unity.VisualScripting;
using UnityEngine;

public class PlayerSpaceShip : MonoBehaviour
{
    private GameManager gameManager;
    [Header("Sprites")]
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private Fire fire;
    [SerializeField] private ShieldSpaceShip shieldSpaceShip;
    [SerializeField] private PrefabDrawing prefabDrawing;
    [SerializeField] private TagLaserBeam laserTagForEnemy;
    [SerializeField] private Undying undying;
    private Stats stats;
    private LaserBeam laserBeamPrefab;
    private LaserBeam laserBeam;
    private Health playerLives;
    private Health playerHP;
    private Vector3 transformStart;

    private void Awake()
    {
        gameManager = GameManager.Instance;
        transformStart = transform.position;
        spriteRenderer.sprite = gameManager.PlayerSpaceShipSprite;
        prefabDrawing.UpdatePolygon2D(true);
        //laserBeamPrefab = gameManager.P_LaserBeams[0].GetComponent<LaserBeam>();
        UpdateStats();
        UpdateLaserBeam();
        UpdateFire();
    }
    private void UpdateStats()
    {
        stats = new Stats(4, 1, 1, 200, 2.5f);
        playerLives = new Health(stats.MaxLives, HandleGameOver);
        playerHP = new Health(stats.MaxHP, HandleDeath);
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
        fire.RateOfFire = 3;
        fire.SpeedProjectTile = 100;
    }
    private void HandleDeath()
    {
        playerLives.ReceiDamage();
        transform.position = transformStart;
        undying.gameObject.SetActive(true);
    }
    private void HandleGameOver()
    {
        Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(laserTagForEnemy.ToString()))
        {
            playerHP.ReceiDamage();
        }
    }
    public void IncreaseLevelLaserBeam()
    {
        stats.IncreaseLevelLaserBeam();
    }
    public void ActiveShield()
    {
        shieldSpaceShip.gameObject.SetActive(true);
    }
}
