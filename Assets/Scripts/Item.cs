 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    public int id;
    public Sprite icon;
    public Item(int id)
    {
        this.id = id;
        this.icon = Resources.Load<Sprite>("Sprites/Items/" + id.ToString());
    }

    public Item(Item item)
    {
        this.id = item.id;
        this.icon = Resources.Load<Sprite>("Sprites/Items/" + item.id.ToString());
    }
}
