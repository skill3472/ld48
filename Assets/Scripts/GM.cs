using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GM : MonoBehaviour
{

    [SerializeField] private GameObject cutsceneWindow;
    private bool cutsceneOn;

    // Start is called before the first frame update
    void Start()
    {
        cutsceneWindow.SetActive(true);
        cutsceneOn = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.anyKeyDown && cutsceneOn)
        {
            cutsceneOn = false;
            cutsceneWindow.SetActive(false);
        }

    }
}
