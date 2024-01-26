using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VibrationHaptic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("startHapticVib");
        OVRInput.SetControllerVibration(10, 10);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("updateVib");    }
}
