using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GM : MonoBehaviour
{

    [SerializeField] private GameObject cutsceneWindow;
    private bool cutsceneOn;
    [SerializeField] public GameObject player;
    [Space]
    public List<Texture2D> cursors;
    public AudioManager am;

    // Start is called before the first frame update
    void Start()
    { 
        cutsceneWindow.SetActive(true);
        cutsceneOn = true;
        if (am == null) am = GameObject.Find("AudioManager").GetComponent<AudioManager>();
        am.Play("OST");
    }

    // Update is called once per frame
    void Update()
    {
        if (am == null) am = GameObject.Find("AudioManager").GetComponent<AudioManager>();
        if (Input.anyKeyDown && cutsceneOn)
        {
            cutsceneOn = false;
            cutsceneWindow.SetActive(false);
        }

    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ChangeCursor(int cursorIndex)
    {
        Cursor.SetCursor(cursors[cursorIndex], Vector2.zero, CursorMode.Auto);
    }
}
