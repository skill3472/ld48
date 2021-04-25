using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nextzone : MonoBehaviour
{

    [SerializeField] private GM gm;

    private void OnMouseEnter()
    {
        gm.ChangeCursor(1);
    }
    private void OnMouseExit()
    {
        gm.ChangeCursor(0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            gm.LoadNextScene();
        }
    }
}
