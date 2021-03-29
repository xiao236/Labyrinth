using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public GameObject target;
    public GameObject currentButton;
    public GameObject secondTarget;
    internal object onClick;

    void Start()
    {
        target.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "hurtbox")
        {
            target.SetActive(true);
            currentButton.SetActive(false);
            secondTarget.SetActive(false);
        }
    }
}