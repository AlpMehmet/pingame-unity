using UnityEngine;
using System.Collections;

public class surukle : MonoBehaviour
{
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

        if(parmak != null)
        {
            Destroy(parmak);
        }
    }

    void OnMouseDrag()
    {
        if(transform.localPosition.y <1.5f & transform.localPosition.y >0.5f)
        {
            float disX = Input.mousePosition.x - posX;
            float disY = Input.mousePosition.y - posY;
            float disZ = Input.mousePosition.z - posZ;
            Vector3 lastPos = Camera.main.ScreenToWorldPoint(new Vector3(disX, disY, disZ));
            transform.position = new Vector3(startPos.x, lastPos.y, startPos.z);
        }

        if(transform.localPosition.y < 0.5f)
        {
            transform.position = new Vector3(transform.localPosition.x, 0.6f, transform.localPosition.z);
        }

        if (transform.localPosition.y > 1.5f)
        {
            transform.position = new Vector3(transform.localPosition.x, 1.47f, transform.localPosition.z);
        }


    }


}