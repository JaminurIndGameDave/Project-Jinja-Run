using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerControll : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    Vector2 currentPosition ;
    Vector2 YUpPosition = new Vector2(-1.32f, 3.49f);
    Vector2 YDownPosition = new Vector2(-1.32f, -3.07f); 
    bool isAtPositionUp;
    private void Awake()
    {
        currentPosition = new Vector2(-1.32f, -3.04f);
    }
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(speed, 0);
        if (!isMouseOnUI())
        {
            if (Input.GetMouseButtonDown(0))
            {
                SwitchDirection();
               // Debug.Log("Click!!");
            }
        }
        
        

    }

    void SwitchDirection() 
    {
       // currentPosition = transform.position;
        
        if (isAtPositionUp)
        {
            transform.position = YDownPosition;
            transform.localScale = new Vector3(transform.localScale.x,.25f,transform.localScale.z);
        }
        else
        {
            transform.position = YUpPosition;
            transform.localScale = new Vector3(transform.localScale.x, -.25f, transform.localScale.z);
        }
        isAtPositionUp = !isAtPositionUp;
        
    }

    bool isMouseOnUI() 
    {
        return EventSystem.current.IsPointerOverGameObject();
    }
}
