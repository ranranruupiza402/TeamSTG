using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restriction : MonoBehaviour
{
    
    GameObject Player;
    GameObject wall_Left;
    GameObject wall_Right;
    GameObject wall_Top;
    GameObject wall_Bottom;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("player");
        wall_Left = GameObject.Find("LeftWall");
         wall_Right = GameObject.Find("RightWall");
         wall_Top = GameObject.Find("TopWall");
         wall_Bottom = GameObject.Find("BottomWall");
    }

    // Update is called once per frame
    void Update()
    {
        Player.transform.position = (new Vector3(Mathf.Clamp(Player.transform.position.x, wall_Left.transform.position.x, wall_Right.transform.position.x),
            Mathf.Clamp(Player.transform.position.y, wall_Bottom.transform.position.y, wall_Top.transform.position.y), Player.transform.position.z));
    }
}
