using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform target;
    private Vector3 offset;

    void Start()
    {
        offset = transform.position - target.position;    
    }

    void LateUpdate()
    {
        transform.position = new Vector3(target.position.x + offset.x,
                                         target.position.y + offset.y,
                                         target.position.z + offset.z);
    }
}
