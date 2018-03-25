using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeOut : MonoBehaviour {
	public GameObject pipeIn;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D other){
		if(other.collider.GetComponent<DynamicParticle>().checkWater() && other.gameObject.tag =="water"){ 
			other.transform.position=pipeIn.transform.position;
		}
	}

	// IEnumerator DelayMetod(Collision2D other)
    // {
    //     ParticleGenerator.flagPipe = true;
	// 	Destroy(other.gameObject);
    //      yield return 0;
   	// 	//ParticleGenerator.flagPipe = false;
    // }
}
