using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCheck : MonoBehaviour
{
    public GameObject Player;

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    Debug.Log("캐릭터가 멈추었다.");
    //    Player_Controller.IsMove = true;
    //}

    //private void OnCollisionExit2D(Collision2D collision)
    //{
    //    Debug.Log("캐릭터가 다시 움직인다.");
    //    Player_Controller.IsMove = false;
    //    //Player.GetComponent<CapsuleCollider2D>().enabled = true;
    //}

    private void OnTriggerEnter2D(Collider2D other)
    {
        //if (other.CompareTag("Wall"))
        {
            Debug.Log("캐릭터가 멈추었다.");
            Player_Controller.IsMove = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
            Debug.Log("캐릭터가 다시 움직인다.");
            Player_Controller.IsMove = false;
            Player.GetComponent<CapsuleCollider2D>().enabled = true;
    }

}
