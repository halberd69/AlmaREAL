using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    private float checkpoint = 0;
    [SerializeField] private AudioClip pickupSound;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "checkpoint")
        {
            SoundManager.instance.PlaySound(pickupSound);
        }
    }
}
