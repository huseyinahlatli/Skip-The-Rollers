using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class GameControl : MonoBehaviour
{
    [SerializeField] private GameObject restartButton;
    [SerializeField] private GameObject pauseButton;
    [SerializeField] private TextMeshProUGUI pauseText;
    [SerializeField] private TextMeshProUGUI youLostText;
    
    private bool status = false;

    public void Awake()
    {
        Time.timeScale = 1f;
    }
    public void RestartGame()
    {
        Time.timeScale = 0f;
        StartCoroutine(DelayTime());
        youLostText.text = null;
    }

    IEnumerator DelayTime()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        yield return new WaitForSeconds(0);
    }
    public void PauseGame()
    {
        if (!status)
        {
            Time.timeScale = 0f;
            status = true;
            pauseText.text = "Resume";
        }
        else
        {
            Time.timeScale = 1f;
            status = false;
            pauseText.text = "Pause";
        }
    }
}
