using UnityEngine;

public class GameView : MonoBehaviour
{
    private GameModel model;
    [SerializeField] private GameObject youwin;

    public void Initialize(GameModel gameModel)
    {
        if (gameModel == null)
        {
            return;
        }

        model = gameModel;
        model.OnGoldChanged += UpdateGoldState;
    }

    private void UpdateGoldState(GameModel gameModel)
    {
        if (GameModel.GoldCount == GameModel.MaxGold)
        {
            youwin.SetActive(true);
        }
    }

    private void OnDestroy()
    {
        if (model != null)
        {
            model.OnGoldChanged -= UpdateGoldState;
        }
    }
}
