using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kursun : MonoBehaviour
{
    Vector3 pos;
    float speed = 100;
    public GameObject yazim;
    public GameObject yazi;
    public GameObject obje;
    // Use this for initialization
    void Start()
    {
        Destroy(gameObject, 4);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "WoodenBlock")
        {
            yazim = GameObject.Instantiate(yazi as GameObject, new Vector3((gameObject.transform.localPosition.x), (gameObject.transform.localPosition.y), gameObject.transform.localPosition.z), transform.rotation) as GameObject;

            Destroy(gameObject);




        }

    }
}
