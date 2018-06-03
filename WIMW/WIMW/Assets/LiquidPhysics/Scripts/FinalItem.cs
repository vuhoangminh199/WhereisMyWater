using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalItem : MonoBehaviour {
	public int countItemWater = 2;
	private AudioSource audioSource;
    public AudioClip finalClip;
	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D other){
        bool flag = false;
        if (other.collider.GetComponent<DynamicParticle>().checkWater() && other.gameObject.tag =="water"){
            //Application.LoadLevel("sceneName");
			if (countItemWater == 0) {
				MenuInGame.instance.onGameOver();
				audioSource.PlayOneShot(finalClip);
				Debug.Log("gameover");
			} else {
                if(!flag)
                {
                  flag = true;
                  countItemWater--;
                  Destroy(other.gameObject);
                  flag = false;
                }
                				
			}
		}
	}
}
