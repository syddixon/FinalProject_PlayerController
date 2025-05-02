using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
   
    private Animator animator;
   // private Coroutine closeCoroutine;

    void Start()
    {
        animator = GetComponent<Animator>();
    }
    private void OnTriggerEnter(Collider other)
    {
        animator.Play("DoorOpen");
    }
    private void OnTriggerExit(Collider other)
    {
        animator.Play("DoorClose");
    }

    //void OnTriggerEnter(Collider other)
    //{
    //    if (other.CompareTag("Player"))
    //    {
    //        animator.SetTrigger("Open");

    //        // If door was about to close, cancel that
    //        if (closeCoroutine != null)
    //        {
    //            StopCoroutine(closeCoroutine);
    //            closeCoroutine = null;
    //        }
    //    }
    //}

    //void OnTriggerExit(Collider other)
    //{
    //    if (other.CompareTag("Player"))
    //    {
    //        // Wait before closing to give the player time to walk through
    //        closeCoroutine = StartCoroutine(CloseAfterDelay());
    //    }
    //}

    //IEnumerator CloseAfterDelay()
    //{
    //    yield return new WaitForSeconds(2f);  // Adjust delay as needed
    //    animator.SetTrigger("Close");
    //    closeCoroutine = null;
    //}
}
