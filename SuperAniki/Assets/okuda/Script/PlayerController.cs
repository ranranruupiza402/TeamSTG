using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 6f;
    Vector3 movement;
    Rigidbody playerRigidbody;

    private void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        Move(h, v);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Move(float h, float v)
    {
        movement.Set(h, v, 0);
        movement = movement.normalized * speed * Time.deltaTime;
        transform.position = transform.position + movement;
    }
}
