using System.Collections;
using System.Collections.Generic;
using Unity.MLAgents;
using UnityEngine;

public class WhatPosition : MonoBehaviour
{
    public CarBehaviour carBehaviour;
    public int pos = 0;

    private void Start()
    {
        carBehaviour = GetComponent<CarBehaviour>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Checkpoint"))
        {
            //Debug.Log("current position: "+ pos);
        }
    }
    private void FixedUpdate()
    {
        carBehaviour.AddReward(pos == 1 ? 0.1f: -0.1f);
    }
}
