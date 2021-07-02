using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ses : MonoBehaviour
{
    public Sprite acik;
    public Sprite kapali;

    public int say = 0;
    void Start()
    {
        say = PlayerPrefs.GetInt("ses");
        if (PlayerPrefs.GetInt("ses") == 0)
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
            PlayerPrefs.SetInt("ses", 1);
        }
        else
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = acik;
            PlayerPrefs.SetInt("ses", 0);
            say = 0;

        }
    }
}
