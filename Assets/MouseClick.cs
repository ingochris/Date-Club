﻿using UnityEngine;
using System.Collections;

public class MouseClick : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnMouseDown() {
		Debug.Log ("Click!");
		Application.LoadLevel ("Date Scene");
	}
}
