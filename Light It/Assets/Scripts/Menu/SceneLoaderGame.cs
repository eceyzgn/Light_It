using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoaderGame : MonoBehaviour
{
    public void NextScene(int level)
    {

        SceneManager.LoadScene(1);
    }
}
