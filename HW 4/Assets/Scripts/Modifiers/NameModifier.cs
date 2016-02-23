using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NameModifier : MonoBehaviour {

	public Text nameText;
	void Start () {
		//nameText.text = StatsManager.playerName;
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (StatsManager.playerName);
		nameText.text = StatsManager.playerName;
	}
}
