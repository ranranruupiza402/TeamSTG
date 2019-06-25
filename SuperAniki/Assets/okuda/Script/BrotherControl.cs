using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrotherControl : MonoBehaviour
{
    public bool isLeft;
    public Transform target = null; //追随対象
    public float speed = 5;
    public float delay = 0.5f;
    public Vector3 left = new Vector3(-1, 1.5f, 0);
    public Vector3 right = new Vector3(-1, -1.5f, 0);

    Vector3 velocity;
    Vector3 goal;

    // Update is called once per frame
    void Update()
    {
        if(isLeft)
        {
            goal = target.position - left - transform.position;
        }
        else
        {
            goal = target.position - right - transform.position;
        }
        velocity += goal * speed;
        velocity *= delay;
        transform.position += velocity *= Time.deltaTime;
    }
}
