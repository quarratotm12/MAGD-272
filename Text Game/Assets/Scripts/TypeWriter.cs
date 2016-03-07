using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TypeWriter : MonoBehaviour {

	public string myText="HELLO " + StatsManager.playerName + ", IT IS NOW TIME TO CUSTOMIZE YOUR EXPERIENCE.";
	public string otherText="CLICK ONE OF THE BUTTONS BELOW TO CHANGE THE THEME OF THE GAME.";

	public float interLetterTime;
	public Text targetTypeText;


	void Start () {
		StartCoroutine(addText ("HELLO " + StatsManager.playerName + ", IT IS NOW TIME TO CUSTOMIZE YOUR EXPERIENCE. " +
			"CLICK ONE OF THE BUTTONS BELOW TO CHANGE THE THEME OF THE GAME." ));
		//StartCoroutine (addText (otherText));
	}


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
