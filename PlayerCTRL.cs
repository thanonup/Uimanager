using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCTRL : MonoBehaviour
{
    Animator anim;
    [SerializeField] float Speed;
    [SerializeField] float gravity;


    private float DedefaultSpeed;
    private float RunSpeed = 4;

    private void Start()
    {
        anim = GetComponent<Animator>();
        DedefaultSpeed = Speed;
    }
    private void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        MovePlayer(h, v);
        SpeedPlayer();

    }

    public void MovePlayer(float h, float v)
    {
        if(v != 0) { anim.SetInteger("walk", 1); }
        else { anim.SetInteger("walk", 0); }
        transform.Translate(Vector3.forward * v * Speed * Time.deltaTime);
        transform.Rotate(0, h * 180 * Time.deltaTime, 0);
    }
    public void SpeedPlayer()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            anim.SetInteger("Run", 2);
            Speed = RunSpeed;
        }
        else
        {
            anim.SetInteger("Run", 0);
            Speed = DedefaultSpeed;
        }
    }
}
