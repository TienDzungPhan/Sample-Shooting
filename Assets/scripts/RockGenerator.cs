using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockGenerator : MonoBehaviour {

	public GameObject rockPrefab;

	void Start () {
		InvokeRepeating ("GenRock", 1.5f, 0.3f);
	}

	void GenRock () {
		StartCoroutine (Wait ());
		Instantiate (rockPrefab, new Vector3 (-2.5f + 5 * Random.value, 6, 0), Quaternion.identity);
	}

	IEnumerator Wait () {
		yield return new WaitForSecondsRealtime (0.7f); 
	}
}
