using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMoveBadBoy : MonoBehaviour
{
    //public GameObject Targets[];
    public float movementSpeed = 0.01f;
    public float threshold = 2f;
    private Vector3[] Targets;
    
    void Start()
    {
        Targets = new [] { new Vector3(Random.Range(-5,5), 0, Random.Range(-5,5)), new Vector3(Random.Range(-5, 5), 0, Random.Range(-5, 5)), new Vector3(Random.Range(-5, 5), 0, Random.Range(-5, 5)) };
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, Targets[0], movementSpeed);

        if (Vector3.Distance(transform.position, Targets[0]) <= threshold)
        {
            transform.position = Vector3.Lerp(transform.position, Targets[1], movementSpeed);
        }

        if (Vector3.Distance(transform.position, Targets[1]) <= threshold)
        {
            transform.position = Vector3.Lerp(transform.position, Targets[2], movementSpeed);
        }

        /*Vector3 target = Targets[0];
        int i = 0;
        bool reached = true;*/
        /*while(i<3)
        {
            if(i==Targets.Length)
            {
                i = 0;
            }
            if( reached )
            {
                reached = false;
                transform.position = Vector3.Lerp(transform.position, target, movementSpeed);
                transform.LookAt(target);
            }
            if(Vector3.Distance(transform.position, target) <= threshold)
            {
                reached = true;
                i++;
                target = Targets[i];
            }
        }*/
    }
}
