using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControls : MonoBehaviour
{
    public float speed = 0f; //look at editor for exact value
    public string direction;

    public PlayerMovement pMovement;

    private void Update()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, pMovement.movePoint.position, speed);
        if (Vector3.Distance(transform.position, pMovement.movePoint.transform.position) <= 1f)
        {
            switch (direction)
            {
                case "North":
                    pMovement.movePoint.position += new Vector3(0f, pMovement.GetMovementSquares, 0f);
                    break;
                case "South":
                    pMovement.movePoint.position += new Vector3(0f, -pMovement.GetMovementSquares, 0f);
                    break;
                case "West":
                    pMovement.movePoint.position += new Vector3(-pMovement.GetMovementSquares, 0f, 0f);
                    break;
                case "East":
                    pMovement.movePoint.position += new Vector3(pMovement.GetMovementSquares, 0f, 0f);
                    break;
            }
        }
    }

    public void OnNorth()
    {
        if (direction != "North")
        {
            pMovement.Snap();
            direction = "North";
            pMovement.movePoint.position = transform.position;
            pMovement.movePoint.position += new Vector3(0f, pMovement.GetMovementSquares, 0f);
        }
    }

    public void OnSouth()
    {
        if (direction != "South")
        {
            pMovement.Snap();
            direction = "South";
            pMovement.movePoint.position = transform.position;
            pMovement.movePoint.position += new Vector3(0f, -pMovement.GetMovementSquares, 0f);
        }
    }
    public void OnWest()
    {
        if (direction != "West")
        {
            pMovement.Snap();
            direction = "West";
            pMovement.movePoint.position = transform.position;
            pMovement.movePoint.position += new Vector3(-pMovement.GetMovementSquares, 0f, 0f);
        }
    }
    public void OnEast()
    {
        //if (direction != "East")
        {
            pMovement.Snap();
            direction = "East";
            pMovement.movePoint.position = transform.position;
            pMovement.movePoint.position += new Vector3(pMovement.GetMovementSquares, 0f, 0f);
        }
    }
}
