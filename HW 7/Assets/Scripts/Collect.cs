using UnityEngine;
using System.Collections;

public class Collect : MonoBehaviour {

	public AudioSource fart;

	void OnTriggerEnter2D(Collider2D colli){  //Update () {
		if(colli.CompareTag("Collectable")){
			colli.gameObject.SetActive (false);
			fart.Play ();
			Debug.Log ("touched");
		}
	}
}
