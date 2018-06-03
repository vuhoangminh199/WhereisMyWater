using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Duck : MonoBehaviour {
	public int checkDuck = 3;
	private AudioSource audioSource;
    public AudioClip duckClip;
    private SpriteRenderer renderer;
    private float mColor = 1f;
	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource>();
        renderer = GetComponent<SpriteRenderer>();
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
                     if (checkDuck != 3) { 
                     renderer.color = new Color(1f, 1f, 1f, mColor - .5f);
                     }
                     audioSource.PlayOneShot(duckClip);
					 Destroy(other.gameObject);
				}
		}
	}
}
