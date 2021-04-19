using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camControll : MonoBehaviour
{
    
    public Transform player;
    private double y = 4.5f;

    void Update()
    {
        // Camera follows the player with specified offset position
        transform.position = new Vector3(player.position.x  , (float)(player.position.y + y), -15);
    }
}
