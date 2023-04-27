using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ScoringSystem : MonoBehaviour
{
    public TextMeshProUGUI text;
    public int count;
    [SerializeField] AudioSource audioSFX;
    private void Awake()
    {
        audioSFX = GetComponent<AudioSource>();
    }
    private void Start()
    {
        PlayerPrefs.SetInt("Score", 0);
    }
    void OnEnable() => SimpleCollectibleScript.OnCollected += OnCollectibleCollected;
    void OnDisable() => SimpleCollectibleScript.OnCollected -= OnCollectibleCollected;

    public void OnCollectibleCollected()
    {
        audioSFX.Play();
        count += 10;
        PlayerPrefs.SetInt("Score", count);
        text.text = count.ToString();
    }
}
