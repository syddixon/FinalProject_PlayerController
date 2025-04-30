using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeapon : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        // Try to call "Stun()" if the object has that method
        other.SendMessage("Stun", SendMessageOptions.DontRequireReceiver);
    }
}


