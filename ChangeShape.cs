using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeShape : MonoBehaviour
{
    public GameObject Ball;
    public GameObject Cube;
    public GameObject Camera;
    public GameObject ImpulseBlue;
    public GameObject ImpulseOrange;
    public Rigidbody2D rb;
    public bool IsBall = true;



    void Change()
    {
        if (IsBall)
        {
            Ball.SetActive(true);
            Cube.SetActive(false);
            ImpulseOrange.GetComponent<Animation>().Play();
            rb.GetComponent<Rigidbody2D>();
            rb.mass = 0.03f;
        }
        else
        {
            Ball.SetActive(false);
            Cube.SetActive(true); 
            ImpulseBlue.GetComponent<Animation>().Play();
            rb.GetComponent<Rigidbody2D>().gravityScale = 1;
            rb.mass = 2;
        }

    }
        public void MobileChange() {
            IsBall = !IsBall;
            Change();
        }
    
}
