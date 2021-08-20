using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControls : MonoBehaviour
{
    public float moveSpeed = 10f;
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
    }

    public void OnNorth()
    {
        pMovement.Snap();
        movePoint.position += new Vector3(0f, pMovement.GetMovementSquares, 0f);
    }       
            
    public void OnSouth()
    {
        pMovement.Snap();
        movePoint.position += new Vector3(0f, -pMovement.GetMovementSquares, 0f);
    }
    public void OnWest()
    {
        pMovement.Snap();
        movePoint.position += new Vector3(-pMovement.GetMovementSquares, 0f, 0f);
    }
    public void OnEast()
    {
        pMovement.Snap();
        movePoint.position += new Vector3(pMovement.GetMovementSquares, 0f, 0f);
    }
}
