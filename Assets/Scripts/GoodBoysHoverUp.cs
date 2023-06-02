using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodBoysHoverUp : MonoBehaviour
{
    [SerializeField] float distanceToCover=2f;
    [SerializeField] float speed=0.01f;

    private Vector3 startPosition;
    private Vector3 v;

    void Start()
    {
        startPosition = transform.position;
        v = new Vector3(startPosition.x, startPosition.y+distanceToCover, startPosition.z);
        // v.y += distanceToCover;
    }

    void Update()
    {
        // Vector3 v = startPosition;
        // v.y += distanceToCover * Mathf.Sin(Time.time * speed);
        transform.position = Vector3.Lerp(startPosition, v, speed);
        // transform.position = v;
    }
}
