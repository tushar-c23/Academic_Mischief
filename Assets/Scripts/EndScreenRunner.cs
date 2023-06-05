using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScreenRunner : MonoBehaviour
{
    public void mainMenu()
    {
        SceneManager.LoadScene("StartGame");
    }
}
