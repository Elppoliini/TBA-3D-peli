using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHPCam : MonoBehaviour
{
    public Camera main_cam;

    void Update()
    {
        transform.LookAt(transform.position + main_cam.transform.rotation * Vector3.back, main_cam.transform.rotation * Vector3.up);
    }
}
