using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyerWater : MonoBehaviour {
	public int countItemWater = 18;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D other){
		if(other.collider.GetComponent<DynamicParticle>().checkWater() && other.gameObject.tag =="water"){ 
			
			//Application.LoadLevel("sceneName");
			if (countItemWater == 0) {
				MenuInGame.instance.onOutOfWater();
				} else {
					 countItemWater --;
					 Destroy(other.gameObject);
				}
		}
	}
}
