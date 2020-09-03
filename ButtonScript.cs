using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{

    public GameObject ButtonAnimObj;
    public GameObject DoorOpeningAnim;
    public bool AnimationPlayed = false;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Cube") && AnimationPlayed == false)
        {
            ButtonAnimObj.GetComponent<Animation>().Play("ButtonAnim");
            DoorOpeningAnim.GetComponent<Animation>().Play("DoorAnim");
            AnimationPlayed = true;
        }
    }
}
