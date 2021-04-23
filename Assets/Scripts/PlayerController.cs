using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] private Transform target;
    [SerializeField] private bool eqVisible;
    [SerializeField] private GameObject eq;
    

    // Start is called before the first frame update
    void Start()
    {
        eqVisible = false;
        eq.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            target.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        if(eqVisible && Input.GetButtonDown("Inventory"))
        {
            eqVisible = false;
            eq.SetActive(false);
        } else if(!eqVisible && Input.GetButtonDown("Inventory"))
        {
            eqVisible = true;
            eq.SetActive(true);
        }

    }
}
