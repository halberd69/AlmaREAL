using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collecting : MonoBehaviour
{
    private float coin = 0;
    [SerializeField] private AudioClip pickupSound;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.transform.tag == "coin")
        {
            SoundManager.instance.PlaySound(pickupSound);
            Destroy(other.gameObject);
        }
    }
}
