using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tik2 : MonoBehaviour
{

    // Start is called before the first frame update
  
    public AudioClip pinses;
    public GameObject parmak;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            Application.LoadLevel("menu");
        }
    }

    void OnMouseUp()
    {
        if(parmak != null)
        {
            Destroy(parmak);
        }

        gameObject.GetComponent<tik>().enabled = true;
        if (PlayerPrefs.GetInt("ses") == 0)
        {
            gameObject.GetComponent<AudioSource>().PlayOneShot(pinses, 1);
        }
        
    }
}
