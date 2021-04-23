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
            new Item(0),
            new Item(1),
            new Item(2),
            new Item(3),
            new Item(4)


        };
    }


}
