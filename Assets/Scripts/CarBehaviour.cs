using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.MLAgents;
using Unity.MLAgents.Actuators;
using Unity.MLAgents.Sensors;
using System;

public class CarBehaviour : Agent
{

    public CarController controller;

    private float verticalInput;
    private float horizontalInput;
    private bool isBreaking;

    public override void Initialize()
    {
        controller = GetComponent<CarController>();
    }

    public override void OnEpisodeBegin()
    {
        
    }

    public override void CollectObservations(VectorSensor sensor)
    {
        
    }

    public override void OnActionReceived(ActionBuffers actions)
    {
        MoveAgent(actions);
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
}