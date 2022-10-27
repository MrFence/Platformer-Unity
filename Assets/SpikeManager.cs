using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeManager : MonoBehaviour
{
    public static SpikeManager instance;

  

    void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!collision.gameObject) return;
        var player = collision.gameObject.GetComponent<PlayerMovement>();
        if (player)
        {
            LifeManager.instance.LoseLife();          
        }


    }
}
