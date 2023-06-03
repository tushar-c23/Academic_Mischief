using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelSelection : MonoBehaviour
{
    public static int level_temp = 1;
    public void gamescenechanger()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void level1selector()
    {
        level_temp = 1;
    }
    public void level2selector()
    {
        level_temp = 2;
    }
}