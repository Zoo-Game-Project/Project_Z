using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_Manager : MonoBehaviour
{
    public GameObject PauseMenuPanel;
    public GameObject ResetMenuPanel;
    public GameObject Map_1;
    public GameObject Map_2;
    [SerializeField] Rigidbody2D playerRigid;
    [SerializeField] Transform tf_OriginPos;

    public void Pause()
    {
        // ���� �Ͻ� ����
        Time.timeScale = 0;
        PauseMenuPanel.SetActive(true);
    }

    public void ResetMono()
    {
        // �ٽ��ϱ� �޴�
        Time.timeScale = 0;
        ResetMenuPanel.SetActive(true);
    }

    public void reset()
    {
        // �ٽ��ϱ�
        Time.timeScale = 1;
        playerRigid.gameObject.transform.position = tf_OriginPos.position;
        Map_1.SetActive(true);
        Map_2.SetActive(false);
        ResetMenuPanel.SetActive(false);
    }

    public void Continue()
    {
        //����ϱ�
        Time.timeScale = 1;
        PauseMenuPanel.SetActive(false);
        ResetMenuPanel.SetActive(false);
    }

    public void GameQuit()
    {
        //Ÿ��Ʋ�� �̵�
        Application.Quit();
    }
}
