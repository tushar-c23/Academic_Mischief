using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMerge : MonoBehaviour
{
    public void RunnerGameStart()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void AssDestroyerStart()
    {
        SceneManager.LoadScene("Scene_PlayerSelection");
    }
}
