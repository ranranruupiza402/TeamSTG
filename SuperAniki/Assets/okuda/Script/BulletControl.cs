using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletControl : MonoBehaviour
{
    public float speed = 9.0f;

    Vector3 movement;
    Renderer ren;
    bool check = false;

    // Start is called before the first frame update
    void Start()
    {
        ren = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        movement.Set(1, 0, 0);
        movement = movement.normalized * speed * Time.deltaTime;
        transform.position = transform.position + movement;

        if(!check && ren.isVisible)
        {
            check = true;
        }
        if(check && !ren.isVisible)
        {
            Destroy(gameObject);
        }
    }
}
