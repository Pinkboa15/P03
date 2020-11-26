using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
<<<<<<< HEAD
using TMPro;
=======

>>>>>>> main
public class UI_Inventory : MonoBehaviour
{
    private Inventory inventory;
    private Transform ItemSlotContainer;
    private Transform ItemSlotTemplate;
<<<<<<< HEAD
    private Image image;
=======
>>>>>>> main
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
<<<<<<< HEAD
        float itemSlotCellSize = 50f;
=======
        float itemSlotCellSize = 23f;
>>>>>>> main
        foreach (Item item in inventory.GetItemList())
        {
            RectTransform itemSlotRectTransform = Instantiate(ItemSlotTemplate, ItemSlotContainer).GetComponent<RectTransform>();
            itemSlotRectTransform.gameObject.SetActive(true);
<<<<<<< HEAD

            itemSlotRectTransform.anchoredPosition = new Vector2(x * itemSlotCellSize, y * itemSlotCellSize);
            /*image = itemSlotRectTransform.Find("Image").GetComponent<Image>();
            image.sprite = item.GetSprite();
            TextMeshProUGUI uiText = itemSlotRectTransform.Find("Amount Text").GetComponent<TextMeshProUGUI>();
            if (item.amount > 1)
            {
                uiText.SetText(item.amount.ToString());
            }
            else
            {
                uiText.SetText("");
            }*/
            x++;
            if (x>8)
            {
                x = 0;
=======
            itemSlotRectTransform.anchoredPosition = new Vector2(x * itemSlotCellSize, y * itemSlotCellSize);
            //Image image = itemSlotRectTransform.Find("image").GetComponent<Image>();
            //image.sprite = item.GetSprite();
            x++;
            if (x>4)
            {
                x = 0;
                y++;
>>>>>>> main
            }
        }
    }
}
