using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TypeWriter : MonoBehaviour {

	public string myText="HI! What's your name?";
	public string otherText="Wow! You must feel stupid with that name!";
	public float interLetterTime;
	public Text targetTypeText;
	// Use this for initialization
	void Start () {
		StartCoroutine(addText (myText));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	IEnumerator addText(string text){
		int textLength=text.Length;
		for (int i = 0; i <= textLength; i++) {
			targetTypeText.text = text.Substring (0, i);
			yield return new WaitForSeconds (interLetterTime);
		}
	}
}
