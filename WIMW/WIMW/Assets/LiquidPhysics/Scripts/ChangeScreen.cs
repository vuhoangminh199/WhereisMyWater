using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeScreen : MonoBehaviour {
	public GameObject canvas_1;
	
	public GameObject canvas_2;
	
	public GameObject canvas_3;
	
	public GameObject img_canvas_2_1;
	
	public GameObject img_canvas_2_2;

	public GameObject title_canvas_3;

	public void ChangeScreenMenu(string sceneName) {
		Application.LoadLevel(sceneName);
	}

	public void onPressPlayFirstScreen(){
		canvas_2.SetActive(true);
		canvas_1.SetActive(false);
		canvas_3.SetActive(false);
		img_canvas_2_1.SetActive(true);
		img_canvas_2_2.SetActive(true);
	}

	public void onPressLv(int lv){
		canvas_2.SetActive(false);
		canvas_1.SetActive(false);
		canvas_3.SetActive(true);
		img_canvas_2_1.SetActive(false);
		img_canvas_2_2.SetActive(false);
		if (lv == 1) {
			title_canvas_3.GetComponent<UnityEngine.UI.Text>().text =  "\"Lever 1\"";
		} else if (lv == 2){
			title_canvas_3.GetComponent<UnityEngine.UI.Text>().text = "\"Lever 2\"";
		}
		
	}

	public void onPressBack_CV2(){
		canvas_2.SetActive(false);
		canvas_1.SetActive(true);
		canvas_3.SetActive(false);
		img_canvas_2_1.SetActive(false);
		img_canvas_2_2.SetActive(false);
	}

	public void onPressBack_CV3(){
		canvas_2.SetActive(true);
		canvas_1.SetActive(false);
		canvas_3.SetActive(false);
		img_canvas_2_1.SetActive(true);
		img_canvas_2_2.SetActive(true);	
	}
}
