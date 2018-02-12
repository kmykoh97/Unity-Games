using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class secondSceneVolume : MonoBehaviour {

    public AudioSource myMusic;

    // Use this for initialization
    void Start () {
        myMusic.volume =  changeMusicVolume.volumeValue;
    }
}
