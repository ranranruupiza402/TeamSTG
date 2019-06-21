using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public int damagePerShot = 20;
    public float timeBetweenBullets = 0.15f;
    public float range = 100f;
    public GameObject bullet;

    float timer;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if(Input.GetKey(KeyCode.Z) && timer >= timeBetweenBullets && Time.timeScale != 0)
        {
            Shot();
        }
    }

    void Shot()
    {
        timer = 0f;

        Instantiate(bullet, new Vector3(transform.position.x, transform.position.y, 0), Quaternion.identity);
    }
}
