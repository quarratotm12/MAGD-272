using UnityEngine;
using System.Collections;

public class FadeOut : MonoBehaviour {

	//public AudioSource music;
	public static float fadeTime=300f;

	public void fadeOutA (AudioSource sound) {
		float volume=sound.volume;
		while (sound.volume > 0) {
			sound.volume -= volume * (1 / fadeTime);
			Debug.Log (sound.volume);
		}
		//yield return null;
	}


	/*public void fadeOutB (AudioSource muzak) {
		//StartCoroutine (fadeOutA (muzak));
	}
	*/
}
