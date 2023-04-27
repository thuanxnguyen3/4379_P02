using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;


[RequireComponent(typeof(AudioSource))]
public class SimpleCollectibleScript : MonoBehaviour
{

	public bool rotate; // do you want it to rotate?

	public float rotationSpeed;

	public static event Action OnCollected;

	//public GameObject collectEffect;

	// Use this for initialization

	// Update is called once per frame
	void Update()
	{

		if (rotate)
			transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime, Space.World);

	}

	void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			OnCollected?.Invoke();
			/*
			collectSound.Play();
			count += 10;
			PlayerPrefs.SetInt("Score", count);
			text.text = count.ToString();
			Destroy(gameObject);
			*/
			Destroy(gameObject);

		}
	}
}
