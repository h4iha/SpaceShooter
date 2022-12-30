using UnityEngine;

public class Data : MonoBehaviour
{
    [Header("Player")]
    private Sprite[] playerSpaceShip;
    private Sprite[] p_LaserBeams;
    private Sprite[] shields;
    [Header("Enemy")]
    private Sprite[] enemySpaceShips;
    private Sprite e_Lasers;
    [Header("Effects")]
    private Sprite explosion;
    [Header("Power Up")]
    private Sprite[] powerUpLives;
    private Sprite[] powerUpLasers;
    private Sprite[] powerUpShields;
    private Sprite[] numbers;
    [Header("Prefab")]
    private GameObject playerPrefab;
    private GameObject[] p_LaserBeamPrefabs;
    private GameObject[] enemyPrefabs;
    private GameObject e_LaserBeamPrefab;
    private GameObject powerUpLivePrefab;
    private GameObject powerUpLaserPrefab;
    private GameObject powerUpShieldPrefab;
    private GameObject effectPrefab;
    private void Awake()
    {
        playerSpaceShip = Resources.LoadAll<Sprite>("Sprites/Player/SpaceShips");
        p_LaserBeams = Resources.LoadAll<Sprite>("Sprites/Player/LaserBeams");
        shields = Resources.LoadAll<Sprite>("Sprites/Player/Shields");
        enemySpaceShips = Resources.LoadAll<Sprite>("Sprites/Enemy/SpaceShips");
        e_Lasers = Resources.Load<Sprite>("Sprites/Enemy/LaserBeams/0");
        explosion = Resources.Load<Sprite>("Sprites/Effects/explosion");
        powerUpLives = Resources.LoadAll<Sprite>("Sprites/PowerUp/Lives");
        powerUpLasers = Resources.LoadAll<Sprite>("Sprites/PowerUp/Lasers");
        powerUpShields = Resources.LoadAll<Sprite>("Sprites/PowerUp/Shields");
        numbers = Resources.LoadAll<Sprite>("Sprites/Numbers");
        // prefabs
        playerPrefab = Resources.Load<GameObject>("Prefabs/SpaceShips/Player");
        p_LaserBeamPrefabs = Resources.LoadAll<GameObject>("Prefabs/LaserBeams/P_laserBeamPrefabs");
        //enemyPrefabs = Resources.LoadAll<GameObject>("Prefabs/SpaceShips/Enemies");
        e_LaserBeamPrefab = Resources.Load<GameObject>("Prefabs/LaserBeams/E_laserBeamPrefab");
        powerUpLivePrefab = Resources.Load<GameObject>("Prefabs/PowerUp/PowerUpLivePrefab");
        powerUpLaserPrefab = Resources.Load<GameObject>("Prefabs/PowerUp/PowerUpLaserBeamPrefab");
        powerUpShieldPrefab = Resources.Load<GameObject>("Prefabs/PowerUp/PowerUpLivePrefab");
        effectPrefab = Resources.Load<GameObject>("Prefabs/EffectPrefab");
    }
    public Sprite[] PlayerSpaceShips { get { return playerSpaceShip; } }
    public Sprite[] P_LaserBeams { get { return p_LaserBeams; } }
    public Sprite[] Shields { get { return shields; } }
    public Sprite[] EnemySpaceShips { get { return enemySpaceShips; } }
    public Sprite E_LaserBeam { get { return e_Lasers; } }
    public Sprite Explosion { get { return explosion; } }
    public Sprite[] PowerUpLives { get { return powerUpLives; } }
    public Sprite[] PowerUpLaserBeams { get { return powerUpLasers; } }
    public Sprite[] PowerUpShields { get { return powerUpShields; } }
    public Sprite[] Numbers { get { return numbers; } }
    // Prefabs
    public GameObject PlayerPrefab { get { return playerPrefab; } }
    public GameObject[] EnemyPrefabs { get { return enemyPrefabs; } }
    public GameObject LaserBeamPrefab { get { return e_LaserBeamPrefab; } }
    public GameObject PowerUpLivePrefab { get { return powerUpLivePrefab; } }
    public GameObject PowerUpLaserBeamPrefab { get { return powerUpLaserPrefab; } }
    public GameObject PowerUpShieldPrefab { get { return powerUpShieldPrefab; } }
    public GameObject EffectPrefab { get { return effectPrefab; } }
}
