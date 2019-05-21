using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Core_controller : MonoBehaviour
{
    //THe core's remaining health
    public int Health = 3;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        Health = Health - 1;
        if (Health == 0)
        {
            Destroy(gameObject);

        }
    }
}
