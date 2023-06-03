using UnityEngine;
using UnityEngine.UI;
public class SceneTimer1 : MonoBehaviour
{
   // public float timerDuration = 10f; // The duration of the timer in seconds
    [SerializeField] private float waitTime = 25f;
    public Text scoreUI;
    public Image youwonfinal;
    public Image youlostfinal;

    #region Method1

    private float elapsedTime = 0f;

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;
        //print(elapsedTime);
        if (elapsedTime > waitTime)
        {
            print("time elapsed");
            //elapsedTime = 0f;
        }
        scoreUI.text = elapsedTime.ToString();
    }
    #endregion
    private void Start()
    {
        StartCoroutine(TimerCoroutine());
    }
    private System.Collections.IEnumerator TimerCoroutine()
    {
        yield return new WaitForSeconds(waitTime);

        // Timer has ended, stop the scene playback
        Time.timeScale = 0f;
        if (ClipboardSpawner.points >= 17)
        {
            youwonfinal.gameObject.SetActive(true);
        }
        else
        {
            youlostfinal.gameObject.SetActive(true);
        }
    }
}
