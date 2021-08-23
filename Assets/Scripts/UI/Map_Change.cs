using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map_Change : MonoBehaviour
{
    public GameObject MainCamera_1;
    public GameObject MainCamera_2;
    public GameObject Canvas_1;
    public GameObject Canvas_2;

    public void Change_1()
    {
        // 게임 일시 정지
        Time.timeScale = 0;
        MainCamera_1.SetActive(false);
        Canvas_1.SetActive(false);
        MainCamera_2.SetActive(true);
        Canvas_2.SetActive(true);
    }
    public void Change_2()
    {
        // 게임 일시 정지
        Time.timeScale = 0;
        MainCamera_1.SetActive(true);
        Canvas_1.SetActive(true);
        MainCamera_2.SetActive(false);
        Canvas_2.SetActive(false);
    }
}
