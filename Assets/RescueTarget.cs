using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RescueTarget : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("You rescued the target! Game over!");
            GameManager.EndGame();
        }
    }
}
