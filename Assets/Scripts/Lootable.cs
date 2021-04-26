using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lootable : MonoBehaviour
{

    [Header("Lootable settings")]
    public bool isEmpty;
    public int itemId;
    public string soundToPlay;
    public bool isEnder;
    [Space]
    [Header("Lootable texture")]
    public Sprite afterImage;
    [Space]
    [Header("References")]
    public GM gm;
    public Transform playerT;
    public Inventory playerInventory;
    [SerializeField] private Vector2 mousePos;
    [SerializeField] private float mouseDistance;
    [SerializeField] private GameObject nextzone;
    [SerializeField]
    private bool killMe;


    private void Awake()
    {
        if(gameObject.GetComponent<EdgeCollider2D>() != null)
        {
            killMe = true;
        }
    }
    private void Update()
    {
        mousePos = new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y);
        mouseDistance = Vector2.Distance(mousePos, playerT.position);
            if (mouseDistance < 3)
            {
                if (Input.GetButtonDown("Interact") && !isEmpty)
                {
                    if (gameObject.GetComponent<Keyhole>() == null)
                    {
                        gameObject.GetComponent<SpriteRenderer>().sprite = afterImage;
                        playerT.gameObject.GetComponent<Inventory>().GiveItem(itemId);
                        isEmpty = true;
                        gm.gameObject.GetComponent<AudioManager>().Play(soundToPlay);
                        if(isEnder) nextzone.SetActive(true);
                    if (killMe) Destroy(GetComponent<Collider2D>());
                }   else if (playerInventory.CheckForItem(gameObject.GetComponent<Keyhole>().reqItemID) != null)
                    {
                        gameObject.GetComponent<SpriteRenderer>().sprite = afterImage;
                        playerT.gameObject.GetComponent<Inventory>().GiveItem(itemId);
                        isEmpty = true;
                        gm.gameObject.GetComponent<AudioManager>().Play(soundToPlay);
                    if(isEnder) nextzone.SetActive(true);
                    if (killMe) Destroy(GetComponent<Collider2D>());
                }
                }
            }
    }

}
