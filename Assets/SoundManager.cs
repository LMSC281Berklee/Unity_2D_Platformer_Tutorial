using UnityEngine;
using System.Collections;

public class SoundManager : MonoBehaviour {


	public static SoundManager instance;

	public static void JessieFunction (GameObject objectForAudio) {
		//an array to hold the sounds
AudioClip[] allSounds;

		//load sounds into the array
		allSounds = Resources.LoadAll<AudioClip>("Sounds");
	}
}
