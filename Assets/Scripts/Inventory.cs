using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameDev3.Project
{
    public class Inventory : MonoBehaviour
    {
        [SerializeField] public List<string> m_ItemInventory = new();

        public void AddItem(string itemName)
        {
            if (m_ItemInventory.Count == 0)  
            {
                m_ItemInventory.Add(itemName);
            }
        }

        public void RemoveItem(string itemName)
        {
            m_ItemInventory.Remove(itemName);
        }
    }
}