using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public bool gamePaused;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        gamePaused = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PauseGame()
    {
        
        if (gamePaused == false)
        {
            gamePaused = true;
            Time.timeScale = 0;
        }
        else
        {
            gamePaused = false;
            Time.timeScale = 1;
        }
    }

   

}
