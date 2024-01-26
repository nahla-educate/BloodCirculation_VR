using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buzz : MonoBehaviour
{
    void Start()
    {
        Debug.Log("yes");
        OVRInput.SetControllerVibration(1, 1, OVRInput.Controller.RTouch);
        OVRInput.SetControllerVibration(1, 1, OVRInput.Controller.LTouch);
    }
  /*  private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Body"))
        {
            Debug.Log("yes");
            OVRInput.SetControllerVibration(1, 0.5f, OVRInput.Controller.LTouch);
            Debug.Log("no");
        }
    }*/
}
