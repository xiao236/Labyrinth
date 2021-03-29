using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeathBox : MonoBehaviour
{
    public Collider2D hurtbox; //hurtbox under player
    public Vector3 spawn;
    public int t = 200;
    public bool die;

    public float scaler = 1;
    public float scalerA = 360;

    public float timeGiven;
    public float lastTime;
    public int timeLeft;
    public Text clock;
    // Start is called before the first frame update
    void Start()
    {
        spawn = GameObject.Find("player").GetComponent<MovementV>().player.transform.position;
        lastTime = Time.time;
    }
    private void OnTriggerEnter2D(Collider2D hurtbox)
    {
        if (hurtbox.name == "hurtbox")
        {
            GameObject.Find("player").GetComponent<MovementV>().player.velocity = new Vector2(0, 0);
            die = true;
        }
    }
    private void Update()
    {
        timer();
        if (die)
        {
            t--;
            GameObject.Find("player").GetComponent<MovementV>().player.transform.localScale = new Vector2(scaler, scaler);
            scaler = scaler * .99f;
            GameObject.Find("player").GetComponent<MovementV>().player.transform.eulerAngles = new Vector3(0, 0, scalerA);
            scalerA = scalerA * .99f;
            if (t < 1)
            {
                GameObject.Find("player").GetComponent<MovementV>().player.transform.position = spawn;
                GameObject.Find("player").GetComponent<MovementV>().player.velocity = new Vector2(0, 0);
                GameObject.Find("player").GetComponent<MovementV>().player.transform.eulerAngles = new Vector3(0, 0, 0);
                GameObject.Find("player").GetComponent<MovementV>().player.transform.localScale = new Vector2(.8f, .8f);
                t = 300;
                die = false;
                scaler = 1;
                lastTime = Time.time;
                GameObject.Find("Main Camera").GetComponent<CameraMove>().main.transform.position = new Vector3(0, 0, -10);

            }
            GameObject.Find("LevelChanger").GetComponent<LevelChanger>().FadeToLevel(GameObject.Find("LevelChanger").GetComponent<LevelChanger>().currentLevel-1);

        }
        if (Input.GetButtonDown("f"))
        {
            GetComponent<DeathBox>().die = true;
        }
    }
    void timer()
    {
        float timePassed = Time.time - lastTime;
        if (timePassed > timeGiven)
        {
            die = true;
        }
        timeLeft = (int)timeGiven - (int)timePassed;
        clock.GetComponent<UnityEngine.UI.Text>().text = timeLeft.ToString();
    }
}