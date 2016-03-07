using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class IntroDialogue : MonoBehaviour {

	public Text introText;
	public float interLetterTime;
	// Use this for initialization
	void Start () {
		StartCoroutine(addText("WELL " + StatsManager.playerName + ", LET'S GET RIGHT TO IT. A RECENT 'SCAVENGING HUNT' " +
		"FROM OUR ALLIES IN TORONTO YIELDED SOME DISTURBING INFORMATION. A GROUP OF THUGS RECENTLY CAME " +
		"ACROSS SOME DATA ABOUT HIDDEN STOCKPILES OF NUCLEAR WEAPONS AND VARIOUS CIA PROJECTS. " +
		"WE DON'T KNOW HOW THEY FOUND THIS INFO OR HOW THEY INTEND TO USE IT, BUT IT'S IN HOT WATER " +
		"ALL THE SAME. IF THIS INFO GETS OUT, IT COULD BE USED FOR BLACKMAIL, OR WORSE, " +
		"TO START A NUCLEAR WAR. YOU NEED TO GET INTO THEIR HANGOUT, DESTROY THAT DATA AND GET OUT QUIETLY. " +
			"WE MAKE THE NEWS ENOUGH AS IT IS."));
	}
	
	IEnumerator addText(string text){
		int textLength=text.Length;
		for (int i = 0; i <= textLength; i++) {
			introText.text = text.Substring (0, i);
			yield return new WaitForSeconds (interLetterTime);
		}
	}
}
