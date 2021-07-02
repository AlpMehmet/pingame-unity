using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class you : MonoBehaviour
{
    public Sprite bas;
    public Sprite kalk;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = bas;
    }
    void OnMouseUp()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = kalk;
    }
}
