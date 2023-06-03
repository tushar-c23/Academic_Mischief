using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] private float waitTime = 2f;

    #region Method1

    private float elapsedTime = 0f;

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;
        print(elapsedTime);
        if (elapsedTime > waitTime) {
            print("time elapsed");
            elapsedTime = 0f;
        }
    }

    #endregion

    #region Method2

    IEnumerator TimerCoroutine()
    {
        yield return new WaitForSeconds(waitTime);
        print("Time elapsed");
    }

    void Start()
    {
        StartCoroutine(TimerCoroutine());
    }

    #endregion
}
