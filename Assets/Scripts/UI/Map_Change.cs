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

    //�÷��̾��� ������Ʈ�� �������� ���� �Լ� (�浹�� �ö��̴� ���Ḧ ���� ���)
    public GameObject Player;

    public void Change_1()
    {
        if (!IsOpen)
        {
            //MainCamera_1.gameObject.SetActive(false);
            //MainCamera_2.gameObject.SetActive(true);
            //Canvas.worldCamera = MainCamera_2;

            if (PlayerCheck.IsWall == false)
            {
                Debug.Log("ĳ������ �ö��̴��� ������ �ʴ´�.");
                Player.GetComponent<CapsuleCollider2D>().enabled = true;
                Player_Controller.IsMove = false;
                stage_1.SetActive(false);
                stage_2.SetActive(true);
            }

            else
            {
                Debug.Log("ĳ������ �ö��̴��� ������.");
                Player.GetComponent<CapsuleCollider2D>().enabled = false;
                Player_Controller.IsMove = true;
                stage_1.SetActive(false);
                stage_2.SetActive(true);
            }

        }

        else
        {
            //MainCamera_1.gameObject.SetActive(true);
            //MainCamera_2.gameObject.SetActive(false);
            //Canvas.worldCamera = MainCamera_1;

            if (PlayerCheck.IsWall == false)
            {
                Debug.Log("ĳ������ �ö��̴��� ������ �ʴ´�.");
                Player.GetComponent<CapsuleCollider2D>().enabled = true;
                Player_Controller.IsMove = false;
                stage_2.SetActive(false);
                stage_1.SetActive(true);
            }

            else
            {
                Debug.Log("ĳ������ �ö��̴��� ������.");
                Player.GetComponent<CapsuleCollider2D>().enabled = false;
                Player_Controller.IsMove = true;
                stage_2.SetActive(false);
                stage_1.SetActive(true);
            }

        }
        IsOpen = !IsOpen;
    }
}
