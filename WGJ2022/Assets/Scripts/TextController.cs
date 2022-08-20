using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour
{
    [Header("Texto")]
    [SerializeField] private TextMeshProUGUI Texto;
    [SerializeField] public string Mensagem;
    private bool portaAllowed;

    private void AlteraTexto()
    {
        Texto.text = Mensagem;
    }
    void Update()
    {
        if (portaAllowed && Input.GetKeyDown(KeyCode.E))
            PickUp();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            portaAllowed = true;

        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {

            portaAllowed = false;
        }
    }
    private void PickUp()
    {
        AlteraTexto();

    }
}
