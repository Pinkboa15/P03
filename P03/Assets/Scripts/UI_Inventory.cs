using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Inventory : MonoBehaviour
{
    private Inventory inventory;
    private Transform ItemSlotContainer;
    private Transform ItemSlotTemplate;
    private void Awake()
    {
        ItemSlotContainer = transform.Find("itemSlotContainer");
        ItemSlotTemplate = ItemSlotContainer.Find("itemSlotTemplate");
    }
    public void SetInventory(Inventory inventory)
    {
        this.inventory = inventory;
        RefreshInventoryItems();
    }
    private void RefreshInventoryItems()
    {
        int x = 0;
        int y = 0;
        float itemSlotCellSize = 23f;
        foreach (Item item in inventory.GetItemList())
        {
            RectTransform itemSlotRectTransform = Instantiate(ItemSlotTemplate, ItemSlotContainer).GetComponent<RectTransform>();
            itemSlotRectTransform.gameObject.SetActive(true);
            itemSlotRectTransform.anchoredPosition = new Vector2(x * itemSlotCellSize, y * itemSlotCellSize);
            //Image image = itemSlotRectTransform.Find("image").GetComponent<Image>();
            //image.sprite = item.GetSprite();
            x++;
            if (x>4)
            {
                x = 0;
                y++;
            }
        }
    }
}
