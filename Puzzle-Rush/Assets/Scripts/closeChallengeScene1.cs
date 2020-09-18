using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closeChallengeScene1 : MonoBehaviour {

	public GameObject Challenge;
	public GameObject Cross;

	public void closeChallenge () {
		Challenge.SetActive(false);
		Cross.SetActive(false);
	}
}