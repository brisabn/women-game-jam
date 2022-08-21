using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ObjectManager : MonoBehaviour
{
    private bool pickUpAllowed;
    public GameObject Object;

    private void Start()
    {
        Object.gameObject.SetActive(false);
    }

    void Update()
    {
        if (pickUpAllowed && Input.GetKeyDown(KeyCode.E))
        {
            ShowHiddenObject();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            pickUpAllowed = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            pickUpAllowed = false;
        }
    }

    public void ShowHiddenObject()
    {
        Object.gameObject.SetActive(true);
    }

    public void CloseHiddenObject()
    {
        Object.gameObject.SetActive(false);
    }

}
