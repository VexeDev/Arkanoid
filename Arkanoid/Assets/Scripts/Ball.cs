using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    public float ballSpeed = 100f;

    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.up * ballSpeed;
        //setting current speed to the speed set in variable above
    }

    //whenever anything is touched
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //if touching racket...
        if (collision.gameObject.name == "racket")
        {
            float x = hitFactor(transform.position, collision.transform.position, collision.collider.bounds.size.x);
            Vector2 dir = new Vector2(x, 1).normalized;
            GetComponent<Rigidbody2D>().velocity = dir * ballSpeed;
        }
    }

    float hitFactor(Vector2 ballPos, Vector2 racketPos, float racketWidth)
    {
        return (ballPos.x - racketPos.y) / racketWidth;
    }

    public void Despawn()
    {
        GameObject.Destroy(gameObject);
    }
}
