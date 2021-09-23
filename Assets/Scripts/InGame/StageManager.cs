using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StageManager : MonoBehaviour
{
    [SerializeField] GameObject go_UI;
    [SerializeField] GameObject[] go_Stages_1;
    [SerializeField] GameObject[] go_Stages_2;
    int currentStage = 0;
    [SerializeField] GameObject Stages_1;
    [SerializeField] GameObject Stages_2;

    [SerializeField] Rigidbody2D playerRigid;
    [SerializeField] Transform tf_OriginPos;

    public void ShowClearUI()
    {
        go_UI.SetActive(true);
    }
    
    public void NextBtn()
    {
        if (currentStage < go_Stages_1.Length -1)
        {
            playerRigid.gameObject.transform.position = tf_OriginPos.position;
            go_Stages_1[currentStage].SetActive(false);
            go_Stages_2[currentStage++].SetActive(false);
            go_Stages_1[currentStage].SetActive(true);
            go_Stages_2[currentStage].SetActive(true);
            Stages_1.SetActive(true);
            Stages_2.SetActive(false);
            Map_Change.IsOpen = false;
            go_UI.SetActive(false);
        }
        else
        {
            Debug.Log("모든 스테이지를 클리어 함.");
        }
    }
}
