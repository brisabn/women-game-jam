using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ButtonManager : MonoBehaviour
{
    private bool pickUpAllowed;
    public GameObject Button;

    private void Start()
    {
        Button.gameObject.SetActive(false);
    }
    void Update()
    {
        if (pickUpAllowed && Input.GetKeyDown(KeyCode.E))
            PickUp();
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
    public void ShowHiddenButton()
    {
        Button.gameObject.SetActive(true);
    }
    private void PickUp()
    {
        ShowHiddenButton();

    }
}
