using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class DestroyBall : MonoBehaviour
{

    public GameObject Player;
    public GameObject BlackAnimation;
    public GameObject Camera;
    public GameObject DeathImpulse;
    public ParticleSystem ParticlesDeath;
    public AudioSource DeathSound;


    public void Update()
    {
        ParticlesDeath.transform.position = Player.transform.position;

        if(Player == null)
        {
            return;
        }
    }
    IEnumerator FinishDelay()
    {
        BlackAnimation.SetActive(true);
        BlackAnimation.GetComponent<Animation>().Play("BlackAnim");
        yield return new WaitForSeconds(0.1f);
        DeathImpulse.GetComponent<Animation>().Play();
        DeathSound.GetComponent<AudioSource>().Play();
        ParticlesDeath.Play();
        Player.SetActive(false);
        yield return new WaitForSeconds(0.8f);
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Cube") || other.gameObject.CompareTag("Ball"))
        {
            StartCoroutine("FinishDelay");
        }
    }
}
