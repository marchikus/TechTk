using UnityEngine;

public class Inizial : MonoBehaviour
{
    [SerializeField] private DragAndDrop dragAndDrop;
    private GameView gameView;
    private GoldTexter goldTexter;
    private GameController gameController;

    private void Start()
    {
        gameView = FindObjectOfType<GameView>();
        goldTexter = FindObjectOfType<GoldTexter>();
        gameController = FindObjectOfType<GameController>();

        if (gameController != null)
        {
            var model = gameController.Model;

            dragAndDrop.Initialize(model);
            gameView.Initialize(model);
            goldTexter.Initialize(model);
        }
    }
}