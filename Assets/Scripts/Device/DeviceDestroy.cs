using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameDev3.Project
{
    public class DeviceDestroy : MonoBehaviour, IInteractable, IActorEnterExitHandler
    {
        [Header("Config")]
        public float SpeedDevice = 4f;
        [Header("----------------------------")]
        public TimeCount timeCount;
        private bool Working = false;


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
                if (inventory.m_ItemInventory.Count != 0)
                {
                    inventory.m_ItemInventory.Clear();
                    timeSystem.Working = true;
                    FindObjectOfType<AudioManager>().Play("Shredder");

                    Working = true;
                    Invoke("DeviceFinished", SpeedDevice);
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
            var timeSystem = this.gameObject.GetComponent<TimeSystem>();
            timeSystem.Working = false;
            Working = false;
        }
    }
}