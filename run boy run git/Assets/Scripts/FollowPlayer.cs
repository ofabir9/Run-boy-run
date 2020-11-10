﻿using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Start is called before the first frame update


    // Update is called once per frame

    public Transform player;
    public Vector3 offset;
    
    void Update()
    {
        transform.position = player.position + offset;
    }
}
