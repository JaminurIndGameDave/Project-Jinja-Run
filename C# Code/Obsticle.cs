using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obsticle : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed,incSpeed;
   

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        incSpeed = 5;
        speed = incSpeed;
    }
    void Start()
    {
        
        // rb.gravityScale = 0; 
        
    }

    // Update is called once per frame
    void Update()
    {




        IncSpeed_01();


        rb.velocity = new Vector2(-speed,0);
        Debug.Log(speed);
    }
    public void IncSpeed_01() 
    {
        if (FindObjectOfType<GameManager>().score >=20 && speed <=10)
        {
            speed = speed +  1f*Time.deltaTime;
        }
        else if (FindObjectOfType<GameManager>().score >= 60 && speed <= 25)
        {
            speed = speed + 2f * Time.deltaTime;
        }
        
    
    }
    void IncSpeed_02() 
    {
        /*  if (FindObjectOfType<GameManager>().score >= 20)
            {
                float minSpeed = 5f;
                float maxSpeed = 16f;
                float targetSpeed = minSpeed + 0.01f;

                if (targetSpeed <= maxSpeed)
                {
                    speed = targetSpeed;
                }
                else
                {
                    speed = maxSpeed; // Cap the speed at the maximum value
                }
            }
            else if (FindObjectOfType<GameManager>().score >= 100)
            {
                float minSpeed = 10f;
                float maxSpeed = 25f;
                float targetSpeed = minSpeed + 0.01f;

                if (targetSpeed <= maxSpeed)
                {
                    speed = targetSpeed;
                }
                else
                {
                    speed = maxSpeed; // Cap the speed at the maximum value
                }
            }
            else
            {
                speed = incSpeed;
            }*/

    }
}
