using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyA : MonoBehaviour
{





    //Player's Current Position 
    public int cp = 0;

    //Enemy's Current Position
    public int lane;

    //Enemy health
    public int hp = 1;

    //Player Speed
    public float speed = 1.0f;



    //keycodes initialization, these buttons will move pipe
    public KeyCode rotL = KeyCode.LeftArrow;
    public KeyCode rotR = KeyCode.RightArrow;
    public KeyCode shoot = KeyCode.Space;
  


    

    //Rigidbody of the enemy
    private Rigidbody rb;




    //Target position (The core)
    private Vector3 core = new Vector3 (30.0f, 7.7f, 15.0f);



    void Start()
    {
        //rb = GetComponent<Rigidbody>();
    }


    void Update()
    {

        float Step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, core, Step);



        if (Input.GetKeyDown(rotL))
        {
            if (cp == 7)
            {
                cp = 0;
            }
            else
            {
                cp = cp + 1;
            }
        }

        if (Input.GetKeyDown(rotR))
        {
            if (cp == 0)
            {
                cp = 7;
            }
            else
            {
                cp = cp - 1;
            }
        }

        if (Input.GetKeyDown(shoot))
        {
            if (lane == cp)
            {
                hp = hp - 1;
                if (hp == 0)
                {
                    Destroy(gameObject);
                }
            }
        }

    }

    //Destroy the enemy when it collides with the core
    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }


}