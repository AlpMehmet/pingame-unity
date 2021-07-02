using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{

    public GameObject barnak;
    bool mouseDrag = false;
    void Update()
    {
        Vector2 konum = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (mouseDrag == true)
        {
            transform.Rotate(0, 0, 1);

        }
    }

    void OnMouseDown()
    {
        mouseDrag = true;
        if(barnak != null)
        {
            Destroy(barnak);
        }

    }

    void OnMouseUp()
    {
        mouseDrag = false;

    }
}
