using UnityEngine;
using System.Collections;
using static System.Net.Mime.MediaTypeNames.Application;

// Quits the player when the user hits escape

public class Escape : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }
}
