using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

namespace GameDev3.Project
{
    public class ShowTextItem : MonoBehaviour
    {
        public TextMeshProUGUI textItem;
        public Inventory PlayerInventory;

        private void Update()
        {
            if (PlayerInventory.m_ItemInventory.Count != 0)
            {
                foreach (object o in PlayerInventory.m_ItemInventory)
                {
                    if (o.ToString() == "DestroyItem")
                    {
                        textItem.SetText("Trash");
                    }
                    else
                    {
                        textItem.SetText(o.ToString().Substring(6, 1));
                    }
                }
            }
            else
            {
                textItem.SetText("");
            } 
        }
    }
}