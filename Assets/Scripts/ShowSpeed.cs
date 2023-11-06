using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowSpeed : MonoBehaviour
{
    public Rigidbody car;
    public Text speedText;
    public Text lapTimeText;
    public Text lapBoardText;
    private float lapTime, currentTime;
    private float startTime;
    private float bestLapTime = float.MaxValue;
    private bool first = true;

    private void Start()
    {
        car = GetComponent<Rigidbody>();
        startTime = Time.time;
    }

    private void FixedUpdate()
    {
        float speed = (car.velocity.magnitude) * 2.23694f;
        speedText.text = "Speed: " + ((int)speed).ToString("F0") + " mph";

        lapTime = Time.time - startTime;
        currentTime = Time.time - startTime;
        UpdateLapTime();
    }

    private void UpdateLapTime()
    {
        lapTimeText.text = first == false ? "Lap Time: " + lapTime.ToString("F2") + "s" : "Lap Time: 0s";
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Finish"))
        {
            var LapTime = lapTime;
            bestLapTime = first == false && bestLapTime >= LapTime ? LapTime : bestLapTime;
            lapBoardText.text = first == false ? "Best Lap Time: " + bestLapTime.ToString("F2") + "s\n" + "Previous Lap Time: " + LapTime.ToString("F2") + "s" : "Best Lap Time: 0s\nPrevious Lap: 0s";
            first = false;
    
            startTime = Time.time;
        }
    }
}
