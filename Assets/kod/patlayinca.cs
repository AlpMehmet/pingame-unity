using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patlayinca : MonoBehaviour
{
    // Start is called before the first frame update

    public float say = 0.5f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        say -= Time.deltaTime;

        if (say < 0)
        {
            Application.LoadLevel(Application.loadedLevel);
        }
        }
}
