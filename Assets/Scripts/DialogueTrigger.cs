using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueTrigger : MonoBehaviour
{
    public GameObject breakText;

    [SerializeField] float soundLevel = 0.7f;

    public AudioClip triggerSound;
    AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        breakText.SetActive(true);
        Destroy(gameObject);

        if(triggerSound!= null)
        {
            audioSource.PlayOneShot(triggerSound,soundLevel);
        }
    }
}
