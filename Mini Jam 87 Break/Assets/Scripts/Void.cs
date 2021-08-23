using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Void : MonoBehaviour
{
    private bool PlayerDeath = false;
    public bool GetPlayerDeath => PlayerDeath;

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Player Death" + Time.time);
        PlayerDeath = true;
    }
}
