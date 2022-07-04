using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishDoor : MonoBehaviour
{
    public GameObject kapi1;
    public GameObject kapi2;

    public PnlControl control;

    public bool ison1 = false;
    public bool ison2 = false;

    public AudioClip bitir;
    AudioSource sesdosyasi;

    private void Start()
    {
        sesdosyasi = gameObject.GetComponent<AudioSource>();
    }
    private void Update()
    {
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "karakter1" && kapi1)
            ison1 = true;
        if (collision.transform.tag == "karakter2" && kapi2)
            ison2 = true;
        
        calis();
        sesdosyasi.PlayOneShot(bitir);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.transform.tag == "karakter1" && kapi1)
            ison1 = false;
        if (collision.transform.tag == "karakter2" && kapi2)
            ison2 = false;
    }

    void calis()
    {
        if (ison1 == true && ison2 == true)
        {
            
            control.levelup();
            
        }
    }
    
}
