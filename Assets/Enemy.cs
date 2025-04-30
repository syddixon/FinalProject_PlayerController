using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour

{
    [SerializeField] Transform player;
    public float moveSpeed = 3f;
    public float stunTime = 3f;

    private Animator anim;
    private bool isStunned = false;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (isStunned || player == null) return;

        // Face and move toward the player
        transform.LookAt(player);
        anim.SetTrigger("EnemyWalk");
    }

    public void Stun()
    {
        if (!isStunned)
        {
            StartCoroutine(StunRoutine());
        }
    }

    private IEnumerator StunRoutine()
    {
        isStunned = true;

        // Play stunned animation
        if (anim != null) anim.SetTrigger("Fall");

        // Wait
        yield return new WaitForSeconds(stunTime);

        // Play recovery animation
        if (anim != null) anim.SetTrigger("GetUp");

        isStunned = false;
    }

    void OnTriggerEnter(Collider other)
    {
        // You can tag your weapon as "Weapon" to make this more specific
        if (other.CompareTag("Weapon"))
        {
            Stun();
        }
    }
}




