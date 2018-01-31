using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleScript : MonoBehaviour {

	public GameObject[] tilePrefabs;

	public GameObject currentTile;

	// Use this for initialization
	void Start () {
		//tilePrefabs[0]
		for(int i = 0 ; i < 10 ; i++){
			SpawnTile();
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void SpawnTile(){
		int randomIndex = Random.Range(0,2);
		currentTile = (GameObject)Instantiate(tilePrefabs[randomIndex], currentTile.transform.GetChild(0).transform.GetChild(randomIndex).position,Quaternion.identity);
	}
}
