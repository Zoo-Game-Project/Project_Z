using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleUIManager : MonoBehaviour
{
    //BG
    public GameObject BG_Title;
    public GameObject BG_GameList;

    //UI
    public GameObject UI_Title;
    public GameObject UI_GameList;

    public void Game_Start()
    {
        BG_Title.SetActive(false);
        UI_Title.SetActive(false);
        BG_GameList.SetActive(true);
        UI_GameList.SetActive(true);
    }
    public void Home_Move()
    {
        BG_Title.SetActive(true);
        UI_Title.SetActive(true);
        BG_GameList.SetActive(false);
        UI_GameList.SetActive(false);
    }
}
