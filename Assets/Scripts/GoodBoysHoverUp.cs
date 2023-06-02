using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodBoysHoverUp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = Vector3.Lerp(transform.position, new Vector3(Random.Range(-5,5), 0, Random.Range(-5,5)), 0.005f);
    }
}
