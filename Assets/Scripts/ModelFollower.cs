using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelFollower : MonoBehaviour
{
    [SerializeField] private Transform player;
    private void Start()
    {
        if(player == null)
        {
            player = GameObject.Find("Player").transform;
        }
    }
    void FixedUpdate()
    {
        transform.position = player.position;
        if(player.rotation.z > 0)
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        } else
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }
    }
}
