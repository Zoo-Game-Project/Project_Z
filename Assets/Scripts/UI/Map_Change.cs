using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map_Change : MonoBehaviour
{
    public Camera MainCamera_1;
    public Camera MainCamera_2;
    public Canvas Canvas;
    public GameObject stage_1;
    public GameObject stage_2;
    public bool IsOpen;

    public void Change_1()
    {
        if (!IsOpen)
        {
            //MainCamera_1.gameObject.SetActive(false);
            //MainCamera_2.gameObject.SetActive(true);
            //Canvas.worldCamera = MainCamera_2;
            stage_1.SetActive(false);
            stage_2.SetActive(true);
        }

        else
        {
            //MainCamera_1.gameObject.SetActive(true);
            //MainCamera_2.gameObject.SetActive(false);
            //Canvas.worldCamera = MainCamera_1;
            stage_1.SetActive(true);
            stage_2.SetActive(false);
        }
        IsOpen = !IsOpen;
    }
}
