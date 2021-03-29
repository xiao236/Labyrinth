using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject Target;
    public bool tp = true;
    public int t = 40;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!tp)
        {
            t--;
        }
        if (t < 1)
        {
            t = 40;
            tp = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "hurtbox" && tp)
        {
            GameObject.Find("player").GetComponent<MovementV>().player.transform.position = Target.transform.position;
            tp = false;
        }
    }
}