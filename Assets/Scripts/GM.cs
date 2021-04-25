using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GM : MonoBehaviour
{

    [SerializeField] private GameObject cutsceneWindow;
    private bool cutsceneOn;
    [SerializeField] public GameObject player;

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

    public void LoadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}