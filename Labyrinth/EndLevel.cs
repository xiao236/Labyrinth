using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLevel : MonoBehaviour
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
        if(other.gameObject.name == "player")
        {
            if (GameObject.Find("LevelChanger").GetComponent<LevelChanger>().currentLevel == 6)
            {
                GameObject.Find("LevelChanger").GetComponent<LevelChanger>().FadeToLevel(0);
            }
            else
            {
                GameObject.Find("LevelChanger").GetComponent<LevelChanger>().FadeToLevel(GameObject.Find("LevelChanger").GetComponent<LevelChanger>().currentLevel);
            }
        }
    }
}
