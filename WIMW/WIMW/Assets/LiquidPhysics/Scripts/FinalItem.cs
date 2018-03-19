using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalItem : MonoBehaviour {
	public int countItemWater = 2;
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
				MenuInGame.instance.onGameOver();
				Debug.Log("gameover");
				} else {
					 countItemWater --;
					 Destroy(other.gameObject);
				}
		}
	}
}
