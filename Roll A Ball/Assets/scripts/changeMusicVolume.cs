using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeMusicVolume : MonoBehaviour {

    public Slider volume;
    public AudioSource myMusic;
    static public float volumeValue; // use static so that the value can be brought to next script

	// Update is called once per frame
	void Update () {
        myMusic.volume = volume.value;
        volumeValue = volume.value;
	}
}
