using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeScreen : MonoBehaviour {
	public GameObject canvas_1;
	
	public GameObject canvas_2;
	
	public GameObject canvas_lv1;

	public GameObject canvas_lv2;
	
	public GameObject img_canvas_2_1;
	
	public GameObject img_canvas_2_2;

	public GameObject title_canvas_3;

	public static ChangeScreen instance;
	
	public bool flagCheckLv = false;

	public void ChangeScreenMenu(string sceneName) {
		Application.LoadLevel(sceneName);
	}

	public void onPressPlayFirstScreen(){
		canvas_2.SetActive(true);
		canvas_1.SetActive(false);
		canvas_lv1.SetActive(false);
		canvas_lv2.SetActive(false);
		img_canvas_2_1.SetActive(true);
		img_canvas_2_2.SetActive(true);
	}

	public void onPressLv(int lv){
		if (lv == 1) {
			title_canvas_3.GetComponent<UnityEngine.UI.Text>().text =  "\"Lever 1\"";
			flagCheckLv = false;
			canvas_2.SetActive(false);
			canvas_1.SetActive(false);
			canvas_lv1.SetActive(true);
			canvas_lv2.SetActive(true);
			img_canvas_2_1.SetActive(false);
			img_canvas_2_2.SetActive(false);
		} else if (lv == 2){
			title_canvas_3.GetComponent<UnityEngine.UI.Text>().text = "\"Lever 2\"";
			flagCheckLv = true;
			canvas_2.SetActive(false);
			canvas_1.SetActive(false);
			canvas_lv2.SetActive(true);
			canvas_lv1.SetActive(false);
			img_canvas_2_1.SetActive(false);
			img_canvas_2_2.SetActive(false);
		}
		
	}

	public void onPressBack_CV2(){
		canvas_2.SetActive(false);
		canvas_1.SetActive(true);
		canvas_lv1.SetActive(false);
		img_canvas_2_1.SetActive(false);
		img_canvas_2_2.SetActive(false);
	}

	public void onPressBack_CV3(){
		canvas_2.SetActive(true);
		canvas_1.SetActive(false);
		canvas_lv1.SetActive(false);
		img_canvas_2_1.SetActive(true);
		img_canvas_2_2.SetActive(true);	
	}

	public void onPressLv1(int lv){
		// canvas_2.SetActive(true);
		// canvas_1.SetActive(false);
		// canvas_3.SetActive(false);
		// img_canvas_2_1.SetActive(true);
		// img_canvas_2_2.SetActive(true);	
		if (lv == 1){
			MenuInGame.level = 11;
			Application.LoadLevel("Level1_1");
		} else if (lv == 2) {
			MenuInGame.level = 12;
			Application.LoadLevel("Level1_2");
		} else if (lv == 3){
			MenuInGame.level = 13;
			Application.LoadLevel("Level1_3");
		} else if (lv == 4){
			MenuInGame.level = 14;
			Application.LoadLevel("Level1_4");
		} else if (lv == 5){
			MenuInGame.level = 21;
			Application.LoadLevel("Level2_1");
		}
	}

}
