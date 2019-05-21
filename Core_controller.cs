using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Core_controller : MonoBehaviour
{
    //THe core's remaining health
    public int Health = 4;

    //Health Bar Images to be set deactive
    public Image healthfour;
    public Image healththree;
    public Image healthtwo;
    public Image healthone;

    public AudioClip CoreHit;
    public AudioClip CoreDie;

    public AudioSource SoundSource;





    // Start is called before the first frame update
    void Start()
    {
        healthfour.enabled = true;
        healththree.enabled = true;
        healthtwo.enabled = true;
        healthone.enabled = true;
    }

    IEnumerator level_timer()
    {

        yield return new WaitForSeconds(130f);

    }


    void start()
    {
        StartCoroutine("level_timer");
    }



    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
        TakeDamage();

    }

    private void TakeDamage()
    {

        if (Health < 4)
        {
            healthfour.enabled = false;
            if (Health < 3)
            {
                healththree.enabled = false;
                if (Health < 2)
                {
                    healthtwo.enabled = false;
                    if (Health < 1)
                    {
                        healthone.enabled = false;
                        Destroy(gameObject);
                    }
                }
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        Health = Health - 1;
        if (Health>0)
        {
            SoundSource.clip = CoreHit;
            SoundSource.Play();
        }
        if (Health == 0)
        {
            SoundSource.clip = CoreDie;
            SoundSource.Play();

        }
    }
}
