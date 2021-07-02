using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dondurtik : MonoBehaviour
{
    public float derece;

    // Start is called before the first frame update

    public GameObject parmak;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }
    void OnMouseUp()
    {
        transform.Rotate(0f, 0f, derece, Space.Self);
    }
}