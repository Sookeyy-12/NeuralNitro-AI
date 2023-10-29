using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.MLAgents;
using Unity.MLAgents.Sensors;
using Unity.MLAgents.Actuators;
using System;
using UnityEditor;

public class CarBehaviour : Agent
{
    public Rigidbody rBody;

    public CarController controller;
    public GameObject spawn;

    private bool isBreaking;

    private float maxTime = 30.0f, currentTime;

    private float speed;

    //Rewards
    RewardStructure rewardStructure;
    private float timePass;
    private float speedCoeff;

    public override void Initialize()
    {
        controller = GetComponent<CarController>();
        rBody = GetComponent<Rigidbody>();

        //Rewards
        rewardStructure = GetComponent<RewardStructure>();
        timePass = rewardStructure.RightOval_timePass;
        speedCoeff = rewardStructure.RightOval_speedCoeff;
    }

    public override void OnEpisodeBegin()
    {
        ResetEnv();
        currentTime = 0.0f;
    }

    public override void CollectObservations(VectorSensor sensor)
    {
        // Add speed of the agent as an observation
        Vector3 vel = rBody.velocity;
        speed = vel.magnitude;
        Debug.Log((int)speed);
        sensor.AddObservation(speed);
    }

    public override void OnActionReceived(ActionBuffers actions)
    {
        MoveAgent(actions);

        currentTime += Time.fixedDeltaTime;
        if (currentTime >= maxTime)
        {
            //EndEpisode();
        }
        AddReward(timePass);
        AddReward(speed * speedCoeff);
    }

    public void MoveAgent(ActionBuffers actions)
    {
        float throttle = actions.ContinuousActions[0];
        float steer = actions.ContinuousActions[1];

        float mappedThrottle = Mathf.Clamp(throttle, 0f, 1f);
        float mappedSteer = Mathf.Clamp(steer, -1f, 1f);

        float braking = actions.DiscreteActions[0];
        switch (braking)
        {
            case 0:
                isBreaking = false;
                break;
            case 1:
                isBreaking = true;
                break;
        }
                
        controller.GetInput(mappedSteer, mappedThrottle, isBreaking);
    }

    public override void Heuristic(in ActionBuffers actionsOut)
    {
        var continuousActionsOut = actionsOut.ContinuousActions;
        var discreteActionsOut = actionsOut.DiscreteActions;

        continuousActionsOut[0] = Input.GetAxis("Vertical");
        continuousActionsOut[1] = Input.GetAxis("Horizontal");
        if (Input.GetKey(KeyCode.Space))
        {
            discreteActionsOut[0] = 1;
        } else
        {
            discreteActionsOut[0] = 0;
        }
    }

    public void ResetEnv()
    {
        this.transform.position = spawn.transform.position;
        this.transform.rotation = spawn.transform.rotation;
        rBody.velocity = Vector3.zero;
        rBody.angularVelocity = Vector3.zero;
    }
}