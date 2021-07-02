using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class kilit : MonoBehaviour
{
    // Start is called before the first frame 


    public AudioClip dupdup;

    public int say = 3;

    public TextMeshProUGUI kilitli;

    public GameObject kilitt;

    public GameObject olus;

    public GameObject onay;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        if (int.Parse(kilitli.text) == 0)
        {
            olus.GetComponent<patlat>().enabled = true;
            onay.GetComponent<onay>().enabled = true;
            Destroy(gameObject);
            Destroy(kilitt);
            Destroy(kilitli);
        }

    }

    void OnTriggerExit(Collider col)
    {

    

        if (col.gameObject.tag == "Finish" || col.gameObject.tag == "Respawn")
        {
            say = say - 1;
            Destroy(col.gameObject);
            if (PlayerPrefs.GetInt("ses") == 0)
            {
                gameObject.GetComponent<AudioSource>().PlayOneShot(dupdup, 1);
            }

            kilitli.text = say.ToString();

        }

      

        }

   
}
