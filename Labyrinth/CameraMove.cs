using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public Camera main;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("player").GetComponent<MovementV>().player.transform.position.x > 0)
        {
            main.transform.position = new Vector3(GameObject.Find("player").GetComponent<MovementV>().player.transform.position.x, 0, -10);
        }
        else
        {
            main.transform.position = new Vector3(0, 0, -10);  
        }
    }
}