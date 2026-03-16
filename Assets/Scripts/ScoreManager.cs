using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public TextMeshProUGUI scoreText;

    private int score = 0;
    private int totalTargets;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        totalTargets = GameObject.FindGameObjectsWithTag("Target").Length;
        UpdateScoreText();
    }

    public void AddScore()
    {
        score++;
        UpdateScoreText();

        if (score >= totalTargets)
        {
            SceneManager.LoadScene("CreditScene");
        }
    }

    void UpdateScoreText()
    {
        scoreText.text = "Score: " + score;
    }
}
