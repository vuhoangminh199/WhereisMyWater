using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReTileScript : MonoBehaviour {

	public float fallDealy = 0.5f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerExit(Collider other) {

		if (other.tag == "Player"){
			TileScript.Instance.SpawnTile();
			StartCoroutine(FallDown());
		}
	}

	IEnumerator FallDown(){
		yield return new WaitForSeconds(fallDealy);
		GetComponent<Rigidbody>().isKinematic = false;
	}

}
