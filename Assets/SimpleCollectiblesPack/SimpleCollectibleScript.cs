using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]
public class SimpleCollectibleScript : MonoBehaviour {

	public bool rotate; // do you want it to rotate?

	public float rotationSpeed;

	public AudioSource collectSound;

	//public GameObject collectEffect;

	public TextMeshProUGUI text;
	public int count;

	// Use this for initialization
	void Start () {
		PlayerPrefs.SetInt("Score", 0);

	}

	// Update is called once per frame
	void Update () {

		if (rotate)
			transform.Rotate (Vector3.up * rotationSpeed * Time.deltaTime, Space.World);

	}

	void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player")) {
			collectSound.Play();
			count += 10;
			PlayerPrefs.SetInt("Score", count);
			text.text = count.ToString();
		}
	}
}
