using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScreen : MonoBehaviour {

	public void ChangeScreenMenu(string sceneName) {
		Application.LoadLevel(sceneName);
	}
}
