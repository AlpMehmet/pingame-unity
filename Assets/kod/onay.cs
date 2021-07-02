using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onay : MonoBehaviour
{

    public AudioClip pat;
    public AudioClip carpi1;
    public Sprite carpi;


    public GameObject next;
    public float say = 0.5f;
    // Start is called before the first frame update
    void Start()
    {


        if (gameObject.GetComponent<SpriteRenderer>().sprite == carpi)
        {
            if (PlayerPrefs.GetInt("ses") == 0)
            {

                gameObject.GetComponent<AudioSource>().PlayOneShot(carpi1, 1);
            }
        }
        else
        {
            if (PlayerPrefs.GetInt("ses") == 0)
            {
                gameObject.GetComponent<AudioSource>().PlayOneShot(pat, 1);
            }

        }

        if (PlayerPrefs.GetInt("titreşim") == 0)
        {
            Handheld.Vibrate();

        }


    }

    // Update is called once per frame
    void Update()
    {
        say -= Time.deltaTime;
        if (gameObject.transform.localScale.x < 0.04)
        {
            gameObject.transform.localScale += new Vector3(0.0015f, 0.0015f, 0);
        }

        if (say < 0)
        {
            next.GetComponent<nextlevel>().enabled = true;
        }

        
    }
}
