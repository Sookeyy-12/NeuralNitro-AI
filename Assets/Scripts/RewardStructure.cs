using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class RewardStructure : MonoBehaviour
{
    // Competitive 
    public float hit_check = 1f;
    public float hit_wall = -100f;
    public float time_pass = -0.01f;
    public float speed_coeff = 0.01f;

    /* Left Oval Track;
    public float LeftOval_hitCheck = 1f;
    public float LeftOval_hitWall = -50f;
    public float LeftOval_timePass = -0.1f;
    public float LeftOval_speedCoeff = 0.01f;
    */
    /* Right Oval Track;
    public float RightOval_hitCheck = 1f;
    public float RightOval_hitWall = -75f;
    public float RightOval_timePass = -0.1f;
    public float RightOval_speedCoeff = 0.01f;
    */
    /* Left Short Oval Track;
    public float LeftShortOval_hitCheck = 5f;
    public float LeftShortOval_hitWall = -100f;
    public float LeftShortOval_timePass = -0.01f;
    public float LeftShortOval_speedCoeff = 0f;
    */
    /* Left Chicane Oval Track;
    public float LeftChicane_hitCheck = 5f;
    public float LeftChicane_hitWall = -100f;
    public float LeftChicane_timePass = -0.1f;
    public float LeftChicane_speedCoeff = 0.01f;
    */
    /* Right Chicane Oval Track;
    public float RightChicane_hitCheck = 5f;
    public float RightChicane_hitWall = -100f;
    public float RightChicane_timePass = -0.1f;
    public float RightChicane_speedCoeff = 0.01f;
    */
    /* Circuit Track;
    public float Circuit_hitCheck = 1f;
    public float Circuit_hitWall = -200f;
    public float Circuit_timePass = -0.1f;
    public float Circuit_speedCoeff = 0.01f;
    */
    /* Standard Rewards
    public float standard_hitCheck = 1f;
    public float standard_hitWall = -100f;
    public float standard_timePass = -0.1f;
    public float standard_speedCoeff = 0.01f;
    */
}
