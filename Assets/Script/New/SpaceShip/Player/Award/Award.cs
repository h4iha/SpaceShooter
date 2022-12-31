using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Award : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    [SerializeField] private AwardType type;
    [SerializeField] private ObjectDesign spriteRendererCreation;
    public AwardType Type { get { return type; } }
    private void Start()
    {
        gameManager = GameManager.Instance;
        //spriteRendererCreation.UpdateSpriteRenderer(gameObject, gameManager.AwardSprites[(int)type], true);
    }
    public void SetItem(AwardType awardType, Sprite sprite)
    {
        //spriteRendererCreation.UpdateSpriteRenderer(gameObject, gameManager.AwardSprites[(int)awardType], true);
    }
    private void Update()
    {
        transform.position += Vector3.left * Time.deltaTime * 2;
    }
}
