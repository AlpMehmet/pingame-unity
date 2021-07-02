using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bolum39animasyondurdur : MonoBehaviour
{
    int say;
    public Animator don1;

    // Start is called before the first frame update
    void Start()
    {

        say++;

            don1 = GetComponent<Animator>();

    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (say == 1)
            {
                say++;
              don1.GetComponent<Animator>().enabled = false;

            }
            else if (say == 2)
            {
                say =1;
                don1.GetComponent<Animator>().enabled = true;

            }
        }

    }


}
