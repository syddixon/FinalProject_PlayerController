using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockedDoor : MonoBehaviour
{
    private Animator animator;
    private bool isOpen = false;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (isOpen) return;

        if (other.CompareTag("Player"))
        {
            PlayerInventory inventory = other.GetComponent<PlayerInventory>();

            if (inventory != null && inventory.hasKey)
            {
                UnlockDoor();
            }
            else
            {
                Debug.Log("The door is locked. Find the key.");
            }
        }
    }

    void UnlockDoor()
    {
        isOpen = true;

        animator.SetTrigger("Open");

        Collider doorCollider = GetComponent<Collider>();
        if (doorCollider != null && !doorCollider.isTrigger)
        {
            doorCollider.enabled = false;
        }

        Debug.Log("Door unlocked!");
    }
}
