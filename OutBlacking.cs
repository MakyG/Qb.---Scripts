using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutBlacking : MonoBehaviour
{
    public GameObject OutBlackAnimation;
    
    public void Start()
    {
        OutBlackAnimation.SetActive(true);
        OutBlackAnimation.GetComponent<Animation>().Play("OutBlackAnim");
    }

}
