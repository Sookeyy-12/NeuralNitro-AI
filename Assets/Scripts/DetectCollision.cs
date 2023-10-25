using System.Collections;
using System.Collections.Generic;
using Unity.MLAgents;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    public CarBehaviour carBehaviour;

    private void Start()
    {
        carBehaviour = GetComponent<CarBehaviour>();
        Debug.Log("seces");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Checkpoint"))
        {
            Debug.Log("Hit CheckPoint!");
            carBehaviour.AddReward(1f);
        }
        if (other.gameObject.CompareTag("Wall"))
        {
            Debug.Log("Hit Wall");
            carBehaviour.AddReward(-100f);
        }
    }
}
