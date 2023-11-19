using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Positiong : MonoBehaviour
{
    public int cnt = 1;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("RaceCar"))
        {
            other.gameObject.GetComponent<WhatPosition>().pos = cnt++;
        }
        if (cnt == 3)
        {
            cnt = 1;
        }
    }
}
