using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_Manager : MonoBehaviour
{
    public GameObject PauseMenuPanel;

    public void Pause()
    {
        // 게임 일시 정지
        Time.timeScale = 0;
        PauseMenuPanel.SetActive(true);
    }

    public void Continue()
    {
        Time.timeScale = 1;
        PauseMenuPanel.SetActive(false);
    }

    public void GameQuit()
    {
        Application.Quit();
    }
}
