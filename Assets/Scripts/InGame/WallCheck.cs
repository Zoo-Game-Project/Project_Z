using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ���� �������� �ʴ� ��ũ��Ʈ.
public class WallCheck : MonoBehaviour
{
    public GameObject Player;
    public static bool IsWall;

    //private void OnCollisionStay2D(Collision2D collision)
    //{
    //    if (collision.collider.CompareTag("Wall"))
    //    {
    //        Debug.Log("ĳ���Ͱ� ���߾���.");
    //        Player_Controller.IsMove = true;
    //        IsWall = true;
    //    }
    //}

    //private void OnCollisionExit2D(Collision2D collision)
    //{
    //    if (collision.collider.CompareTag("Wall"))
    //    {
    //        Debug.Log("ĳ���Ͱ� �ٽ� �����δ�.");
    //        Player_Controller.IsMove = false;
    //        IsWall = false;
    //        //Player.GetComponent<CapsuleCollider2D>().enabled = true;
    //    }
    //}

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Wall"))
        {
            Debug.Log("�� ü�����ϸ� ĳ���Ͱ� ������̴�.");
            IsWall = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Wall"))
        {
            Debug.Log("�����ִ� �������� �����.");
            IsWall = false;
        }
    }

}
