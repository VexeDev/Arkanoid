using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Despawn : MonoBehaviour
{
    public GameObject eventSystem;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        collision.GetComponent<Ball>().Despawn();
        eventSystem.GetComponent<BallManager>().ballCount--;
        eventSystem.GetComponent<BallManager>().ballChange();
    }
}
