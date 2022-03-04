using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallManager : MonoBehaviour
{
    public int ballCount = 1;
    public bool lost = false;

    public void ballChange ()
    {
        if(ballCount < 1)
        {
            lost = true;
            Lose();
        }
    }

    public void Lose ()
    {
        Debug.Log("lose");
    }
}
