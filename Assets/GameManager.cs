using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static bool hasKey = false;

    public static void EndGame()
    {
        // Do win sequence or restart
        Debug.Log("Game Won!");
        // You could show UI, reload, etc.
        // SceneManager.LoadScene("WinScene");
    }

    void Start()
    {
        hasKey = false; // reset each time
    }
}
