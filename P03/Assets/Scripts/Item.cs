using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public enum ItemType
    {
        Sword,
        Stick,
        Log,
        Plank,
<<<<<<< HEAD
        Empty,
    }
    public ItemType _itemType;
    public int amount;
    public Sprite GetSprite()
    {
        switch (_itemType)
=======
    }
    public ItemType itemType;
    public int amount;
    public Sprite GetSprite()
    {
        switch(itemType)
>>>>>>> main
        {
            default:
            case ItemType.Sword: return ItemAssets.Instance.swordSpirte;
            case ItemType.Log: return ItemAssets.Instance.logSpirte;
            case ItemType.Plank: return ItemAssets.Instance.plankSpirte;
            case ItemType.Stick: return ItemAssets.Instance.stickSpirte;
        }
    }
<<<<<<< HEAD
    public bool IsStackable()
    {
        switch (_itemType)
        {
            default:
            case ItemType.Log:
            case ItemType.Plank:
            case ItemType.Stick:
                return true;
            case ItemType.Sword:
                return false;
        }
    }
=======
>>>>>>> main
}
