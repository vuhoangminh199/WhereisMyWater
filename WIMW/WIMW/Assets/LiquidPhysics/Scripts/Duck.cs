using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duck : MonoBehaviour {
	public int checkDuck = 3;
	private float timeLife = 0.25f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D other){
		if(other.collider.GetComponent<DynamicParticle>().checkWater() && other.gameObject.tag =="DynamicParticle"){ 
				Destroy(other.gameObject);
				if (checkDuck == 0) {
        				 //GameOver();
						 Destroy(gameObject);
    				 
				} else {
					timeLife -= Time.deltaTime;
					if ( timeLife < 0 )
    				 {
						checkDuck --; 
					 }
				}
		}
	}
}
