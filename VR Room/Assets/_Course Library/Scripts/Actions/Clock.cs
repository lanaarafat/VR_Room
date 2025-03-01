using UnityEngine;
using System;

public class Clock : MonoBehaviour
{
    public Transform hourHand;
    public Transform minuteHand;
    public Transform secondHand;

    void Update()
    {
        DateTime currentTime = DateTime.Now; // realworld time

        float hourAngle = (currentTime.Hour % 12) * 30f + (currentTime.Minute * 0.5f); // 360° / 12 
        float minuteAngle = currentTime.Minute * 6f; // 360° / 60 minutes
        float secondAngle = currentTime.Second * 6f; // 360° / 60 seconds

        hourHand.localRotation = Quaternion.Euler(0, 0, -hourAngle);
        minuteHand.localRotation = Quaternion.Euler(0, 0, -minuteAngle);
        
        if (secondHand != null)
            secondHand.localRotation = Quaternion.Euler(0, 0, -secondAngle);
    }
}
