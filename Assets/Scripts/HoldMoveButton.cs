using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public enum Directions
{
    left,
    right
}

public class HoldMoveButton : MonoBehaviour
{

    public Directions selectedDirection;
    private Vector3 directionToMove;
    private bool isHoldingButton = false;

    void Start()
    {
        if(selectedDirection == Directions.left)
        {
            directionToMove = Vector3.left;
        }
        else
        {
            directionToMove = Vector3.right;
        }
    }

    void Update()
    {
        if (isHoldingButton)
        {
            GameManager.instance.player.HandleMovePlayer(directionToMove);
        }
    }

    public void OnClick()
    {
        isHoldingButton = true;
    }

    public void OnRelease()
    {
        isHoldingButton = false;
    }


}
