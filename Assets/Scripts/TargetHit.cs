using UnityEngine;

public class TargetHit : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Ball"))
        {
            GameManager.AddScore();
            Destroy(gameObject);
        }
    }
}
