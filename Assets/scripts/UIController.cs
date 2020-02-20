using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIController : MonoBehaviour {

	int score = 0;
	int currentHighScore = 0; 
	bool isGameOver;
	GameObject scoreText;
	GameObject highScoreText;
	GameObject gameOverText;

	public void GameOver () {
		isGameOver = true;
		this.gameOverText.GetComponent<Text> ().text = "Game Over";
	}

	public void AddScore () {
		if (!isGameOver)
			this.score += 1;

		// High Score Update
		if (this.score > this.currentHighScore) {
			PlayerPrefs.SetInt ("HighScore", this.score);
			this.currentHighScore = PlayerPrefs.GetInt("HighScore", 0);
		}
	}

	// Use this for initialization
	void Start () {
		isGameOver = false;
		this.currentHighScore = PlayerPrefs.GetInt("HighScore", 0);
		this.scoreText = GameObject.Find ("Score");
		this.highScoreText = GameObject.Find ("HighScore");
		this.gameOverText = GameObject.Find ("GameOver");
	}

	void Update () {
		scoreText.GetComponent<Text> ().text = "Score: " + score;
		highScoreText.GetComponent<Text> ().text = "High Score: " + currentHighScore;
	}
}

