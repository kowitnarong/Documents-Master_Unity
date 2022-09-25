using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameDev3.Project
{
    public class DeviceEnd : MonoBehaviour, IInteractable, IActorEnterExitHandler
    {
        [Header("Receive")]
        public string Receive1ID;
        public string Receive2ID;
        public string Receive3ID;
        public string Receive4ID;
        [Header("Config")]
        public int ScorePath1;
        public int ScorePath2;
        public int ScorePath3;
        public int ScorePath4;

        public void Interact(GameObject actor)
        {
            var inventory = actor.gameObject.GetComponent<Inventory>();

            if (inventory.m_ItemInventory.Contains(Receive1ID))
            {
                inventory.m_ItemInventory.Remove(Receive1ID);
                AddScore1();
            }
            else if (inventory.m_ItemInventory.Contains(Receive2ID))
            {
                inventory.m_ItemInventory.Remove(Receive2ID);
                AddScore2();
            }
            else if (inventory.m_ItemInventory.Contains(Receive3ID))
            {
                inventory.m_ItemInventory.Remove(Receive3ID);
                AddScore3();
            }
            else if (inventory.m_ItemInventory.Contains(Receive4ID))
            {
                inventory.m_ItemInventory.Remove(Receive4ID);
                AddScore4();
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

        public virtual void AddScore1()
        {
            Score.ScoreGame += ScorePath1;
        }
        public virtual void AddScore2()
        {
            Score.ScoreGame += ScorePath2;
        }
        public virtual void AddScore3()
        {
            Score.ScoreGame += ScorePath3;
        }
        public virtual void AddScore4()
        {
            Score.ScoreGame += ScorePath4;
        }
    }
}