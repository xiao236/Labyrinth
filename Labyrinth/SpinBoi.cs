using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinBoi : MonoBehaviour
{
    public int direction; // direction 1 = up, 2=right, 3=down, 4 = left
    GameObject portal1;
    GameObject portal2;
    public Collider2D hurtbox;
    // Start is called before the first frame update
    void Start()
    {

    }
    private void OnTriggerEnter2D(Collider2D hurtbox)
    {
        if (hurtbox.name == "hurtbox")
        {
            switch (direction)
            {
                case 1:
                    GameObject.Find("player").GetComponent<MovementV>().player.velocity = new Vector2(0, 5);
                    GameObject.Find("player").GetComponent<MovementV>().player.transform.eulerAngles = new Vector3(0, 0, 0);
                    break;
                case 2:
                    GameObject.Find("player").GetComponent<MovementV>().player.velocity = new Vector2(5, 0);
                    GameObject.Find("player").GetComponent<MovementV>().player.transform.eulerAngles = new Vector3(0, 0, 270);
                    break;
                case 3:
                    GameObject.Find("player").GetComponent<MovementV>().player.velocity = new Vector2(0, -5);
                    GameObject.Find("player").GetComponent<MovementV>().player.transform.eulerAngles = new Vector3(0, 0, 180);
                    break;
                default:
                    GameObject.Find("player").GetComponent<MovementV>().player.velocity = new Vector2(-5, 0);
                    GameObject.Find("player").GetComponent<MovementV>().player.transform.eulerAngles = new Vector3(0, 0, 90);
                    break;
            }
        }
    }
}