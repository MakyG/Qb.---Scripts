using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlassBreak : MonoBehaviour
{
    public GameObject GlassCollider;
    // public Rigidbody2D rb;
    // public float speedReal;

    private ParticleSystem GlassParticles;
    private SpriteRenderer sr;
    /*
    public void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }
    public void Update()
    {
        speedReal = rb.GetComponent<Rigidbody2D>().velocity.magnitude * 3.6f;
        print(speedReal);
    }
    */
    private void Awake()
    {
        GlassParticles = GetComponentInChildren<ParticleSystem>();
        sr = GetComponent<SpriteRenderer>();
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Cube"))
        {
            StartCoroutine("Break");
        }
    }
    private IEnumerator Break()
    {
        GlassCollider.SetActive(false);
        sr.enabled = false;
        GlassParticles.Play();
        yield return new WaitForSeconds(GlassParticles.main.startLifetime.constantMax);
        Destroy(gameObject);
    }
}
