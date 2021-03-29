using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MenuButtons : MonoBehaviour
{
    public GameObject target;
    void Start()
    {
        target.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetMouseButtonDown(0))
        {
            target.SetActive(false);
        }   
    }

    public void startClick()
    {
        GameObject.Find("LevelChanger").GetComponent<LevelChanger>().FadeToLevel(1);
    }
    public void exitClick()
    {
        Application.Quit();
    }
    public void creditsClick()  
    {
        target.SetActive(true);
    }
}
