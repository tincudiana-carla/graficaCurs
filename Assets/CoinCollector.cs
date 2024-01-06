using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCollector : MonoBehaviour
{
    public Text coinsText;
    public AudioSource coinsAudioSource;
    int coins = 0;
    private void OnTriggerEnter(Collider other)
    {
        
        if(other.gameObject.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            coins++;
            coinsText.text = "Coins : " + coins;
            coinsAudioSource.Play();
        }
    }
}
