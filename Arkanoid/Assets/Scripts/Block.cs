using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    public GameObject eventSystem;
    public bool isPowerUp = false;
    public GameObject ballPrefab;
    public GameObject BallSpawnLocation;

    private void Start()
    {
        BallSpawnLocation = GameObject.Find("BallSpawnLocation");
        //decide if this is a powerup brick
        int rnd = Random.Range(0, 10);
        if(rnd == 5)
        {
            isPowerUp = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //because each block is a prefab, i had to also make
        //event system a prefab. because event system was a
        //prefab, so was the text object in my score script
        eventSystem.GetComponent<ScoreCount>().ChangeBy(1);
        if(isPowerUp == true)
        {
            Instantiate(ballPrefab, BallSpawnLocation.transform);
            Debug.Log("ball instantiated");
            eventSystem.GetComponent<BallManager>().ballCount += 1;
        }
        Destroy(gameObject);
    }
}
