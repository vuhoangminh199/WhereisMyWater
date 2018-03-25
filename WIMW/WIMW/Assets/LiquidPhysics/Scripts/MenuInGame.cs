using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuInGame : MonoBehaviour {

	public GameObject canvas_2;
    public GameObject duckItem1,duckItem2,duckItem3;
	public GameObject btn_pause;
    public GameObject btn_reset;
    public GameObject canvas_3;
    public GameObject duck_final_1;
    public GameObject duck_final_2;
    public GameObject duck_final_3;
    public GameObject text_final;
    public GameObject text_level;
    public static MenuInGame instance;
    public static int sum;
    public static int level;

    void Awake(){
		_MakeSingleInstance();
	}
    
    void Start(){
        sum = 0 ;
        if (level == 11){
            text_level.GetComponent<UnityEngine.UI.Text>().text = "1-1";
        } else if (level == 12){
            text_level.GetComponent<UnityEngine.UI.Text>().text = "1-2";
        } else if (level == 13){
            text_level.GetComponent<UnityEngine.UI.Text>().text = "1-3";
        } else if (level == 14){
            text_level.GetComponent<UnityEngine.UI.Text>().text = "1-4";
        }
    }

	public void onPressPause() {
		canvas_2.SetActive(true);
		btn_pause.SetActive(false);
        btn_reset.SetActive(false);
        Time.timeScale = 0.0f;
       
	}

	public void onPressContinue() {
		canvas_2.SetActive(false);
		btn_pause.SetActive(true);
        btn_reset.SetActive(true);
        Time.timeScale = 1.0f;
	}

	public void onPressHome() {
        Time.timeScale = 1.0f;
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

    public void onGameOver(){
		duckItem1.SetActive(false);
		duckItem2.SetActive(false);
        duckItem3.SetActive(false);
        canvas_2.SetActive(false);
		btn_pause.SetActive(false);
        btn_reset.SetActive(false);
        canvas_3.SetActive(true);
        if (sum == 1){
            text_final.GetComponent<UnityEngine.UI.Text>().text = "Bad!";
            duck_final_1.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/ducky");
        } else if (sum == 2){
            text_final.GetComponent<UnityEngine.UI.Text>().text = "Good!";
            duck_final_1.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/ducky");
            duck_final_2.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/ducky");
        } else if(sum == 3){
            text_final.GetComponent<UnityEngine.UI.Text>().text = "Excellent!";
            duck_final_1.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/ducky");
            duck_final_2.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/ducky");
            duck_final_3.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/ducky");
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

    public void onPressLevels(){
            if (level == 11){
                Application.LoadLevel("Level1_1");
            } else if (level == 12){
                Application.LoadLevel("Level1_2");
            } else if (level == 13){
                Application.LoadLevel("Level1_3");
            } else if (level == 14){
                Application.LoadLevel("Level1_4");
            }			
	}

    public void onPressNextLevel(){
        checkLevel();
        if (level == 11) {
            Application.LoadLevel("Level1_1");
            MapController.instance.checkMap();
        } else if(level == 12) {
            Application.LoadLevel("Level1_2");
            MapController.instance.checkMap();
        } else if (level == 13){
            Application.LoadLevel("Level1_3");
        } else if (level == 14){
            Application.LoadLevel("Level1_4");
        }	
    }
    private void checkLevel(){
         if (level == 11) {
            level = 12;
            return;
        } else if (level == 12){
            level = 13;
            return;
        } else if (level == 13){
            level = 14;
            return;
        } else if (level == 14){
            return;
        }
    }

    public void onPressRepeat(){	
			if (level == 11){
                Application.LoadLevel("Level1_1");
            } else if (level == 12){
                Application.LoadLevel("Level1_2");
            } else if (level == 13){
                Application.LoadLevel("Level1_3");
            } else if (level == 14){
                Application.LoadLevel("Level1_4");
            }			
	}

    public void onOutOfWater(){	
		CheckLevel();		
	}

    IEnumerator CheckLevel() {
        
        yield return new WaitForSeconds(2);
        if (level == 11){
                Application.LoadLevel("Level1_1");
            } else if (level == 12){
                Application.LoadLevel("Level1_2");
            } else if (level == 13){
                Application.LoadLevel("Level1_3");
            } else if (level == 14){
                Application.LoadLevel("Level1_4");
            }
    }
}
