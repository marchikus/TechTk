using UnityEngine;
using UnityEngine.SceneManagement;

public class Reseter : MonoBehaviour
{
    [SerializeField] private GameObject youwin;
    [SerializeField] private Saver saver;
    [SerializeField] private GameSettings gameSettings;

    public void ResetButton()
    {
        if (youwin != null)
        {
            youwin.SetActive(false);
        }

        saver.DeleteSaveFile();
        GameModel.ResetValues();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
