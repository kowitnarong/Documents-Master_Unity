using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameDev3.Project
{
    public class DevicePath : MonoBehaviour, IInteractable, IActorEnterExitHandler
    {
        [Header("Receive")]
        public string ReceiveID;
        [Header("Return")]
        public string DeviceID;
        [Header("Config")]
        public float SpeedDevice = 4f;
        [Header("----------------------------")]
        public TimeCount timeCount;
        private bool Working = false;
        private bool isFinished = false;


        void Start()
        {
            timeCount.maxTime = SpeedDevice;
        }

        public void Interact(GameObject actor)
        {
            var timeSystem = this.gameObject.GetComponent<TimeSystem>();
            var inventory = actor.gameObject.GetComponent<Inventory>();

            if (Working == false)
            {
                if (inventory.m_ItemInventory.Contains(ReceiveID))
                {
                    inventory.m_ItemInventory.Remove(ReceiveID);

                    timeSystem.Working = true;
                    Working = true;
                    Invoke("DeviceFinished", SpeedDevice);
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
            if (inventory.m_ItemInventory.Count == 0)
            {
                if (isFinished)
                {
                    inventory.AddItem(DeviceID);
                    timeSystem.Working = false;
                    isFinished = false;
                    Working = false;
                }
            }            
        }

        public void ActorEnter(GameObject actor)
        {
           
        }

        public void ActorExit(GameObject actor)
        {
           
        }

        void DeviceFinished()
        {
            isFinished = true;
        }
    }
}