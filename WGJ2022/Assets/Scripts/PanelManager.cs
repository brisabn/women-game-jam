using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PanelManager : MonoBehaviour
{
    private bool pickUpAllowed;
    public GameObject Panel1;
    public GameObject Panel2;

    private void Start()
    {
        Panel1.gameObject.SetActive(false);
        Panel2.gameObject.SetActive(false);
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
        Panel1.gameObject.SetActive(true);
        Panel2.gameObject.SetActive(false);
    }
    private void PickUp()
    {
        ShowHiddenPanel();
        
    }
}
