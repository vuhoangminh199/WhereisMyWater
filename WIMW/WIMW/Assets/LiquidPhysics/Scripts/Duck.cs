using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Duck : MonoBehaviour {
	public int checkDuck = 3;
	private AudioSource audioSource;
    public AudioClip duckClip;
	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D other){
		if(other.collider.GetComponent<DynamicParticle>().checkWater() && other.gameObject.tag =="water"){ 

				if (checkDuck == 0) {
					Destroy(gameObject);
					MenuInGame.instance.changeDuckColor(1);
    				 
				} else {
					 checkDuck --;
					 audioSource.PlayOneShot(duckClip);
					 Destroy(other.gameObject);
				}
		}
	}
}
