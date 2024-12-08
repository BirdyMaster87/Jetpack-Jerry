using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Dependencies.Sqlite;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    public ScoreManagerScript scoreManager;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            scoreManager.UpdateScore(10);
            Destroy(gameObject);
        }
    }
}
