using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class RewardStructure : MonoBehaviour
{
    // Left Oval Track;
    public float LeftOval_hitCheck = 1f;
    public float LeftOval_hitWall = -10f;
    public float LeftOval_timePass = -0.1f;
    public float LeftOval_speedCoeff = 0.01f;

    // Right Oval Track;
    public float RightOval_hitCheck = 1f;
    public float RightOval_hitWall = -10f;
    public float RightOval_timePass = -0.1f;
    public float RightOval_speedCoeff = 0.01f;

    // Circuit Track;
    public float Circuit_hitCheck = 1f;
    public float Circuit_hitWall = -200f; //-100 earlier
    public float Circuit_timePass = -0.1f;
    public float Circuit_speedCoeff = 0.01f;
}
