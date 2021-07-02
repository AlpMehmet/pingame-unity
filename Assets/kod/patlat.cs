using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patlat : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioClip pat;
    public Transform prefab;
    public Transform obje;
    public Transform pof;
    public int say = 3;
    void Start()
    {
        if (PlayerPrefs.GetInt("ses") == 0)
        {

            gameObject.GetComponent<AudioSource>().PlayOneShot(pat, 1);
        }
        Instantiate(pof, new Vector3(obje.transform.localPosition.x, obje.transform.localPosition.y, obje.transform.localPosition.z), Quaternion.identity);

        for (int i = 0; i<say;i++)
        {
            Instantiate(prefab, new Vector3(obje.transform.localPosition.x, obje.transform.localPosition.y, obje.transform.localPosition.z), Quaternion.identity);

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
