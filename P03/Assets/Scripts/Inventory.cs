using System.Collections;
using System.Collections.Generic;
<<<<<<< HEAD
using System.Linq;
=======
>>>>>>> main
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private List<Item> itemList;
    public Inventory()
    {
        itemList = new List<Item>();
<<<<<<< HEAD
        for (int i = 0; i<9; i++)
        {
            AddItem(new Item { _itemType = Item.ItemType.Empty, amount = 1 });
        }
    }
    public void AddItem(Item item)
    {
        /*if (item.IsStackable())
        {
            bool itemAlreadyInInventory = false;
            foreach(Item inventoryItem in itemList.ToList())
            {
                if(inventoryItem.itemType == item.itemType)
                {
                    inventoryItem.amount += item.amount;
                    itemAlreadyInInventory = true;
                }
                if (!itemAlreadyInInventory)
                {
                    itemList.Add(item);
                }
            }
        }
        else
        {
            itemList.Add(item);
        }*/
=======
        AddItem(new Item { itemType = Item.ItemType.Log, amount = 1 });
        AddItem(new Item { itemType = Item.ItemType.Stick, amount = 1 });
        AddItem(new Item { itemType = Item.ItemType.Sword, amount = 1 });
        Debug.Log(itemList.Count);
    }
    public void AddItem(Item item)
    {
>>>>>>> main
        itemList.Add(item);
    }
    public List<Item> GetItemList()
    {
        return itemList;
    }
}
