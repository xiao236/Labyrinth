using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    public Rigidbody2D ball;
    public Collider2D hurtbox;
    public int direction;
    Vector3 startPlace;
    public float timer;
    // Start is called before the first frame update
    void Start()
    {
        ball = GetComponent<Rigidbody2D>();
        startPlace = ball.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if ((int)Time.time % (int)timer == 0)
        {
            ball.transform.position = startPlace;
        }
        switch (direction)
        {
            case 1:
                {
                    ball.velocity = new Vector3(0, 3, 0);
                    break;
                }
            case 2:
                {
                    ball.velocity = new Vector3(3, 0, 0);
                    break;
                }
            case 3:
                {
                    ball.velocity = new Vector3(0, -3, 0);
                    break;
                }
            default:
                {
                    ball.velocity = new Vector3(-3, 0, 0);
                    break;
                }
        }
    }
    private void OnTriggerEnter2D(Collider2D hurtbox)
    {
        if (hurtbox.gameObject.name == "hurtbox")
        {
            GameObject.Find("DeathBox").GetComponent<DeathBox>().die = true;
            Debug.Log("ouch");
        }

    }
}