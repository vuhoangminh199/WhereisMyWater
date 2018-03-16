using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Duck : MonoBehaviour {
	public int checkDuck = 3;
	// Use this for initialization
	void Start () {
		
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
					 Destroy(other.gameObject);
				}
		}
	}
}
