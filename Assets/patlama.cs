using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patlama : MonoBehaviour
{

    public GameObject bomb;
    public float power = 5.0f;
    public float radius = 5.0f;
    public float upforce = 1.0f;

    public GameObject yazim;
public GameObject yazi;
public GameObject obje;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (bomb == enabled)
        {
            Invoke("Deto",1);


            //Destroy(yazim, 1);

            Destroy(gameObject,1);
        }
        
    }

    void Deto()
    {
        yazim = GameObject.Instantiate(yazi as GameObject, new Vector3((gameObject.transform.localPosition.x), (gameObject.transform.localPosition.y), gameObject.transform.localPosition.z), transform.rotation) as GameObject;

        Vector3 expo = bomb.transform.position;
        Collider[] colliders = Physics.OverlapSphere(expo, radius);
        foreach (Collider hit in colliders)
        {
            Rigidbody rb = hit.GetComponent<Rigidbody>();
            if(rb != null)
            {
                rb.AddExplosionForce(power, expo, radius, upforce, ForceMode.Impulse);
            }
        }
    }
}
