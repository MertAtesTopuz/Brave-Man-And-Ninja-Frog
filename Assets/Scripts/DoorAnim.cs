using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAnim : MonoBehaviour
{
    public Sprite on;
    public Sprite off;
    public bool isOn2 = false;
    private void Start()
    {
    }
    private void Update()
    {
        if (isOn2 == true)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = off;
        }
        else
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = on;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        isOn2 = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {

        isOn2 = false;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {

        isOn2 = true;
    }
}
