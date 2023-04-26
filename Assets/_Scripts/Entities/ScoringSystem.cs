using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoringSystem : MonoBehaviour
{
    public GameObject scoreText;
    public int scoreVal;
    public AudioSource collectSFX;

    private void OnTriggerEnter(Collider other)
    {
        collectSFX.Play();
        scoreVal += 10;
        scoreText.GetComponent<Text>().text = "Score: " + scoreVal;
        Destroy(gameObject);
    }
}
