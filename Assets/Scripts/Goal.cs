using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    [SerializeField] StageManager theSM;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            theSM = GameObject.Find("StageClearUI").GetComponent<StageManager>();
            theSM.ShowClearUI();
        }  
    }
}
