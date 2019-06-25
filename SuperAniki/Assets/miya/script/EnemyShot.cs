using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class EnemyShot : MonoBehaviour
{
    public GameObject enemybulletPrefab;
    private int timeCount = 0;
    public float enemyspeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeCount += 1;

        if (timeCount % 60 == 0)
        {
            //敵の弾の生成
            GameObject enemybullet = Instantiate(enemybulletPrefab, transform.position, Quaternion.identity) as GameObject;
            Rigidbody enemybulletRb = enemybullet.GetComponent<Rigidbody>();
            //弾の飛ばす方向を決める
            enemybulletRb.AddForce(transform.forward * enemyspeed);
            //〇秒後に弾の削除
            Destroy(enemybullet, 15.0f);

        }
    }
}
