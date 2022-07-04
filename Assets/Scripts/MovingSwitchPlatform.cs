using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingSwitchPlatform : MonoBehaviour
{
    public Transform firstPos, secondPos;
    public float speed;
    public Switch switc;
    Vector3 nextPos;
    

    private void Start()
    {
        nextPos = firstPos.position;

    }

    private void Update()
    {
        if (switc.isOn == true && transform.position == firstPos.position)
            nextPos = secondPos.position;


        if (switc.isOn == false && transform.position == secondPos.position)
            nextPos = firstPos.position;


        transform.position = Vector3.MoveTowards(transform.position, nextPos, speed * Time.deltaTime);
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(firstPos.position, secondPos.position);
    }
}
