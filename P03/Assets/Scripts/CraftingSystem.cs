using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CraftingSystem : MonoBehaviour
{
    [SerializeField] GameObject g;
    private List<GameObject> slotList;
    private GameObject _UIcraft;
    private Image craftedItem;

    private void Awake()
    {
        slotList = new List<GameObject>();
        for (int i = 0; i < 9; i++)
        {
            AddObject(_UIcraft = GameObject.Find("Slot "+i));
        }
        Debug.Log(GetItemList().ToString());
    }
    public void isItEmpty(Vector3 vector, bool empty)
    {
        foreach(GameObject game in GetItemList())
        {
            if(game.GetComponent<RectTransform>().position == vector)
            {
                SetCraftedSlot();
            }
        }
    }
    public void AddObject(GameObject item)
    {
        slotList.Add(item);
    }
    public List<GameObject> GetItemList()
    {
        return slotList;
    }
    public void SetCraftedSlot()
    {
        
        craftedItem.sprite = ItemAssets.Instance.plankSpirte;
        g.GetComponent<Image>().sprite= craftedItem.sprite;
    }
}