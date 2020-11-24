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
    }
    public ItemType itemType;
    public int amount;
    public Sprite GetSprite()
    {
        switch(itemType)
        {
            default:
            case ItemType.Sword: return ItemAssets.Instance.swordSpirte;
            case ItemType.Log: return ItemAssets.Instance.logSpirte;
            case ItemType.Plank: return ItemAssets.Instance.plankSpirte;
            case ItemType.Stick: return ItemAssets.Instance.stickSpirte;
        }
    }
}
