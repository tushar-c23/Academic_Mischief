using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodGirlsLookAtCam : MonoBehaviour
{
    public GameObject arCam;
    // Update is called once per frame
    void Update()
    {
        transform.LookAt(arCam.transform);
    }
}
