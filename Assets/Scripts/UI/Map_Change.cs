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
            
            //�浹 �� ĳ������ �ö��̴� ����
            Player.GetComponent<CapsuleCollider2D>().enabled = false;
            stage_1.SetActive(false);
            stage_2.SetActive(true);

            Invoke("MoveCheck", 1f);
        }

        else
        {
            //MainCamera_1.gameObject.SetActive(true);
            //MainCamera_2.gameObject.SetActive(false);
            //Canvas.worldCamera = MainCamera_1;
            
            //�浹 �� ĳ������ �ö��̴� ����
            Player.GetComponent<CapsuleCollider2D>().enabled = false;

            stage_1.SetActive(true);
            stage_2.SetActive(false);

            Invoke("MoveCheck", 1f);
        }
        IsOpen = !IsOpen;
    }
    
    void MoveCheck()
    {
        if (Player_Controller.IsMove == false)
        {
            Player.GetComponent<CapsuleCollider2D>().enabled = true;
        }
    }
}
