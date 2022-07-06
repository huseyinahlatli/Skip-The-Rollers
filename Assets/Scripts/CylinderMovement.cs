using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderMovement : MonoBehaviour
{
    [SerializeField] private Material[] material = new Material[8];
    private float[] randomUpDownSpeed = new float[] {0.25f, 0.4f, 0.55f, 0.7f, 0.8f, 0.9f};
    private float[] randomRightLeftSpeed = new float[] {0.3f, 0.4f, 0.5f, 0.6f, 0.7f, 0.8f};
    private int indexMaterial;
    private int indexUD;
    private int indexRL;
    private int moveState;
    
    private void Awake()
    {
        indexMaterial = Random.Range(0, 8);
        this.GetComponent<MeshRenderer>().material = material[indexMaterial];
        moveState = Random.Range(1, 5);
        indexUD = Random.Range(0, 6);
        indexRL = Random.Range(0, 6);
    }
    
    private void FixedUpdate()
    {   
        if(moveState == 1)
            UpMovement();

        if(moveState == 2)
            DownMovement();
        
        if(moveState == 3)
            RightMovement();

        if(moveState == 4)
            LeftMovement();
    }

    private void UpMovement()
    {
        if(transform.position.y < 0.5f)
            transform.Translate(Vector3.up * randomUpDownSpeed[indexUD] * Time.deltaTime);
        else
            moveState = 2;
    }
    
    private void DownMovement()
    {
        if(transform.position.y > -2f)
            transform.Translate(Vector3.down * randomUpDownSpeed[indexUD] * Time.deltaTime);
        else
            moveState = 1;
    }

    private void RightMovement()
    {
        if(transform.position.x < 2.5f)
            transform.Translate(Vector3.right * randomRightLeftSpeed[indexRL] * Time.deltaTime);
        else
            moveState = 4;
    }

    private void LeftMovement()
    {
        if(transform.position.x > -2.5f)
            transform.Translate((-1) * Vector3.right * randomRightLeftSpeed[indexRL] * Time.deltaTime);
        else
            moveState = 3;
    }
}
