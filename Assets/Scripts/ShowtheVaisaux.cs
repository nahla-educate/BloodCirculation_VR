using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class ShowtheVaisaux : MonoBehaviour
{
   public GameObject skeleton;

   public GameObject artereRouge;
   public GameObject artereBleu;

   public GameObject instruction;

   public GameObject artereRougeTwo;
   public GameObject artereBleuTwo;

   // public Material bleuMaterial;
   // public Material redMaterial;

    public void startBtn1()
   {
       // instruction.SetActive(false);
        skeleton.SetActive(false);
        artereRougeTwo.SetActive(true);
        artereRouge.SetActive(true);


        artereBleuTwo.SetActive(false);
        artereBleu.SetActive(false);


    }

    public void startBtn2()
    {
       // instruction.SetActive(false);
        skeleton.SetActive(false);
        artereBleuTwo.SetActive(true);
        artereBleu.SetActive(true);
        artereRougeTwo.SetActive(false);
        artereRouge.SetActive(false);

    }

    public void Chat()
    {
        Debug.Log("click");
        SceneManager.LoadScene("Chat");
        OVRInput.SetControllerVibration(10, 20);
    }

}
