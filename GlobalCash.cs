using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GlobalCash : MonoBehaviour
{
    public GameObject CashDisplay;
    public GameObject CoinSoundAudio;
    public static int CashCount = 0;
    public int InternalCash;

    
    void Update()
    {
        InternalCash = CashCount;
        CashDisplay.GetComponent<Text>().text = "$" + InternalCash;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Coin100"))
        {
            Destroy(other.gameObject);
            CoinSoundAudio.GetComponent<AudioSource>().Play();
            CashCount += 100;
        }
        if (other.gameObject.CompareTag("Coin200"))
        {
            Destroy(other.gameObject);
            CoinSoundAudio.GetComponent<AudioSource>().Play();
            CashCount += 200;
        }
    }
}
