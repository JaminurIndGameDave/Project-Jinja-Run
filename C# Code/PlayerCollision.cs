using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="Enemy")
        {
            FindObjectOfType<GameManager>().GameOverPanel(); 
            Destroy(gameObject);
            Debug.Log("ENemy");
        }
        if (collision.gameObject.tag=="Coin")
        {
           // Debug.Log("Coin");
        }
    }
}
