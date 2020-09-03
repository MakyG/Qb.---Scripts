using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeGravity : MonoBehaviour
{
    public Rigidbody2D rb;
    public GameObject Player;
    public GameObject ButtonAnimObj;
    public bool AnimationPlayed = false;
    void Start()
    {
        rb = Player.GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Cube") && AnimationPlayed == false)
        {
            ButtonAnimObj.GetComponent<Animation>().Play("ButtonAnim");
            rb.GetComponent<Rigidbody2D>().gravityScale = -1;
            AnimationPlayed = true;
        }
    }
}
