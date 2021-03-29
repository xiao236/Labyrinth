using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementV : MonoBehaviour
{
    public Rigidbody2D player;
    public bool moving = false;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("down") && !moving)
        {
            player.velocity = new Vector2(0, -5f);
            player.transform.eulerAngles = new Vector3(0, 0, 180);

        }
        if (Input.GetButtonDown("up") && !moving)
        {
            player.velocity = new Vector2(0, 5f);
            player.transform.eulerAngles = new Vector3(0, 0, 0);
        }
        if (Input.GetButtonDown("left") && !moving)
        {
            player.velocity = new Vector2(-5f, 0);
            player.transform.eulerAngles = new Vector3(0, 0, 90);
        }
        if (Input.GetButtonDown("right") && !moving)
        {
            player.velocity = new Vector2(5f, 0);
            player.transform.eulerAngles = new Vector3(0, 0, 270);
        }
        if (player.velocity == new Vector2(0, 0))
        {
            moving = false;
        }
        else
        {
            moving = true;
        }

        if (!((player.transform.position.x) % 0.5 == 0) || !((player.transform.position.y) % 0.5 == 0))
        {
            if (!moving) {
                player.transform.position = new Vector3(round(player.transform.position.x), round(player.transform.position.y), -2);
             }
        }
        
    }
    float round(float x)
    {
        x = x * 2;
        if (x < 0)
        {
            x = x - .5f;
        }
        if (x > 0)
        {
            x = x + .5f;
        }
        x = (int)x;
        x = (float)x;
        x = x / 2f;
        return x;
    }
}