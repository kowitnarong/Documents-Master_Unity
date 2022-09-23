using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameDev3.Project
{
    public class DeviceEnd : MonoBehaviour, IInteractable, IActorEnterExitHandler
    {
        [Header("Receive")]
        public string ReceiveID;
        [Header("Config")]
        public int ScorePath;

        public void Interact(GameObject actor)
        {
            var inventory = actor.gameObject.GetComponent<Inventory>();

            if (inventory.m_ItemInventory.Contains(ReceiveID))
            {
                inventory.m_ItemInventory.Remove(ReceiveID);
                AddScore();
            }
            else
            {
                if (inventory.m_ItemInventory.Count != 0)
                {
                    inventory.m_ItemInventory.Clear();
                    inventory.AddItem("DestroyItem");
                }
            }
        }

        public void ActorEnter(GameObject actor)
        {
           
        }

        public void ActorExit(GameObject actor)
        {
           
        }

        public virtual void AddScore()
        {
            Score.ScoreGame += ScorePath;
        }
    }
}