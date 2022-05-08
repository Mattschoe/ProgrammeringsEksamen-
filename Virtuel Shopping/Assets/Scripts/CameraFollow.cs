using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//F�r det kamera brugeren ser ud fra til at f�lge spilleren i programmet
public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    void LateUpdate()
    {
        transform.position = target.position + offset;
    }
}
