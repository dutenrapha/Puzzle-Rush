﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomCursor : MonoBehaviour {

	Vector2 targetPos;
	// Use this for initialization
	void Start () {
		Cursor.visible = false;
	}
	
	// Update is called once per frame
	void Update () {
		targetPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		transform.position = targetPos;
	}
}
