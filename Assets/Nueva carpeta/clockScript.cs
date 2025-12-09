using UnityEngine;
using System;

public class AnalogClock : MonoBehaviour
{
    public GameObject hourHand;
    public GameObject minuteHand;
    public GameObject secondHand;

    private void Awake()
    {
        Console.WriteLine(hourHand);
    }

    void Update()
    {
        DateTime now = DateTime.Now;

        float hours = (now.Hour % 12) + now.Minute / 60f;
        float minutes = now.Minute + now.Second / 60f;
        float seconds = now.Second + now.Millisecond / 1000f;

        float hourRotation = hours * 30f;
        float minuteRotation = minutes * 6f;
        float secondRotation = seconds * 6f;
        Debug.Log($"Hora: {hours}, Rotación: {hourRotation}");

        hourHand.transform.localRotation = Quaternion.Euler(hourRotation + 90, 0, -90);
        minuteHand.transform.localRotation = Quaternion.Euler(minuteRotation + 90, 0, -90);
        secondHand.transform.localRotation = Quaternion.Euler(secondRotation + 90, 0, -90);
    }
}