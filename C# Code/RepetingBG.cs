using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepetingBG : MonoBehaviour
{
    public float speed;
    public float endX, startX;
    public float incSpeed, speedLimit;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (speed <=speedLimit)
        {
            speed += incSpeed;
        }
        if (FindObjectOfType<GameManager>().isGAmeStart==true)
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
            if (transform.position.x <= endX)
            {
                Vector2 pos = new Vector2(startX, transform.position.y);
                transform.position = pos;
            }
        }
        
    }
}
