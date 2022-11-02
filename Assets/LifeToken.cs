using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeToken : MonoBehaviour
{
    //public AudioSource src;
    //public AudioClip pickupCoin;




    void Start()
    {


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var player = collision.gameObject.GetComponent<PlayerMovement>();
        if (player)
        {
            Destroy(gameObject);
            LifeManager.instance.AddLife();


            //src.clip = pickupCoin;
            //src.Play();

        }
    }

}