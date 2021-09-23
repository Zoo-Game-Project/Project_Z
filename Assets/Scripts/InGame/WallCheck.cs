using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 현재 쓰고있지 않는 스크립트.
public class WallCheck : MonoBehaviour
{
    public GameObject Player;
    public static bool IsWall;

    //private void OnCollisionStay2D(Collision2D collision)
    //{
    //    if (collision.collider.CompareTag("Wall"))
    //    {
    //        Debug.Log("캐릭터가 멈추었다.");
    //        Player_Controller.IsMove = true;
    //        IsWall = true;
    //    }
    //}

    //private void OnCollisionExit2D(Collision2D collision)
    //{
    //    if (collision.collider.CompareTag("Wall"))
    //    {
    //        Debug.Log("캐릭터가 다시 움직인다.");
    //        Player_Controller.IsMove = false;
    //        IsWall = false;
    //        //Player.GetComponent<CapsuleCollider2D>().enabled = true;
    //    }
    //}

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Wall"))
        {
            Debug.Log("맵 체인지하면 캐릭터가 멈출것이다.");
            IsWall = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Wall"))
        {
            Debug.Log("벽이있는 지역에서 벗어났다.");
            IsWall = false;
        }
    }

}
