using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Racket : MonoBehaviour
{

    public float racketSpeed = 150f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        //does it just know automatically that a and d mean left and right?

        GetComponent<Rigidbody2D>().velocity = Vector2.right * h * racketSpeed;
    }
}
