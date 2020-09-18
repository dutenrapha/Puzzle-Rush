using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scene1_clue4 : MonoBehaviour {

	public GameObject Clue4;
	public void Start () {
		Clue4.SetActive(false);
	}

	public void OnMouseOver () {
		Clue4.SetActive(true);
	}

	public void OnMouseExit () {
		Clue4.SetActive(false);
	}
}
