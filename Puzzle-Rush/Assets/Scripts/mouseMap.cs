using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseMap : MonoBehaviour {

	public Texture2D mouseMapIcon;
	public CursorMode curMode = CursorMode.Auto;
	public Vector2 hotSpot = Vector2.zero;

	void Start () {
		UnityEngine.Cursor.SetCursor (mouseMapIcon, hotSpot, curMode);
	}
}
