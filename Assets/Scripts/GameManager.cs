using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public static GameManager instance = null;

    [HideInInspector] public bool gameIsOn = false;


    public Player player;




    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (instance != null)
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
       
    }

    public void StartGame()
    {
        gameIsOn = true;
    }

    public void WinGame()
    {

    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void LoseGame()
    {
        gameIsOn = false;
    }

    public void ExitGame()
    {
        Application.Quit();
    }


    public void OnClickLeftToggleButton()
    {
        player.HandleMovePlayer();
    }


    private void OnClickRightToggleButton()
    {

    }

    private void onClickShootButton()
    {

    }

}