using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Void : MonoBehaviour
{
    private bool PlayerDeath = false;
    public bool GetPlayerDeath => PlayerDeath;

    private void OnTriggerExit2D(Collider2D collision)
    {
        PlayerDeath = true;
    }
}
