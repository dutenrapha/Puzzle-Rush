using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scene1_challenge : MonoBehaviour {

	public GameObject Cross;
	public GameObject Challenge;
	public void Start () {
		Cross.SetActive(false);
		Challenge.SetActive(false);
	}

	public void OnMouseDown () {
		Cross.SetActive(true);
		Challenge.SetActive(true);
	}
}
