using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePrefab : MonoBehaviour
{
    private void Awake()
    {
        transform.position = new Vector3(transform.position.x, -1, transform.position.z);
        transform.Rotate(new Vector3(90,90,0));
    }
}
