using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lootable : MonoBehaviour
{

    [Header("Lootable settings")]
    public bool isEmpty;
    public int itemId;
    public string soundToPlay;
    [Space]
    [Header("Lootable texture")]
    public Sprite afterImage;
    [Space]
    [Header("References")]
    public GM gm;
    public Transform playerT;
    [SerializeField] private Vector2 mousePos;
    [SerializeField] private float mouseDistance;

    private void Update()
    {
        mousePos = new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y);
        mouseDistance = Vector2.Distance(mousePos, playerT.position);

        if(mouseDistance < 3)
        {
            if(Input.GetButtonDown("Interact") && !isEmpty)
            {
                gameObject.GetComponent<SpriteRenderer>().sprite = afterImage;
                playerT.gameObject.GetComponent<Inventory>().GiveItem(itemId);
                isEmpty = true;
                gm.gameObject.GetComponent<AudioManager>().Play(soundToPlay);
            } else if(Input.GetButtonDown("Interact"))
            {
                gameObject.GetComponent<SpriteRenderer>().sprite = afterImage;
            }
        }
    }

}
