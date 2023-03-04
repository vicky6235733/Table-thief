using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tracktarget : MonoBehaviour
{
    public GameObject tracktarget;
    Vector3 MOVE;

    void Start()
    {
        MOVE = transform.position - tracktarget.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = tracktarget.transform.position + MOVE;
    }
}
