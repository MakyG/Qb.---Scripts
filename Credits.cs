using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    public GameObject BlackAnimation;
    public GameObject OutBlackAnimation;
    void Start()
    {
        StartCoroutine("sequence");
    }
    IEnumerator sequence()
    {
        OutBlackAnimation.SetActive(true);
        yield return new WaitForSeconds(2f);
        OutBlackAnimation.GetComponent<Animation>().Play("OutBlackAnim");
        yield return new WaitForSeconds(4f);
        BlackAnimation.SetActive(true);
        BlackAnimation.GetComponent<Animation>().Play("BlackAnim");
        yield return new WaitForSeconds(1.2f);
        SceneManager.LoadScene("Menu");
    }
}
