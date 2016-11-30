using UnityEngine;
using System.Collections;

public class SoundManager : MonoBehaviour {
	public GameObject spawner;
	public static SoundManager instance;
	public static AudioClip[] allSounds;
	public static AudioSource maintheme;
	public static bool mainthemebool = true;
	public static void JessieFunction (GameObject objectForAudio)

	{
		//an array to hold the sounds (Jessie)

maintheme = Resources.load<AudioClip>("BackgroundMusic.mp3")
		//load sounds into the array (Jessie)
		allSounds = Resources.LoadAll<AudioClip>("EnemyBump");
	}
	void start(){
		spawner = GameObject.Find ("spawner");
		mainthemebool = true;
	}
	//Function to load random sound on collision (Antonio)
	void PlayFunction (){
		if (mainthemebool = true) {
			maintheme.Play ();
		}
	}
	void OnCollisionEnter (Collision col)
	{
		if(col.gameObject)
		{
			AudioClip mysound = allSounds [Random.Range (0, allSounds.Length)];
				}
		//Function to loop main music (Daniya)
		if (mainthemebool = false) {
			maintheme.Play ();
		}

}
}
