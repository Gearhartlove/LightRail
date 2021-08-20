using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float movementSquares = 2f;
    public float GetMovementSquares => movementSquares;
    Vector3 snapVector;
    public Transform movePoint;

    private void Start()
    {
        snapVector = new Vector3();
        movePoint.parent = null;
    }
    public bool CheckDistance()
    {
        //if (Vector3.Distance(transform.position, movePoint.transform.position)
        //  <= 0.05f) return true;
        //else return false;
        return true;
    }

    /// <summary>
    /// Snaps Player to grid tile which they are closest to.
    /// Assumption : every grid unity is 1x1; think of a square like a point
    /// Note: will always be on an integer half the time (moving left/right or)
    ///     north/south
    /// </summary>
    public void Snap()
    {
        snapVector = RoundVector3(transform.position);
        Debug.Log("Snap: " + snapVector);
        transform.position = snapVector;
    }

    private Vector3 RoundVector3(Vector3 v3)
    {
        Vector3 newVector = new Vector3
        {
            x = Mathf.Round(v3.x),
            y = Mathf.Round(v3.y),
            z = Mathf.Round(v3.z)
        };

        return newVector;
    }


}
