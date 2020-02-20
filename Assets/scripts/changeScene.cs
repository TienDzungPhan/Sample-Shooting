using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeScene : MonoBehaviour {

	public void changeGameScene (string sceneName) {
		Application.LoadLevel (sceneName);
	}
}
