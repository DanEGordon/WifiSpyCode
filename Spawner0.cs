using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Spawner0 : MonoBehaviour
{





    //Player's Current Position 
    private int cp = 0;

    //Spawner's Current Position
    public int spawner_lane;

    //Counter for how many enemies are already in the lane
    private int counter = 0;

    public GameObject basic_enemy;
    public GameObject f_enemy;
    public GameObject s_enemy;


    //keycodes initialization, these buttons will move pipe
    public KeyCode rotL = KeyCode.LeftArrow;
    public KeyCode rotR = KeyCode.RightArrow;
    public KeyCode shoot = KeyCode.Space;



    //Function that spawns an enemy and increments the counter by one (If possible, can be done outside function
    void spawn_enemy(GameObject enemy_type, int player_position)
    {
        GameObject go = Instantiate(enemy_type,transform.position, Quaternion.identity);
        EnemyA foe = go.GetComponent<EnemyA>();
        foe.hp = 1 + counter;
        foe.lane = spawner_lane;
        foe.cp = player_position;
        counter += 1;
    }

    void spawn_enemy_f(GameObject enemy_type, int player_position)
    {
        GameObject go = Instantiate(enemy_type, transform.position, Quaternion.identity);
        EnemyA foe = go.GetComponent<EnemyA>();
        foe.hp = 1 + counter;
        foe.lane = spawner_lane;
        foe.cp = player_position;
        counter += 3;
    }

   

    void spawn_enemy_s(GameObject enemy_type, int player_position)
    {
        GameObject go = Instantiate(enemy_type, transform.position, Quaternion.identity);
        EnemyA foe = go.GetComponent<EnemyA>();
        foe.hp = 3 + counter;
        foe.lane = spawner_lane;
        foe.cp = player_position;
        counter += 1;
    }


    IEnumerator every_three_seconds()
    {
     
        spawn_enemy(basic_enemy, cp);
        yield return new WaitForSeconds(14f);
        spawn_enemy(basic_enemy, cp);
        yield return new WaitForSeconds(3f);
        spawn_enemy(basic_enemy, cp);
        yield return new WaitForSeconds(8f);
        spawn_enemy(basic_enemy, cp);
        yield return new WaitForSeconds(6f);
        spawn_enemy(basic_enemy, cp);
        yield return new WaitForSeconds(4f);
        spawn_enemy(basic_enemy, cp);
        yield return new WaitForSeconds(8f);
        spawn_enemy_f(f_enemy, cp);
        yield return new WaitForSeconds(15f);
        spawn_enemy(basic_enemy, cp);
        yield return new WaitForSeconds(1f);
        spawn_enemy(basic_enemy, cp);
        //yield return new WaitForSeconds(1f);
        spawn_enemy(basic_enemy, cp);
        //yield return new WaitForSeconds(1f);
        spawn_enemy(basic_enemy, cp);
        yield return new WaitForSeconds(1f);

        //1 min

        yield return new WaitForSeconds(18f);
        spawn_enemy_f(f_enemy, cp);
        yield return new WaitForSeconds(3f);

        //80 Seconds
        yield return new WaitForSeconds(1f);
        spawn_enemy_s(s_enemy, cp);
        yield return new WaitForSeconds(2f);
        spawn_enemy(basic_enemy, cp);
        yield return new WaitForSeconds(2f);
        spawn_enemy_s(s_enemy, cp);
        yield return new WaitForSeconds(1f);
        spawn_enemy(basic_enemy, cp);
        yield return new WaitForSeconds(1f);
        spawn_enemy(basic_enemy, cp);
        yield return new WaitForSeconds(5f);
        //spawn_enemy_s(s_enemy, cp);
        yield return new WaitForSeconds(2f);
        spawn_enemy(basic_enemy, cp);
        yield return new WaitForSeconds(2f);
        spawn_enemy_s(s_enemy, cp);
        yield return new WaitForSeconds(2f);
        //spawn_enemy_s(s_enemy, cp);
        yield return new WaitForSeconds(2f);
        spawn_enemy_f(f_enemy, cp);
        yield return new WaitForSeconds(3f);
        //spawn_enemy_f(f_enemy, cp);
        yield return new WaitForSeconds(4f);
        spawn_enemy_f(f_enemy, cp);
        yield return new WaitForSeconds(4f);
        //spawn_enemy_s(s_enemy, cp);
        yield return new WaitForSeconds(5f);
        spawn_enemy_s(s_enemy, cp);

    }

    void Start()
    {
        //spawn_enemy(basic_enemy, cp);
        StartCoroutine("every_three_seconds");
    }


    void Update()
    {




        //Track The Player's Position
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

            //Track Shots
            if (Input.GetKeyDown(shoot))
        {
            if (counter > 0)
            {
                if (cp == spawner_lane)
                {
                    counter = counter - 1;
                }
                    
      
            }
        }

    }



}
