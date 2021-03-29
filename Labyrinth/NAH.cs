using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NAH : MonoBehaviour
{
    public GameObject targetA;
    public GameObject targetB;
    public GameObject targetC;
    public GameObject targetD;
    public GameObject currentButton;
    void Awake()
    {
        targetA.SetActive(false);
        targetB.SetActive(false);
        targetC.SetActive(false);
        targetD.SetActive(false);
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
            targetD.SetActive(true);
            currentButton.SetActive(false);
        }
    }
}
