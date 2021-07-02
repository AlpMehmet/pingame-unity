using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class titresim : MonoBehaviour
{
    public Sprite acik;
    public Sprite kapali;

    public int say = 0;
    void Start()
    {
        say = PlayerPrefs.GetInt("titresim");
        if (PlayerPrefs.GetInt("titresim") == 0)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = acik;
        }
        else
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = kapali;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseUp()
    {

        say = say + 1;
        if (say == 1)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = kapali;
            PlayerPrefs.SetInt("titresim", 1);
        }
        else
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = acik;
            PlayerPrefs.SetInt("titresim", 0);
            say = 0;

        }
    }
}
