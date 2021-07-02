using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class atis : MonoBehaviour
{
    public GameObject prefab;
    public int distance = 10;

    // Use this for initialization
    void Start()
    {
    }
    // Update is called once per frame
 void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {

            var position =new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
            position = Camera.main.ScreenToWorldPoint(position);
            var go = Instantiate(prefab, transform.position, Quaternion.identity) as GameObject;
            go.transform.LookAt(position);
            Debug.Log(position);
            go.GetComponent<Rigidbody>().AddForce(go.transform.forward * 1000);
        }

    }

 

}
