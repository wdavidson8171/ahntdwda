using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using TMPro;
using System;

public class IH8Unity : MonoBehaviour
{
    public AudioClip rain;
    public AudioClip car;
    public AudioClip footsteps;
    public AudioSource audioSource;
    float duration = 0.7f;
    float time;

    public TMP_Text t1;
    public TMP_Text t2;
    public GameObject bg;
    // Start is called before the first frame update
    IEnumerator PlaySounds() {
        audioSource.PlayOneShot(rain, duration);
        audioSource.PlayOneShot(car, duration);
        yield return new WaitForSeconds(17);
        audioSource.PlayOneShot(footsteps, duration);

    }

    IEnumerator texty() {
        t1.enabled = true;
        t2.enabled = false;
        bg.SetActive(false);
        yield return new WaitForSeconds(17);
        t1.enabled = false;
        t2.enabled = true;
        yield return new WaitForSeconds(17);
        t2.enabled = false;
        bg.SetActive(true);
    }

    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        StartCoroutine(PlaySounds());
        StartCoroutine(texty());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
