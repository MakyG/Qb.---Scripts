using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public int lastSceneIndex = 1;
    public GameObject BlackAnimation;

    IEnumerator StartGame()
    {
        BlackAnimation.SetActive(true);
        BlackAnimation.GetComponent<Animation>().Play("BlackAnim");
        yield return new WaitForSeconds(1.2f);
        SceneManager.LoadScene("Level1");
    }
    public void LoadLastLevel()
    {
        StartCoroutine("StartGame");
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
