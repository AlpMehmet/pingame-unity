using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class menutik : MonoBehaviour
{
    public Sprite bas;
    public Sprite kalk;
    public TextMeshPro level;
    string levelli;

    // Start is called before the first frame update
    void Start()
    {
        //PlayerPrefs.SetInt("level", 0);
        if (PlayerPrefs.GetInt("level")==0)
        {
            level.text = ("LEVEL 1");
            levelli = "1";

        }
        else
        {
            level.text = ("LEVEL " + PlayerPrefs.GetInt("level")).ToString();
            levelli = PlayerPrefs.GetInt("level").ToString();

        }
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
        Application.LoadLevel(levelli);
    }
}
