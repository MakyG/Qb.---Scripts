using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public Rigidbody2D rb;
    public float rotateSpeed = -0.5f;
    void Start()
    {
        rb.GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        rb.transform.Rotate(0, 0, rotateSpeed, Space.World);
    }
}
