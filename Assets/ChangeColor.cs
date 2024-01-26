using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public Material newMaterial;
    public Material previousMaterial;

    public void ChangeMaterialOnClick()
    {
        Renderer renderer = GetComponent<Renderer>();

        if (renderer != null && newMaterial != null)
        {
            renderer.material = newMaterial;
        }
        else
        {
            Debug.LogWarning("Renderer or newMaterial not assigned.");
        }
    }
    public void ChangeMaterialOnClickTwo()
    {
        Renderer renderer = GetComponent<Renderer>();

        if (renderer != null && newMaterial != null)
        {
            renderer.material = previousMaterial;
        }
        else
        {
            Debug.LogWarning("Renderer or newMaterial not assigned.");
        }
    }
}
