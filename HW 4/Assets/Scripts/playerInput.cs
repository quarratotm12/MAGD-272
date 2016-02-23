using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class playerInput : MonoBehaviour {

	//public static InputField nameInput;
	//public Text nameText;

	// Update is called once per frame

	public void storeName(InputField nameInput){
		StatsManager.playerName = nameInput.text;
		//nameText.text = StatsManager.playerName.ToString();
	}
	public static void changeName () {
		//nameText.text = StatsManager.playerName;
	}
}
