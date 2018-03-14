using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuInGame : MonoBehaviour {

	public GameObject canvas_2;

	public GameObject btn_pause;

	private bool paused = false;

	public void onPressPause() {
		canvas_2.SetActive(true);
		btn_pause.SetActive(false);
		paused = togglePause();
	}

	public void onPressContinue() {
		canvas_2.SetActive(false);
		btn_pause.SetActive(true);
	}

	public void onPressHome() {
		Application.LoadLevel("SplashScreen");
	}

	void OnGUI()
     {
         if(paused)
         {
           paused = togglePause();     
         }
     }

	bool togglePause()
     {
         if(Time.timeScale == 0f)
         {
             Time.timeScale = 1f;
             return(false);
         }
         else
         {
             Time.timeScale = 0f;
             return(true);    
         }
     }

}
