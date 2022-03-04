using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //exit
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("leave the game");
            SceneManager.LoadScene(0);
        }
        //reset
        if(Input.GetKeyDown(KeyCode.Equals) && Input.GetKey(KeyCode.Minus) || Input.GetKeyDown(KeyCode.Minus) && Input.GetKey(KeyCode.Equals))
        {
            Debug.Log("reset");
            PlayerPrefs.DeleteAll();
            Application.Quit();
        }
    }
}
