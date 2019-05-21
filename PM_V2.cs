using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PM_V2 : MonoBehaviour
{
    //keycodes initialization, these buttons will move pipe
    public KeyCode rotL = KeyCode.RightArrow;
    public KeyCode rotR = KeyCode.LeftArrow;

    //Rigidbody of the player holder
    private Rigidbody rb;

    //The list of transformations to be made
    private Vector3[] CC_path = { new Vector3(20.0f, 0.0f, 0.0f), new Vector3(15.0f, 0.0f, 15.0f), new Vector3(0.0f, 0.0f, 20.0f), new Vector3(-15.0f, 0.0f, 15.0f), new Vector3(-20.0f, 0.0f, 0.0f), new Vector3(-15.0f, 0.0f, -15.0f), new Vector3(0.0f, 0.0f, -20.0f), new Vector3(15.0f, 0.0f, -15.0f) };

    //Player's Current Position
    private int cp = 0;

    //get the rigidbody of the player
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    void Update()
    {
        if (Input.GetKeyDown(rotR))
        {
            if (cp == 7)
            {
                rb.MovePosition(rb.position + CC_path[cp]);
                cp = 0;
            }
            else
            {
                rb.MovePosition(rb.position + CC_path[cp]);
                cp = cp + 1;
            }
        }

        if (Input.GetKeyDown(rotL))
        {
            if (cp == 0)
            {
                rb.MovePosition(rb.position - CC_path[7]);
                cp = 7;
            }
            else
            {
                rb.MovePosition(rb.position - CC_path[(cp - 1)]);
                cp = cp - 1;
            }
        }

    }


    //void FixedUpdate()
    //{
    //    float moveHorizontal = Input.GetAxis("Horizontal");
    //    float moveVertical = Input.GetAxis("Vertical");

    //    Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

    //    rb.AddForce(movement * speed);
    //}
}