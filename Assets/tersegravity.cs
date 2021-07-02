using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tersegravity : MonoBehaviour
{

    void OnTriggerEnter(Collider c)
    {   
        int say = 0;
        if (c.gameObject.tag=="pin")
        {

        }
        else
        {
            var magnitude = 250;
            float forceSekme=0;
            var force = transform.position - c.transform.position;

            if (c.gameObject.tag == "Player")
            {

                forceSekme = transform.position.y + 50;
                c.GetComponent<Rigidbody>().AddForce(0, forceSekme, 0);
            }
            if(c.gameObject.tag == "Finish")
            {
                if (say==0)
                {

                        c.GetComponent<Rigidbody>().AddForce(0, forceSekme, 0);
                    forceSekme = transform.position.y + 200;
    

                }
                say++;

            }
            force.Normalize();
            c.GetComponent<Rigidbody>().AddForce(-force * magnitude);
        }


    }

}
 