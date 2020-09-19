using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int startingAmountHealth = 3;
    private int currentAmountHealth;

    public int startingAmountOfbullets = 6;
    private int currentAmountOfBullets;

    private float currentPlayerSpeed = 1.0f;


    void Start()
    {
        currentAmountHealth = startingAmountHealth;
        currentAmountOfBullets = startingAmountOfbullets;    
    }


    void Update()
    {
        
    }
}
