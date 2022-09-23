using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace GameDev3.Project
{
    public class PlayerControllerWithActorTrigger : MonoBehaviour
    {
        [SerializeField] protected ActorTriggerHandler m_ActorTriggerHandler;

        public Key InteractionKey = Key.E;

        private void Update()
        {
            Keyboard keyboard = Keyboard.current;

            if (keyboard[InteractionKey].wasPressedThisFrame)
            {
                PerformInteraction();
            }
        }

        protected virtual void PerformInteraction()
        {
            var interactable = m_ActorTriggerHandler.GetInteractable();

            if (interactable != null)
            {
                interactable.Interact(gameObject);
            }
        }
    }

}