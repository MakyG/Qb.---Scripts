using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishScript : MonoBehaviour
{

    public GameObject Finish;
    public GameObject PauseCanvas;
    public GameObject BlackAnimation;

    IEnumerator FinishDelay()
    {
        yield return new WaitForSeconds(1.3f);
        BlackAnimation.SetActive(true);
        BlackAnimation.GetComponent<Animation>().Play("BlackAnim");
        yield return new WaitForSeconds(0.85f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        
        StartCoroutine("FinishDelay");
        Finish.GetComponent<Animation>().Play("FinishAnim");
    }

    //Stop all sounds
    private AudioSource[] allAudioSources;

    public void ClickMenu()
    {
        allAudioSources = FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
        foreach (AudioSource audioS in allAudioSources)
        {
            audioS.Stop();
        }
        Time.timeScale = 1;
        
        SceneManager.LoadScene("Menu");
    }


    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(scene.name);
        }
    }
    public void PauseGame()
    {
        Time.timeScale = 0;
    }
    public void ContinueGame()
    {
        Time.timeScale = 1;
    }
    public void ReloadScene()
    {
        Scene sceneS = SceneManager.GetActiveScene();
        SceneManager.LoadScene(sceneS.name);
        Time.timeScale = 1;
    }
}
