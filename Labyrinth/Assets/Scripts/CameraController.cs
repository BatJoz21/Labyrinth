using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] Camera cam;

    float frustrumScale;

    private void Start()
    {
        var camDistance = cam.transform.position.y;
        var frustrumHeight = 2 * camDistance * Mathf.Tan(cam.fieldOfView * 0.5f * Mathf.Deg2Rad);
        frustrumScale = frustrumHeight / Screen.height;
    }

    void Update()
    {
        var touches = Input.touches;

        switch (touches.Length)
        {
            case 1:
                Drag(touches);
                break;
            case >= 2:
                //Zoom(touches);
                break;
        }
    }

    private void Drag(Touch[] touches)
    {
        var touch = Input.GetTouch(0);

        cam.transform.position -= new Vector3(touch.deltaPosition.x, 0, touch.deltaPosition.y) * frustrumScale;
    }
}
