using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput, verticalInput;
    private float currentSteerAngle, currentbreakForce;
    private bool isBreaking;

    public Rigidbody rb;

    // Settings
    [SerializeField] private float motorForce, breakForce, maxSteerAngle;

    // Wheel Colliders
    [SerializeField] private WheelCollider wheelFLcollider, wheelFRcollider;
    [SerializeField] private WheelCollider wheelBLcollider, wheelBRcollider;

    // Wheels
    [SerializeField] private Transform wheelFLtransform, wheelFRtransform;
    [SerializeField] private Transform wheelBLtransform, wheelBRtransform;

    private void FixedUpdate()
    {
        GetInput(horizontalInput, verticalInput, isBreaking);
        HandleMotor();
        HandleSteering();
        UpdateWheels();
    }

    public void GetInput(float hI, float vI, bool iB)
    {
        // Steering Input
        horizontalInput = Input.GetAxis("Horizontal");


        // Acceleration Input
        verticalInput = Input.GetAxis("Vertical");

        // Breaking Input
        isBreaking = Input.GetKey(KeyCode.Space);
    }

    private void HandleMotor()
    {
        wheelBRcollider.motorTorque = verticalInput * motorForce;
        wheelBLcollider.motorTorque = verticalInput * motorForce;
        currentbreakForce = isBreaking ? breakForce : 0f;
        ApplyBreaking();
    }

    private void ApplyBreaking()
    {
        wheelFRcollider.brakeTorque = currentbreakForce;
        wheelFLcollider.brakeTorque = currentbreakForce;
        wheelBLcollider.brakeTorque = currentbreakForce;
        wheelBRcollider.brakeTorque = currentbreakForce;
    }

    private void HandleSteering()
    {
        currentSteerAngle = maxSteerAngle * horizontalInput;
        wheelFLcollider.steerAngle = currentSteerAngle;
        wheelFRcollider.steerAngle = currentSteerAngle;
    }

    private void UpdateWheels()
    {
        UpdateSingleWheel(wheelFRcollider, wheelFRtransform);
        UpdateSingleWheel(wheelFLcollider, wheelFLtransform);
        UpdateSingleWheel(wheelBRcollider, wheelBRtransform);
        UpdateSingleWheel(wheelBLcollider, wheelBLtransform);
    }

    private void UpdateSingleWheel(WheelCollider wheelCollider, Transform wheelTransform)
    {
        Vector3 pos;
        Quaternion rot;
        wheelCollider.GetWorldPose(out pos, out rot);
        wheelTransform.rotation = rot;
        wheelTransform.position = pos;
    }
}