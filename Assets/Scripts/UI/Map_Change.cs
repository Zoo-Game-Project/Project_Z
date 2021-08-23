using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map_Change : MonoBehaviour
{
    public Camera MainCamera_1;
    public Camera MainCamera_2;
    public Canvas Canvas;
    public bool IsOpen;

    public void Change_1()
    {
        if (!IsOpen)
        {
            MainCamera_1.gameObject.SetActive(false);
            MainCamera_2.gameObject.SetActive(true);
            Canvas.worldCamera = MainCamera_2;
        }

        else
        {
            MainCamera_1.gameObject.SetActive(true);
            MainCamera_2.gameObject.SetActive(false);
            Canvas.worldCamera = MainCamera_1;
        }
        IsOpen = !IsOpen;
    }
}
