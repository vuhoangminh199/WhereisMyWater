using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuInGame : MonoBehaviour {

	public GameObject canvas_2;
    public GameObject duckItem1,duckItem2,duckItem3;
	public GameObject btn_pause;
    public static MenuInGame instance;
	private bool paused = false;
    private int sum =0;
    void Awake(){
		_MakeSingleInstance();
	}
    
    void Start(){
        sum = 0 ;
    }

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

    public void changeDuckColor(int temp){
        sum += temp;
        if (sum == 1){
            duckItem1.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/ducky");
         
        } else if (sum == 2){
            duckItem2.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/ducky");
           
        } else if(sum == 3){
            duckItem3.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/ducky");
        }
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

     void _MakeSingleInstance(){
		if (instance != null){
			Destroy(gameObject);
		} else {
			instance = this;
			DontDestroyOnLoad(instance);
		}
	}

}
