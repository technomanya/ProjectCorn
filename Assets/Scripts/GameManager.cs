using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{

    public GameObject LosePanel;
    public Player playerControl;

    private void Start()
    {
        playerControl = GameObject.FindWithTag("Player").GetComponent<Player>();
        playerControl.isControl = true;
    }

    public void  RestartGame()
    {
        var activeScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(activeScene.buildIndex);
    }

    public void GameOver(bool win)
    {
        if (win)
        {
            
        }
        else
        {
            playerControl.isControl = false;
            LosePanel.SetActive(true);
        }
    }

}
