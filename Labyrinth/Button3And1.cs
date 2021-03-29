using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button3And1 : MonoBehaviour
{
    public GameObject targetA;
    public GameObject targetB;
    public GameObject targetC;

    public GameObject currentButton;
    public GameObject target1;
    void Start()
    {
        targetA.SetActive(false);
        targetB.SetActive(false);
        targetC.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "hurtbox")
        {
            targetA.SetActive(true);
            targetB.SetActive(true);
            targetC.SetActive(true);
            currentButton.SetActive(false);
            target1.SetActive(false);
        }
    }
}