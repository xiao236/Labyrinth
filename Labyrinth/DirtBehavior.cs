﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirtBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "hurtbox")
        {
            GameObject.Find("player").GetComponent<MovementV>().player.velocity = new Vector3 (0, 0, 0);
        }
    }
}
