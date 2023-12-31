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
        hitCheck = rewardStructure.hit_check;
        hitWall = rewardStructure.hit_wall;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Checkpoint"))
        {
            //Debug.Log("Hit CheckPoint!");
            carBehaviour.AddReward(hitCheck);
        }
        if (other.gameObject.CompareTag("Finish"))
        {
            carBehaviour.EndEpisode();
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
