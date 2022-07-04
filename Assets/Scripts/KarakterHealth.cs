using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KarakterHealth : MonoBehaviour
{
    public PnlControl control;
    public int health = 1;
    public AudioClip olme;
    AudioSource sesdosyasi;
    private void Start()
    {
        sesdosyasi = gameObject.GetComponent<AudioSource>();
    }
    public void TakeDamage()
    {
        health -= 1;
        sesdosyasi.PlayOneShot(olme);
    }
    private void Update()
    {
        if (health <= 0)
        {
            
            control.kaybettin();
            Time.timeScale = 0.0f;
            
        }
    }
}
