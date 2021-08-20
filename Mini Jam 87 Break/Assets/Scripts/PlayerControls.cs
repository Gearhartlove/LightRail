using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControls : MonoBehaviour
{
    public float moveSpeed = 10f;
    public string direction;
    public Transform movePoint;


    public PlayerMovement pMovement;

    private void Start()
    {
        movePoint.parent = null;
        pMovement = new PlayerMovement();
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, movePoint.position, moveSpeed * Time.deltaTime);
        if (Vector3.Distance(transform.position, movePoint.transform.position) <= 1f)
        {
            Debug.Log("Assign: " + direction + " " + Time.deltaTime);
            switch (direction)
            {
                case "North":
                    movePoint.position += new Vector3(0f, pMovement.GetMovementSquares, 0f);
                    break;
                case "South":
                    movePoint.position += new Vector3(0f, -pMovement.GetMovementSquares, 0f);
                    break;
                case "West":
                    movePoint.position += new Vector3(-pMovement.GetMovementSquares, 0f, 0f);
                    break;
                case "East":
                    movePoint.position += new Vector3(pMovement.GetMovementSquares, 0f, 0f);
                    break;
            }
        }
    }

    public void OnNorth()
    {
        pMovement.SnapNS();
        direction = "North";
        movePoint.position += new Vector3(0f, pMovement.GetMovementSquares, 0f);
    }       
            
    public void OnSouth()
    {
        pMovement.SnapNS();
        direction = "South";
        movePoint.position += new Vector3(0f, -pMovement.GetMovementSquares, 0f);
    }
    public void OnWest()
    {
        pMovement.SnapWE();
        direction = "West";
        movePoint.position += new Vector3(-pMovement.GetMovementSquares, 0f, 0f);
    }
    public void OnEast()
    {
        pMovement.SnapWE();
        direction = "East";
        movePoint.position += new Vector3(pMovement.GetMovementSquares, 0f, 0f);
    }
}
