using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RockController : MonoBehaviour {

	float fallSpeed;
	float rotSpeed;
	Text scoreText;
	int currentScore;
	string scoreString;

	void Start () {
		this.scoreText = GameObject.Find ("Score").GetComponent<Text> ();
		for (int i = 7; i < scoreText.text.Length; i++) {
			scoreString += scoreText.text[i];
		}
		int.TryParse (scoreString, out this.currentScore);
		this.fallSpeed = 0.01f + 0.1f * Random.value + Mathf.Floor((float)(this.currentScore/10f)) * 0.03f;
		this.rotSpeed = 5f + 3f * Random.value + Mathf.Floor((float)(this.currentScore/10f)) * 0.03f;
	}

	void Update () {
		transform.Translate( 0, -fallSpeed, 0, Space.World);
		transform.Rotate(0, 0, rotSpeed );

		if (transform.position.y < -5.5f) {
			GameObject.Find ("Canvas").GetComponent<UIController> ().GameOver ();
			Destroy (gameObject);
		}
	}
}
