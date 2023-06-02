using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

[RequireComponent(typeof(ARPlaneManager))]

public class AutoPlacementOfObjectsInPlane : MonoBehaviour
{
    [SerializeField]
    private GameObject placedPrefab;

    private GameObject placedObject;
    private GameObject placedObject1;

    [SerializeField]
    private ARPlaneManager arPlaneManager;

    void Awake()
    {
        arPlaneManager = GetComponent<ARPlaneManager>();
        arPlaneManager.planesChanged += PlaneChanged;
    }

    private void PlaneChanged(ARPlanesChangedEventArgs args)
    {
        if(args.added != null && placedObject == null && placedObject1 == null)
        {
            ARPlane arPlane = args.added[0];
            placedObject = Instantiate(placedPrefab, arPlane.transform.position, Quaternion.identity);
            placedObject1 = Instantiate(placedPrefab, arPlane.transform.position, Quaternion.identity);
        }
    }
}
