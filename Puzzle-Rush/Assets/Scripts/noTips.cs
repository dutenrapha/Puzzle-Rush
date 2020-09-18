using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class noTips : MonoBehaviour {
	public GameObject tip;
	public void Start () {
		tip.SetActive(false);
	}

	public void OnMouseOver () {
		tip.SetActive(true);
	}

	public void OnMouseExit () {
		tip.SetActive(false);
	}
}
