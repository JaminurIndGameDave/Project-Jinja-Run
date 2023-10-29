using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public GameObject coinPrticleGameObject;
   
    private void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="Player")
        {
            FindObjectOfType<GameManager>().score += 5;
            FindObjectOfType<GameManager>().scoreInGameOverPanel += 5;
            
            Instantiate(coinPrticleGameObject,transform.position,Quaternion.identity);
            Destroy(gameObject);
            FindObjectOfType<AudioManager>().Play("Coin");
        }
    }
}
