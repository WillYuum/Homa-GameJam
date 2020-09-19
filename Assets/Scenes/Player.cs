using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private int startingAmountHealth = 3;
    private int currentAmountHealth;

    public int startingAmountOfbullets = 6;
    private int currentAmountOfBullets;

    private float playerMoveSpeed = 1.0f;

    void Start()
    {
        currentAmountHealth = startingAmountHealth;
        currentAmountOfBullets = startingAmountOfbullets;    
    }


    void Update()
    {
        
    }


   public void HandleMovePlayer()
    {
        //if(direction)
        //var x = new GameObject().GetComponent<Button>();
        print("Hello world");
        //Input.GetButtonD

    }

    public Button button;
    public void HandlePlayerShoot()
    {
        
    }
}
