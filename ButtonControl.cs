using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonControl : MonoBehaviour
{
    // Start is called before the first frame update
    public bool buttonClicked = false;
    void Start()
    {
        
    }
    public void IsButtonPushed()
    {
        buttonClicked = true;
    }
    // Update is called once per frame
    void Update()
    {
        if(buttonClicked == true)
        {

        }
    }
}
