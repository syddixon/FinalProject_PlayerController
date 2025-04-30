using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float Speed = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Speed * Time.deltaTime * Input.GetAxis("Horizontal");
        float z = Speed * Time.deltaTime * Input.GetAxis("Vertical");

        transform.Translate(x * Vector3.right + z * Vector3.forward);
    }
}
