using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LifeManager : MonoBehaviour
{
    public static LifeManager instance;

    public Text lifeText;

    public string levelName;


    private static int lives = 3;

    void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex == 1) { lives = 3; } 
        lifeText.text = "LIVES: " + lives.ToString();
    }

    public void AddLife()
    {
        lives += 1;
        lifeText.text = "LIVES: " + lives.ToString();
    }

    public void LoseLife()
    {
        lives -= 1;
        lifeText.text = "LIVES: " + lives.ToString();
        if(lives <= 0)
        {
            SceneManager.LoadScene(levelName);
        }
        if(lives > 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        
    }

}