using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hedefegotur : MonoBehaviour
{
    public float horizontalInput;
    public int nekadarmesafe;
    public float verticalInput;
    private float movementSpeed = 5f;
    public float dereceZ;
    public float dereceY;
    public float dereceX;
    public float dereceZ2;
    public float dereceY2;
    public float dereceX2;
    int say=0;
    void Start()
    {
        say++;
    }
    void Update()
    {
        if (say==3)
        {
            if (nekadarmesafe != 0)
            {
                nekadarmesafe--;
                transform.position = transform.position + new Vector3(horizontalInput * movementSpeed * 0.016f, verticalInput * movementSpeed * 0.0168611f, 0);
            }
           
        }
    }
    void OnMouseUp()
    {

        if (say == 1)
        {
            transform.Rotate(dereceX, dereceY, dereceZ, Space.Self);
            say++;
        }
        else if (say == 2)
        {
            say++;
        }
        else if (say == 3)
        {
            transform.Rotate(dereceX2, dereceY2, dereceZ2, Space.Self);

        }

       
    }


}
