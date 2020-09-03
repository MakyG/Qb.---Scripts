using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameSetup : MonoBehaviour
{
    public GameObject MainCanvas;
    public GameObject Car1;
    public GameObject Car2;

    public void StartGame()
    {
        MainCanvas.SetActive(false);
    }
    public void EndGame()
    {
        SceneManager.LoadScene("SampleScene");

    }
    public void RestartGame()
    {
        
        Car1.transform.position = new Vector3(26, -91, 5);
        Car2.transform.position = new Vector3(26, -91, 5);
    }
}
