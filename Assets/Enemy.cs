using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour

{
    [SerializeField] Transform player;
    public float moveSpeed = 3f;
    private Animator anim;
    [SerializeField] GameObject weapon;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        // Face and move toward the player
        transform.LookAt(player);
        anim.Play("EnemyWalk");

       
    }

    private void OnTriggerEnter(Collider other)
    {
        //if (other.CompareTag("Weapon"))
        //{
        //    anim.SetTrigger("Fall");
        //   // Destroy(gameObject);
        //}
    }

}