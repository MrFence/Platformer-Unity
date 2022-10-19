using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffectPlayer : MonoBehaviour
{
    public AudioSource src;
    public AudioClip pickupCoin;

    public void Token()
    {
        src.clip = pickupCoin;
        src.Play();
    }
}
