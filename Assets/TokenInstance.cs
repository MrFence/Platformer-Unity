using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TokenInstance : MonoBehaviour
{
    public AudioSource src;
    public AudioClip pickupCoin;




    void Start()
    {
    
   
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {

        var player = collision.collider.GetComponent<PlayerMovement>();
        if (player)
        {
            Destroy(gameObject);
            ScoreManager.instance.AddPoint();
          
            
            src.clip = pickupCoin;
            src.Play();
            
        }


    }

}