using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nextlevel : MonoBehaviour
{
    // Start is called before the first frame update

    //public AudioSource source;
    public AudioClip next;

    public string bolum = "1";
    void Start()
    {
        //source = GetComponent<AudioSource>();
        if (PlayerPrefs.GetInt("ses") == 0)
        {

            gameObject.GetComponent<AudioSource>().PlayOneShot(next, 1);
        }
        //source.PlayOneShot(next, 1);

    }

    // Update is called once per frame
    void Update()
    {

        if (gameObject.transform.localScale.x < 0.1352448)
        {
            gameObject.transform.localScale += new Vector3(0.009f, 0.009f, 0);
        }

        if (Input.GetKeyDown("escape"))
        {
            Application.LoadLevel("menu");
        }
    }

    void OnMouseUp()
    {
        
        Application.LoadLevel(bolum);
        PlayerPrefs.SetInt("level", int.Parse(bolum));

    }
}
