using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nextzone : MonoBehaviour
{

    [SerializeField] private GM gm;

    private void OnMouseOver()
    {
        /*
            Change mouse cursor to a different one here
        */
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            gm.LoadNextScene();
        }
    }
}
