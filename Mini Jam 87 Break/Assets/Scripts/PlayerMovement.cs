using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float movementSquares = 2f;
    public float GetMovementSquares => movementSquares;


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
    public void SnapNS()
    {
        //get X and Y, round up / down depending if above or
        //  below .5 of the number
        float position = transform.position.y;
        
    }

    /// <summary>
    /// Read SnapNS.
    /// </summary>
    public void SnapWE()
    {
        float position = transform.position.x;

    }


}
