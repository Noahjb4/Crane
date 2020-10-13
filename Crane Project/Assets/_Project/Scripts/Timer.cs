using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text TimerText; 
    public bool playing;
    private float timer;

    private void Start()
    {
        playing = false;
    }

    void Update () {

 	    if(playing == true){
  
	    timer += Time.deltaTime;
	    int minutes = Mathf.FloorToInt(timer / 60F);
	    int seconds = Mathf.FloorToInt(timer % 60F);
	    int milliseconds = Mathf.FloorToInt((timer * 100F) % 100F);
	    TimerText.text = minutes.ToString ("00") + ":" + seconds.ToString ("00") + ":" + milliseconds.ToString("00");
	}

    
  }
    public void pauseTimer() {
        if(playing == true)
        {
            playing = false;
        }
        else
        {
            playing = true;
        }

    }

}
