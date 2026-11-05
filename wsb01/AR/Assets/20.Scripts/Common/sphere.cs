using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.XR.ARFoundation;

public class sphere : MonoBehaviour
{
    public GameObject spherePrefab;
    public ARRaycastManager raycastManager;
    public Transform parentTransform;
    public Camera arCamera;

    // Update is called once per frame
    void Update()
    {
        if(EventSystem.current.currentSelectedGameObject) return;
        var touchScreen = Touchscreen.current;
        if (touchScreen == null) return;
        if (!touchScreen.primaryTouch.press.wasPressedThisFrame) return;

        Vector2 screenPos = touchScreen.primaryTouch.position.ReadValue();

        Vector3 worldpos = arCamera.ScreenToWorldPoint(
            new Vector3(screenPos.x, screenPos.y, 0.5f));

        GameObject go = Instantiate(spherePrefab, worldpos, Quaternion.identity);
        go.transform.parent = parentTransform;
    }
}