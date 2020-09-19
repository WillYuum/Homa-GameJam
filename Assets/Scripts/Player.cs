using System;
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

    public float playerMoveSpeed = 1f;

    void Start()
    {
        currentAmountHealth = startingAmountHealth;
        currentAmountOfBullets = startingAmountOfbullets;    
    }


    void Update()
    {

    }

    private float minPos = -0.9f;
    private float maxPos = 1f;

   public void HandleMovePlayer(Vector3 direction)
    {
        transform.Translate(direction * playerMoveSpeed * Time.deltaTime);
        Vector3 clampedPosition = transform.position;
        // Now we can manipulte it to clamp the y element
        clampedPosition.x = Mathf.Clamp(clampedPosition.x, minPos, maxPos);
        // re-assigning the transform's position will clamp it
        transform.position = clampedPosition;
    }

    public Button button;
    public void HandlePlayerShoot()
    {
        
    }
}
