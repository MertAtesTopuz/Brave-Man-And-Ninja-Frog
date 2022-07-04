using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundControl : MonoBehaviour
{
    AudioSource sesdosyasi;
    public AudioClip ziplama;
    public AudioClip olme;
    public PnlControl control ;
    KarakterHealth heal;
    public bool sespnl = false;
    
    void Start()
    {
        sesdosyasi = gameObject.GetComponent<AudioSource>();
        
    }

    
    void Update()
        
    {
       
        if (sespnl == false)
        {

            if (Input.GetKeyDown(KeyCode.Space)|| Input.GetKeyDown(KeyCode.W))
            {
                sesdosyasi.PlayOneShot(ziplama);
            }


            if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D))
            {

                sesdosyasi.Play();
            }
            if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))
            {

                sesdosyasi.Stop();
            }
            if (heal.health == 0)
            {
                sesdosyasi.PlayOneShot(olme);
            }

        }
    }
}
