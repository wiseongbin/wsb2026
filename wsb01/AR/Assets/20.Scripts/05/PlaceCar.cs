using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;
using UnityEngine.XR.ARFoundation;
using

using UnityEngine.XR.ARSubsystems;

public class PlaceCar : MonoBehaviour
{
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        arRayManager = GetComponent<ARRaycastManager>();
        marker.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        DetectGround();
    }

    void DetectGround()
    {
        Vector2 screenCenter = new Vector2(Screen.width / 2, Screen.height / 2);

        List<ARRaycastHit> hits = new List<ARRaycastHit>();
        if (ARRayManager.Raycast(screenCenter, hits, TrackableType.Planes))
        {

        }
    }
}
