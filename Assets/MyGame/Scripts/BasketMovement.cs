using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketMovement : MonoBehaviour
{
    private Rigidbody2D myBody;

    public float speed;
    public FoodScript controller;

    void Start()
    {
        myBody = GetComponent<Rigidbody2D>();  
    }

    
    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");

        if (h > 0)

            myBody.velocity = Vector2.right * speed;

        else if (h < 0)

            myBody.velocity = Vector2.left * speed;

        else
            myBody.velocity = Vector2.zero;
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        var bad = col.transform.GetComponent<Food>().bad;
        
        if(!bad)
        {
            controller.score += 10;
        }
        Destroy(col.gameObject);
    }
}
