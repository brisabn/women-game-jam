using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PanelManager : MonoBehaviour
{
    public bool pickUpAllowed;
    public GameObject Panel;

    private void Start()
    {
        Panel.gameObject.SetActive(false);
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
    
    public void ShowHiddenPanel()
    {
        Panel.gameObject.SetActive(true);
    }

    private void PickUp()
    {
        ShowHiddenPanel();
    }
}
