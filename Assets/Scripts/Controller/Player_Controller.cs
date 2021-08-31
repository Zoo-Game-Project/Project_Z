using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    public GameObject Player;
    public FixedJoystick fixJoy;
    public float PlayerSpeed = 2f;
    Rigidbody2D rgd2d;

    private void Start()
    {
        rgd2d = Player.GetComponent<Rigidbody2D>();
    }

    public void Update()
    {
        Vector2 direction = (Vector2.up * fixJoy.Vertical + Vector2.right * fixJoy.Horizontal) * PlayerSpeed * Time.deltaTime;
        Player.transform.position += new Vector3(direction.x, direction.y);

        //if (fixJoy.Vertical != 0)
        //{
        //    bool isup = fixJoy.Vertical > 0;
        //    if (isup)
        //    {
        //        Player.transform.Translate(0, PlayerSpeed * Time.deltaTime, 0);
        //    }
        //    else
        //    {
        //        Player.transform.Translate(0, -PlayerSpeed * Time.deltaTime, 0);
        //    }
        //}

        //if (fixJoy.Horizontal != 0)
        //{
        //    bool isright = fixJoy.Horizontal > 0;
        //    if (isright)
        //    {
        //        Player.transform.Translate(PlayerSpeed * Time.deltaTime, 0, 0);
        //    }
        //    else
        //    {
        //        Player.transform.Translate(-PlayerSpeed * Time.deltaTime, 0, 0);
        //    }
        //}

    }
}
