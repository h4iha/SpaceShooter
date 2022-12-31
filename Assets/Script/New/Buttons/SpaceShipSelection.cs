using System;
using UnityEngine;
using UnityEngine.UI;

public class SpaceShipSelection : MonoBehaviour
{
    private GameManager gameManager;
    [SerializeField] private Image image;
    private IndexChanger typeIndexChanger;
    private IndexChanger colorIndexChanger;
    public void Start()
    {
        gameManager = GameManager.Instance;
        image.sprite = gameManager.PlayerSpaceShipSprite;
        typeIndexChanger = new IndexChanger(2, HandleIndexChanged);
        colorIndexChanger = new IndexChanger(3, HandleIndexChanged);
        ResetIndex();
    }
    public void ChangeColor()
    {
        colorIndexChanger.NextIndex();
    }
    public void ChangeType()
    {
        typeIndexChanger.NextIndex();

    }
    private void ResetIndex()
    {
        gameManager.UpdateAllSpriteSources(typeIndexChanger.GetCurrentIndex + colorIndexChanger.GetCurrentIndex * 3);
        typeIndexChanger.Reset();
        colorIndexChanger.Reset();
    }

    private void HandleIndexChanged()
    {
        gameManager.UpdateAllSpriteSources(typeIndexChanger.GetCurrentIndex + colorIndexChanger.GetCurrentIndex * 3);
        image.sprite = gameManager.PlayerSpaceShipSprite;
    }
}
public class IndexChanger
{
    private int maxIndex;
    private int currentIndex;

    private Action onIndexChanged;

    public IndexChanger(int maxIndex, Action onIndexChanged)
    {
        this.maxIndex = maxIndex;
        this.currentIndex = 0;
        this.onIndexChanged = onIndexChanged;
    }

    public void NextIndex()
    {
        currentIndex += 1;
        if (currentIndex > maxIndex)
        {
            currentIndex = 0;
        }
        onIndexChanged?.Invoke();
    }

    public int GetCurrentIndex { get { return currentIndex; } }
    public void Reset()
    {
        currentIndex = 0;
        onIndexChanged?.Invoke();
    }
}