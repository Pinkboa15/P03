using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private List<Item> itemList;
    public Inventory()
    {
        itemList = new List<Item>();
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
        itemList.Add(item);
    }
    public List<Item> GetItemList()
    {
        return itemList;
    }
}
