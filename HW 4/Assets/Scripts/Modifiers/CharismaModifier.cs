using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CharismaModifier : MonoBehaviour {

	public Text charismaTargetText;

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.S)) {
			StatsManager.charisma++;
			Debug.Log (StatsManager.charisma);
			charismaTargetText.text = "Charisma: " + StatsManager.charisma.ToString();
		}
	}
}
