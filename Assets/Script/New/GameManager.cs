using System;
using System.Runtime.Serialization;
using UnityEngine;
public enum TagCharacter
{
    [EnumMember(Value = "Player")] Player,
    [EnumMember(Value = "Enemy")] Enemy,
    [EnumMember(Value = "Shield")] Shield,
}
public enum TagLaserBeam
{
    [EnumMember(Value = "P_LaserBeam")] Player,
    [EnumMember(Value = "E_LaserBeam")] Enemy,
}
public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    public static GameManager Instance
    {
        get { return instance; }
    }

    [Header("Sprite")]
    [SerializeField] private Data spriteData;
    private int indexPlayer;
    private Sprite playeSpaceShipSprite;
    private Sprite[] p_LaserBeamSprites;
    private Sprite[] enemySpaceShips;
    private Sprite e_LaserBeamSprite;
    private Sprite[] powerUpSprites;
    private Sprite[] shieldSprites;
    [Space]
    [Header("Stats")]
    [SerializeField] private int maxLives;
    [SerializeField] private int maxLevelLaser;
    [SerializeField] private int maxLevelShield;
    private int curretnLives;
    private int currentLevelLaser;
    private int currentLevelShield;
    [Space]
    [Header("Score System")]
    private int currentScores;
    #region Sprite
    public Sprite PlayerSpaceShipSprite { get { return playeSpaceShipSprite; } }
    public Sprite[] P_LaserBeamSprites { get { return p_LaserBeamSprites; } }
    public Sprite[] EnemySpaceShipSprites { get { return enemySpaceShips; } }
    public Sprite E_LaserBeamSprite { get { return e_LaserBeamSprite; } }
    public Sprite[] PowerUpSprites { get { return powerUpSprites; } }
    public Sprite[] ShieldSprites { get { return shieldSprites; } }

    public Sprite GetNumber(int number) { return spriteData.Numbers[number]; }
    #endregion
    public int CurrentScores { get { return currentScores; } }
    #region Player
    public int MaxHearts { get { return maxLives; } }
    public int MaxLevelLaser { get { return maxLevelLaser; } }
    public int MaxLevelShield { get { return maxLevelShield; } }
    public int CurrentHearts { get { return curretnLives; } set { curretnLives = value; } }
    public int CurrentLevelLaser { get { return currentLevelLaser; } set { curretnLives = value; } }
    public int CurrentLevelShield { get { return currentLevelShield; } set { curretnLives = value; } }
    #endregion
    private void Awake()
    {
        instance = this;
        DontDestroyOnLoad(gameObject);
    }
    private void Start()
    {
        p_LaserBeamSprites = new Sprite[4];
        enemySpaceShips = new Sprite[5];
        powerUpSprites = new Sprite[3];
        ResetCurrentStat();
        UpdateAllSpriteSources();
    }
    public void ResetCurrentStat()
    {
        curretnLives = maxLives;
        currentLevelLaser = 1;
        currentLevelShield = 0;
    }
    public void UpdateAllSpriteSources(int index = 0)
    {
        // Neu mau cam kh co thi set thanh mau do
        int indexNoOrange = index;
        if (index >= 9) indexNoOrange = index - 9;
        // Player's Sprite
        playeSpaceShipSprite = spriteData.PlayerSpaceShips[index];
        //player.GetComponent<SpriteRenderer>().sprite = playeSpaceShipSprite;
        // index cua laser level 1
        int indexPlayerLaser0 = indexNoOrange * 3 + index;
        for (int i = 0; i < 4; i++)
        {// Player Laser's Sprite
            p_LaserBeamSprites[i] = spriteData.P_LaserBeams[indexPlayerLaser0 + i];
        }
        // Player Shield's Sprite
        shieldSprites = spriteData.Shields;
        // index cua enemy level 1
        for (int i = 0; i < 5; i++)
        {
            // Enemy's Sprite
            enemySpaceShips[i] = spriteData.EnemySpaceShips[index/3 * 5 + i];
        }
        // Enemy Laser's Sprite
        e_LaserBeamSprite = spriteData.E_LaserBeam;
        // Heart Award's Sprite
        powerUpSprites[0] = spriteData.PowerUpLives[index];
        // Laser Award's Sprite
        powerUpSprites[1] = spriteData.PowerUpLaserBeams[index/3];
        // Shield Award's Sprite
        powerUpSprites[2] = spriteData.PowerUpShields[index/3];
    }
    // UI GamePlay
    private void ResetScores()
    {
        currentScores = 0;
    }
    public void AddScores(int scores)
    {
        if ((999999 - currentScores) < scores)
        {
            currentScores = 999999;
        }
        else
        {
            currentScores += scores;
        }
    }

}
