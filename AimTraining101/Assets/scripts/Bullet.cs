using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Score scoreScript;
    public float destroyTimer = 3f;

    private void Start()
    {
        scoreScript = GameObject.Find("ScoreTarget").GetComponent<Score>();
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Target")
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
            scoreScript.AddScore();
        }
        Destroy(gameObject, destroyTimer);
    }
}
