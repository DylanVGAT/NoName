using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float smoothing = 0.125f;

    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        if (target == null)
        {
            Debug.LogError("CameraFollow : Aucune target assigne");
            enabled = false;
            return;
        }
        offset = transform.position - target.position;
    }

    void LateUpdate()
    {
        Vector3 targetCamPos = target.position + offset;
        targetCamPos.z = transform.position.z;

        transform.position = Vector3.Lerp(transform.position, targetCamPos, smoothing);
    }
}
