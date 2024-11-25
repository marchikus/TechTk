using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private ClickableCell clickableCell;
    [SerializeField] private GoldSpawn goldSpawner;

    private GameModel model;

    private void Awake()
    { 
            model = new GameModel();
            model.HaveSave();
    }

    public GameModel Model => model;

    private void Start()
    {
        if (clickableCell != null && goldSpawner != null)
        {
            clickableCell.OnCellClicked += goldSpawner.SpawnGold;
        }
    }
}
