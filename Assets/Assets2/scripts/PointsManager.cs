using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PointsManager : MonoBehaviour
{
    public Text scoreUI;
    public Button timecounter1;
    public Button timecounter2;
    // Start is called before the first frame update
    void Start()
    {
        if(levelSelection.level_temp == 1)
        {
            timecounter1.gameObject.SetActive(true);
        }
        else
        {
            timecounter2.gameObject.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        scoreUI.text = ClipboardSpawner.points.ToString();
    }
}
