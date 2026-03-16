using UnityEngine;

public class TargetHit : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Ball"))
        {
            ScoreManager.instance.AddScore();
            Destroy(gameObject);
        }
    }
}
