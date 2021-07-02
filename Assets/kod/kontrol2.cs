using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class kontrol2 : MonoBehaviour
{

    public TextMesh sayac;
    public GameObject onayli;
    public Sprite carpi;
    public int kontrolsay = 2;
    public float say = 0.5f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (int.Parse(sayac.text) < kontrolsay)
        {
            say -= Time.deltaTime;

            if (say < 0 && int.Parse(sayac.text) >= 1)
            {
                onayli.GetComponent<SpriteRenderer>().sprite = carpi;
                onayli.GetComponent<onay>().enabled = true;
                if (say < -2)
                {
                    Application.LoadLevel(Application.loadedLevel);
                }
            }


        }

    }
}
