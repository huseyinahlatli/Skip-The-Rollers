using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCube : MonoBehaviour
{
    [SerializeField] private Vector3 rotateVector = new Vector3(0, 0, 0);
    [SerializeField] private float speed;
    void FixedUpdate()
    {
        transform.Rotate(rotateVector * speed * Time.fixedDeltaTime);
    }
}
