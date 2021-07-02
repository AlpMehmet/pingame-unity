using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dondurarti : MonoBehaviour
{
    public float derece;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseUp()
    {
        transform.Rotate(0f, derece, 0f, Space.Self);
    }
}
