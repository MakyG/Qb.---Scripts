using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;
    float smoothSpeed = 0.125f;
    public Vector3 offset;
    public Vector3 lastPosition;

    private void FixedUpdate()
    {
        if (target == null)
        {
            transform.position = lastPosition;

        }

        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;
        lastPosition = smoothedPosition;
    }

}
