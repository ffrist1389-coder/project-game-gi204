using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditManager : MonoBehaviour
{
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("MenuScene");
    }
}
