using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StoreNameAndStyle : MonoBehaviour {

	public InputField nameInput;
	public void storeName(){
		if (nameInput.text == "")
			StatsManager.playerName = "PLAYER";
		else
			StatsManager.playerName = nameInput.text.ToUpper();
	}
	public void storeStyle(int style){
		StatsManager.styleChoice = style;
	}
	public void checkStyle(){
		if (StatsManager.styleChoice == 0) {
			StatsManager.styleChoice = 2;
		}
	}
	public void loadThemedLevel(){
		if (StatsManager.styleChoice == 2) {
			SceneManager.LoadScene("Intro smooth");
		} else {
			SceneManager.LoadScene("Intro hardcore");
		}
	}
}
