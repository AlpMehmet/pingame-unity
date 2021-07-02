using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yanasurukle : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 dist;
    Vector3 startPos;

    public GameObject parmak;
    float posX;
    float posZ;
    float posY;
    void OnMouseDown()
    {
        startPos = transform.position;
        dist = Camera.main.WorldToScreenPoint(transform.position);
        posX = Input.mousePosition.x - dist.x;
        posY = Input.mousePosition.y - dist.y;
        posZ = Input.mousePosition.z - dist.z;

        if (parmak != null)
        {
            Destroy(parmak);
        }
    }

    void OnMouseDrag()
    {
        if (transform.localPosition.x < -0.432f & transform.localPosition.x > -0.757f)
        {
            float disX = Input.mousePosition.x - posX;
            float disY = Input.mousePosition.y - posY;
            float disZ = Input.mousePosition.z - posZ;
            Vector3 lastPos = Camera.main.ScreenToWorldPoint(new Vector3(disX, disY, disZ));

            transform.position = new Vector3(lastPos.x, startPos.y, startPos.z);
           
        }

        if (transform.localPosition.x > -0.432f)
        {
            transform.position = new Vector3(-0.434f, transform.localPosition.y, transform.localPosition.z);
        }

        if (transform.localPosition.x < -0.757f)
        {
            transform.position = new Vector3(-0.756f, transform.localPosition.y, transform.localPosition.z);
        }



    }
}
