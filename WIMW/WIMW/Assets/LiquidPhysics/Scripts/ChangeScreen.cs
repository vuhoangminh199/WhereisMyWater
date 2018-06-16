using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeScreen : MonoBehaviour {
	public GameObject canvas_1;
	
	public GameObject canvas_2;
	
	public GameObject canvas_lv1;

	public GameObject canvas_lv2;
	
	public GameObject title_canvas_3;

    public GameObject btn_lv1_1;

    public GameObject btn_lv1_2;

    public GameObject btn_lv1_3;

    public GameObject btn_lv1_4;

    public GameObject btn_lv2_1;

    public GameObject btn_lv2_2;

    public GameObject btn_lv2_3;

    public GameObject btn_lv2_4;

    public static ChangeScreen instance;
	
	public bool flagCheckLv = false;

	private AudioSource audioSource;

    public AudioClip splashClip, subMenuClip;

	void Start(){
		audioSource = GetComponent<AudioSource>();
		audioSource.clip = splashClip;
		audioSource.Play();
	}

	public void ChangeScreenMenu(string sceneName) {
		Application.LoadLevel(sceneName);
	}

	public void onPressPlayFirstScreen(){
		audioSource.Stop();
		audioSource.clip = subMenuClip;
		audioSource.Play();
		canvas_2.SetActive(true);
		canvas_1.SetActive(false);
		canvas_lv1.SetActive(false);
		canvas_lv2.SetActive(false);
	}

	public void onPressLv(int lv){
		if (lv == 1) {
            if (MenuInGame.level1[0] == 0)
            {
                btn_lv1_1.GetComponent<Image>().sprite = Resources.LoadAll<Sprite>("Images/ui")[3];
               
            }
            if (MenuInGame.level1[1] == 0)
            {
                btn_lv1_2.GetComponent<Image>().sprite = Resources.LoadAll<Sprite>("Images/ui")[3];
            }
            if (MenuInGame.level1[2] == 0)
            {
                btn_lv1_3.GetComponent<Image>().sprite = Resources.LoadAll<Sprite>("Images/ui")[3];
            }
            if (MenuInGame.level1[3] == 0)
            {
                btn_lv1_4.GetComponent<Image>().sprite = Resources.LoadAll<Sprite>("Images/ui")[3];
            }

            if (MenuInGame.level1[0] == 1)
            {
                btn_lv1_1.GetComponent<Image>().sprite = Resources.LoadAll<Sprite>("Images/ui")[2];
            }
            if (MenuInGame.level1[1] == 1)
            {
                btn_lv1_2.GetComponent<Image>().sprite = Resources.LoadAll<Sprite>("Images/ui")[2];
            }
            if (MenuInGame.level1[2] == 1)
            {
                btn_lv1_3.GetComponent<Image>().sprite = Resources.LoadAll<Sprite>("Images/ui")[2];
            }
            if (MenuInGame.level1[3] == 1)
            {
                btn_lv1_4.GetComponent<Image>().sprite = Resources.LoadAll<Sprite>("Images/ui")[2];
            }

            if (MenuInGame.level1[0] == 2)
            {
                btn_lv1_1.GetComponent<Image>().sprite = Resources.LoadAll<Sprite>("Images/ui")[1];
            }
            if (MenuInGame.level1[1] == 2)
            {
                btn_lv1_2.GetComponent<Image>().sprite = Resources.LoadAll<Sprite>("Images/ui")[1];
            }
            if (MenuInGame.level1[2] == 2)
            {
                btn_lv1_3.GetComponent<Image>().sprite = Resources.LoadAll<Sprite>("Images/ui")[1];
            }
            if (MenuInGame.level1[3] == 2)
            {
                btn_lv1_4.GetComponent<Image>().sprite = Resources.LoadAll<Sprite>("Images/ui")[1];
            }

            if (MenuInGame.level1[0] == 3)
            {
                btn_lv1_1.GetComponent<Image>().sprite = Resources.LoadAll<Sprite>("Images/ui")[0];
            }
            if (MenuInGame.level1[1] == 3)
            {
                btn_lv1_2.GetComponent<Image>().sprite = Resources.LoadAll<Sprite>("Images/ui")[0];
            }
            if (MenuInGame.level1[2] == 3)
            {
                btn_lv1_3.GetComponent<Image>().sprite = Resources.LoadAll<Sprite>("Images/ui")[0];
            }
            if (MenuInGame.level1[3] == 3)
            {
                btn_lv1_4.GetComponent<Image>().sprite = Resources.LoadAll<Sprite>("Images/ui")[0];
            }

            title_canvas_3.GetComponent<UnityEngine.UI.Text>().text =  "\"Level 1\"";
			flagCheckLv = false;
			canvas_2.SetActive(false);
			canvas_1.SetActive(false);
			canvas_lv1.SetActive(true);
			canvas_lv2.SetActive(false);
		} else if (lv == 2){
            if (MenuInGame.level2[0] == 0)
            {
                btn_lv2_1.GetComponent<Image>().sprite = Resources.LoadAll<Sprite>("Images/ui")[3];

            }
            if (MenuInGame.level2[1] == 0)
            {
                btn_lv2_2.GetComponent<Image>().sprite = Resources.LoadAll<Sprite>("Images/ui")[3];
            }
            if (MenuInGame.level2[2] == 0)
            {
                btn_lv2_3.GetComponent<Image>().sprite = Resources.LoadAll<Sprite>("Images/ui")[3];
            }
            if (MenuInGame.level2[3] == 0)
            {
                btn_lv2_4.GetComponent<Image>().sprite = Resources.LoadAll<Sprite>("Images/ui")[3];
            }

            if (MenuInGame.level2[0] == 1)
            {
                btn_lv2_1.GetComponent<Image>().sprite = Resources.LoadAll<Sprite>("Images/ui")[2];
            }
            if (MenuInGame.level2[1] == 1)
            {
                btn_lv2_2.GetComponent<Image>().sprite = Resources.LoadAll<Sprite>("Images/ui")[2];
            }
            if (MenuInGame.level2[2] == 1)
            {
                btn_lv2_3.GetComponent<Image>().sprite = Resources.LoadAll<Sprite>("Images/ui")[2];
            }
            if (MenuInGame.level2[3] == 1)
            {
                btn_lv2_4.GetComponent<Image>().sprite = Resources.LoadAll<Sprite>("Images/ui")[2];
            }

            if (MenuInGame.level2[0] == 2)
            {
                btn_lv2_1.GetComponent<Image>().sprite = Resources.LoadAll<Sprite>("Images/ui")[1];
            }
            if (MenuInGame.level2[1] == 2)
            {
                btn_lv2_2.GetComponent<Image>().sprite = Resources.LoadAll<Sprite>("Images/ui")[1];
            }
            if (MenuInGame.level2[2] == 2)
            {
                btn_lv2_3.GetComponent<Image>().sprite = Resources.LoadAll<Sprite>("Images/ui")[1];
            }
            if (MenuInGame.level2[3] == 2)
            {
                btn_lv2_4.GetComponent<Image>().sprite = Resources.LoadAll<Sprite>("Images/ui")[1];
            }

            if (MenuInGame.level2[0] == 3)
            {
                btn_lv2_1.GetComponent<Image>().sprite = Resources.LoadAll<Sprite>("Images/ui")[0];
            }
            if (MenuInGame.level2[1] == 3)
            {
                btn_lv2_2.GetComponent<Image>().sprite = Resources.LoadAll<Sprite>("Images/ui")[0];
            }
            if (MenuInGame.level2[2] == 3)
            {
                btn_lv2_3.GetComponent<Image>().sprite = Resources.LoadAll<Sprite>("Images/ui")[0];
            }
            if (MenuInGame.level2[3] == 3)
            {
                btn_lv2_4.GetComponent<Image>().sprite = Resources.LoadAll<Sprite>("Images/ui")[0];
            }
            title_canvas_3.GetComponent<UnityEngine.UI.Text>().text = "\"Level 2\"";
			flagCheckLv = true;
			canvas_2.SetActive(false);
			canvas_1.SetActive(false);
			canvas_lv2.SetActive(true);
			canvas_lv1.SetActive(false);
		}
		
	}

	public void onPressBack_CV2(){
		canvas_2.SetActive(false);
		canvas_1.SetActive(true);
		canvas_lv1.SetActive(false);
		canvas_lv2.SetActive(false);
		audioSource.Stop();
		audioSource.clip = splashClip;
		audioSource.Play();
	}

	public void onPressBack_CV3(){
		canvas_2.SetActive(true);
		canvas_1.SetActive(false);
		canvas_lv1.SetActive(false);
		canvas_lv2.SetActive(false);
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
		} else if (lv == 6){
			MenuInGame.level = 22;
			Application.LoadLevel("Level2_2");
		} else if (lv == 7){
			MenuInGame.level = 23;
			Application.LoadLevel("Level2_3");
		}
	}

}
