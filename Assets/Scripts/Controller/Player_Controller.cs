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
        Vector2 direction = Vector2.up * fixJoy.Vertical + Vector2.right * fixJoy.Horizontal;
        rgd2d.AddForce(direction * PlayerSpeed * Time.deltaTime);
    }
}
