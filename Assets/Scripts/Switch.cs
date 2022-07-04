using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    public bool isOn = false;
    public Sprite on;
    public Sprite off;
    private void Start()
    {
    }
    private void Update()
    {
        if (isOn == true)
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
        if (isOn == true)
        {
            isOn = false;
        }
        else
        {
            isOn = true;
        }

    }
}
