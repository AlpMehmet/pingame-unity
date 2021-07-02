using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class baslatma : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Awake()
    {
        Screen.orientation = ScreenOrientation.Portrait;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseUp()
    {
        Application.LoadLevel(Application.loadedLevel);
    }


}
