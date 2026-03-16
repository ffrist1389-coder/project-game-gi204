using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int score = 0;

    public static void AddScore()
    {
        score += 1;
        Debug.Log("Score: " + score);
    }
}
