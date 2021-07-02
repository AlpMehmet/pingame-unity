using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class res : MonoBehaviour
{
    public Transform prefab;
    public Transform obje;

 
    public int say;
    public int saymak = 2;
    int bak = 0;
    float bi = 0.2f;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
    
    }


    void OnTriggerExit(Collider col)
    {
        bak = bak + 1;


        if (bak == 1)
        {
            if (col.gameObject.tag == "Finish" || col.gameObject.tag=="Respawn")
            {

           

                for (int i = 0; i < saymak; i++)
                {

                    Transform yeni = Instantiate(prefab, new Vector3(obje.transform.localPosition.x, obje.transform.localPosition.y+ bi, obje.transform.localPosition.z), Quaternion.identity);
                    //yeni.GetComponent< Rigidbody >().constraints = RigidbodyConstraints.FreezePositionX;
                    bi = bi + 0.1f;

                }




            }

        }
    }
}
