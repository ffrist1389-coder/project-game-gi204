using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject howToPlayPanel;

    public void StartGame()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void ShowHowToPlay()
    {
        howToPlayPanel.SetActive(true);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
