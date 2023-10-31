using System.Collections;
using System.Collections.Generic;
using Unity.MLAgents;
using Unity.VisualScripting;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    public CarBehaviour carBehaviour;

    //Rewards
    RewardStructure rewardStructure;
    private float hitCheck;
    private float hitWall;

    private void Start()
    {
        carBehaviour = GetComponent<CarBehaviour>();
        //Debug.Log("seces");
        
        //Rewards
        rewardStructure = GetComponent<RewardStructure>();
        hitCheck = rewardStructure.Circuit_hitCheck;
        hitWall = rewardStructure.Circuit_hitWall;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Checkpoint"))
        {
            //Debug.Log("Hit CheckPoint!");
            carBehaviour.AddReward(hitCheck);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            Debug.Log("Hit Wall");
            carBehaviour.AddReward(hitWall);
            //carBehaviour.EndEpisode();
        }
    }
}
