using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject cylinderPrefab;
    [SerializeField] private GameObject lavPrefab;
    [SerializeField] private GameObject skyDome;
    [SerializeField] private TextMeshProUGUI youLostText;
    [SerializeField] private TextMeshProUGUI scoreText;
     
    private float firstLocationForCylinder;
    private float firstLocationForLav;
    private int lavDistance = 56;
    private int scoreValue = 0;
    
    private void LateUpdate()
    {
        if (transform.position.y <= -1.5f)
        {
            Time.timeScale = 0f;
            youLostText.text = "You Lost!";
        }
    }

    private void Awake()
    {
        firstLocationForCylinder = transform.position.z;
        firstLocationForLav = transform.position.z;
    }
    private void FixedUpdate()
    {
        skyDome.transform.position = transform.position + new Vector3(0, -31, 28);
        if(transform.position.z - firstLocationForCylinder >= 3)
        {
            Instantiate(cylinderPrefab, new Vector3(0, 0, (transform.position.z + 16)), Quaternion.identity);
            firstLocationForCylinder += 3;
            scoreValue += 1;
            scoreText.text = scoreValue.ToString();
        }

        if (transform.position.z - firstLocationForLav >= 8)
        {
            Instantiate(lavPrefab, new Vector3(0, -1, (Mathf.Round(transform.position.z + lavDistance))), Quaternion.identity);
            firstLocationForLav += 8;
        }
    }
}
