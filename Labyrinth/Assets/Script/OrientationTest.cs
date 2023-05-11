using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class OrientationTest : MonoBehaviour
{
    [SerializeField] TMP_Text systemInfoText;
    void Start()
    {
        systemInfoText.text = "Sensors: ";
        if (SystemInfo.supportsAccelerometer)
        {
            systemInfoText.text += "Accelerometer ada";
        }

        if (SystemInfo.supportsGyroscope)
        {
            systemInfoText.text += "Gyroscope ada";
            Input.gyro.enabled = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Gravitas: " + Input.gyro.gravity);
        Debug.Log("Akselerasi: " + Input.acceleration);
        Debug.Log("Gyro akselerasi: " + Input.gyro.userAcceleration);
        Debug.Log("Gyro rotation rate:" + Input.gyro.rotationRate);
        Debug.Log("Gyro rotation rate unbiased:" + Input.gyro.rotationRateUnbiased);
    }
}
