using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oldur : MonoBehaviour
{
    // Start is called before the first frame update

  
    public Transform pof;
    public GameObject onayli;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
           
            Instantiate(pof, new Vector3(gameObject.transform.localPosition.x, gameObject.transform.localPosition.y, gameObject.transform.localPosition.z), Quaternion.identity);

            Destroy(gameObject);

            onayli.GetComponent<patlayinca>().enabled = true;

        }
    }
}
