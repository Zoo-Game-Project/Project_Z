using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCheck : MonoBehaviour
{
    public GameObject Player;

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    Debug.Log("ĳ���Ͱ� ���߾���.");
    //    Player_Controller.IsMove = true;
    //}

    //private void OnCollisionExit2D(Collision2D collision)
    //{
    //    Debug.Log("ĳ���Ͱ� �ٽ� �����δ�.");
    //    Player_Controller.IsMove = false;
    //    //Player.GetComponent<CapsuleCollider2D>().enabled = true;
    //}

    private void OnTriggerEnter2D(Collider2D other)
    {
        //if (other.CompareTag("Wall"))
        {
            Debug.Log("ĳ���Ͱ� ���߾���.");
            Player_Controller.IsMove = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
            Debug.Log("ĳ���Ͱ� �ٽ� �����δ�.");
            Player_Controller.IsMove = false;
            Player.GetComponent<CapsuleCollider2D>().enabled = true;
    }

}
