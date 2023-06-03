using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrailCamera : MonoBehaviour
{
    public Transform target;
    public float trailDistance = 0.2f;
    public float heightOffset = 2.0f;
    public float cameraDelay = 0.7f;

    // Update is called once per frame
    void Update()
    {
       // Vector3 var = (0f,0f,-3f);
        Vector3 followPos = (target.position - target.forward * trailDistance);

        followPos.y += heightOffset;
        transform.position += (followPos - transform.position) * cameraDelay;

        transform.LookAt(target.transform);
    }
}