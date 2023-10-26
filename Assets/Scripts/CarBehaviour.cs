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

    private float verticalInput;
    private float horizontalInput;
    private bool isBreaking;

    private float maxTime = 60.0f, currentTime;

    private float speed;

    public override void Initialize()
    {
        controller = GetComponent<CarController>();
        rBody = GetComponent<Rigidbody>();
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
            EndEpisode();
        }
    }

    public void MoveAgent(ActionBuffers actions)
    {
        float throttle = actions.ContinuousActions[0];
        float steer = actions.ContinuousActions[1];

        float mappedThrottle = Mathf.Clamp(throttle, -1f, 1f);
        float mappedSteer = Mathf.Clamp(steer, -1f, 1f);

        isBreaking = mappedThrottle < 0 ? true : false;

        controller.GetInput(mappedSteer, mappedThrottle, isBreaking);
    }

    public override void Heuristic(in ActionBuffers actionsOut)
    {
        var continuousActionsOut = actionsOut.ContinuousActions;

        continuousActionsOut[0] = Input.GetAxis("Vertical");
        continuousActionsOut[1] = Input.GetAxis("Horizontal");
    }

    public void ResetEnv()
    {
        this.transform.position = spawn.transform.position;
        this.transform.rotation = spawn.transform.rotation;
        rBody.velocity = Vector3.zero;
        rBody.angularVelocity = Vector3.zero;
    }
}