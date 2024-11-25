using UnityEngine;

public class GameModel
{
    private SaveData savedData;
    public static int Shovel = MaxShovel;
    public static int GoldCount = 0;

    public const int MaxShovel = 10;
    public const int MaxGold = 4;

    public event System.Action<GameModel> OnShovelChanged;
    public event System.Action<GameModel> OnGoldChanged; 

    public void UseShovel()
    {
        if (Shovel > 0)
        {
            Shovel--;
            OnShovelChanged?.Invoke(this);
        }
    }

    public void AddGold()
    {
        if (GoldCount < MaxGold)
        {
            GoldCount++;
            OnGoldChanged?.Invoke(this);
            Debug.Log("Gold added. New GoldCount: " + GoldCount);
        }
    }

    public static void ResetValues()
    {
        Shovel = MaxShovel;
        GoldCount = 0;
    }

    public void HaveSave()
    {
        savedData = LoadSavedGameData();

        if (savedData != null)
        {
            Shovel = savedData.shovels;
            GoldCount = savedData.collectedGold;
        }

    }

    private SaveData LoadSavedGameData()
    {
        return new Saver().LoadGame();
    }

    public bool GetShovelCount() => Shovel == 0;
    public bool GetGoldCount() => GoldCount == MaxGold;
}
