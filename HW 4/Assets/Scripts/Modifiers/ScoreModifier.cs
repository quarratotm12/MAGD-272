using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreModifier : MonoBehaviour {

	public Text scoreTargetText;

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.D)) {
			StatsManager.score++;
			Debug.Log (StatsManager.score);
			scoreTargetText.text = "Score: " + StatsManager.score.ToString();
		}
	}
}
