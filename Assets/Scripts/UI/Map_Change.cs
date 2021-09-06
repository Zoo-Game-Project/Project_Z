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
    public static bool IsOpen;

    //플레이어의 컴포넌트를 가져오기 위한 함수 (충돌시 컬라이더 종료를 위한 요소)
    public GameObject Player;
    public GameObject Player_Check;

    public void Change_1()
    {
        if (!IsOpen)
        {
            //MainCamera_1.gameObject.SetActive(false);
            //MainCamera_2.gameObject.SetActive(true);
            //Canvas.worldCamera = MainCamera_2;
            
            //충돌 시 캐릭터의 컬라이더 종료
            Player.GetComponent<CapsuleCollider2D>().enabled = false;
            stage_1.SetActive(false);
            //Player_Check.GetComponent<BoxCollider2D>().enabled = true;
            stage_2.SetActive(true);

            if (WallCheck.IsWall == false)
            {
                Debug.Log("캐릭터의 컬라이더가 다시 켜진다.");
                Player.GetComponent<CapsuleCollider2D>().enabled = true;
                Player_Check.GetComponent<Collider2D>().enabled = false;
                //Invoke("MoveCheck", 1f);
            }

            //Invoke("MoveCheck", 1f);
        }

        else
        {
            //MainCamera_1.gameObject.SetActive(true);
            //MainCamera_2.gameObject.SetActive(false);
            //Canvas.worldCamera = MainCamera_1;
            
            //충돌 시 캐릭터의 컬라이더 종료
            Player.GetComponent<CapsuleCollider2D>().enabled = false;
            stage_2.SetActive(false);
            //Player_Check.GetComponent<BoxCollider2D>().enabled = true;
            stage_1.SetActive(true);

            if (WallCheck.IsWall == false)
            {
                Debug.Log("캐릭터의 컬라이더가 다시 켜진다.");
                Player.GetComponent<CapsuleCollider2D>().enabled = true;
                Player_Check.GetComponent<Collider2D>().enabled = false;
                //Invoke("MoveCheck", 1f);
            }

            //Invoke("MoveCheck", 1f);
        }
        IsOpen = !IsOpen;
    }
    
    void MoveCheck()
    {
        if (Player_Controller.IsMove == false)
        {
            Debug.Log("캐릭터의 컬라이더가 다시 켜진다.");
            Player.GetComponent<CapsuleCollider2D>().enabled = true;
            //Player_Check.GetComponent<Collider2D>().enabled = false;
        }
    }
}
