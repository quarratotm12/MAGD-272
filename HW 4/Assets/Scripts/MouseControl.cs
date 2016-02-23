using UnityEngine;
using System.Collections;

public class MouseControl : MonoBehaviour {

	public Texture2D newCursor;
	Vector2 offset;

	// Use this for initialization
	void Start () {
		offset = new Vector2 ((newCursor.width * .1f), (newCursor.height * .1f));
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void mouseOver(){
		Cursor.SetCursor(newCursor,offset,CursorMode.Auto);

	}

	public void defaultMouse(){
		Cursor.SetCursor(null,Vector2.zero,CursorMode.Auto);

	}
}
