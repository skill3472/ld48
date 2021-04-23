using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDatabase : MonoBehaviour
{

    public List<Item> items = new List<Item>();

    private void Awake()
    {
        BuildDatabase();
    }

    public Item GetItem(int id)
    {
        return items.Find(item => item.id == id);
    }

    void BuildDatabase()
    {
        items = new List<Item>() {
            new Item(0), //NULL:
            new Item(1), //NULL
            new Item(2), //NULL
            new Item(3), //NULL
            new Item(4) //NULL


        };
    }


}
