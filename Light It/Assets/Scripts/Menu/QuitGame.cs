using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuitGame : MonoBehaviour
{
     void Start()
    {
        
    }
    private void Update()
    {
        
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quit game");
    }
}
