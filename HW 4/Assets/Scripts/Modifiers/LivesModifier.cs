using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LivesModifier : MonoBehaviour {

	public Text livesTargetText;

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.A)) {
			StatsManager.lives++;
			Debug.Log (StatsManager.health);
			livesTargetText.text = "Lives: " + StatsManager.lives.ToString();
		}
	}
}
