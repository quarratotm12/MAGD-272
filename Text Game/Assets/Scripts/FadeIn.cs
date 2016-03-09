using UnityEngine;
using System.Collections;

public class FadeIn : MonoBehaviour {

	public static float fadeTime=300f;

	public void fadeInA (AudioSource sound) {
		float volume=0.1f;
		while (sound.volume < 1) {
			sound.volume += (1 / fadeTime);
			Debug.Log (sound.volume);
		}
		//yield return null;
	}
}
