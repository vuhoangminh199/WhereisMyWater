using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalItem : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D other){
		if(other.collider.GetComponent<DynamicParticle>().checkWater() && other.gameObject.tag =="DynamicParticle"){ 
			Debug.Log("a");
			Destroy(other.gameObject);
			//Application.LoadLevel("sceneName");
		}
	}
}
