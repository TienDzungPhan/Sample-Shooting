using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;// Required when using Event data.

public class LeftButtonController : MonoBehaviour, IPointerDownHandler, IPointerUpHandler {

	public GameObject Rocket;
	public static bool mouseDown;

	// Use this for initialization
	void Start () {
		mouseDown = false;
		Rocket = GameObject.Find("rocket");
	}

	void Update () {
		if (mouseDown)
			Rocket.transform.Translate(-0.1f, 0, 0);		
	}
	
	public void OnPointerDown (PointerEventData eventData) {
		mouseDown = true;
	}

	public void OnPointerUp (PointerEventData eventData) {
		mouseDown = false;
	}

}
