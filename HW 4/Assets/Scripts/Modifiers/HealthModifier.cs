using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HealthModifier : MonoBehaviour {

	public Text healthTargetText;
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.F)) {
			StatsManager.health++;
			Debug.Log (StatsManager.health);
			healthTargetText.text = "Health: " + StatsManager.health.ToString();
		}
	}
}
