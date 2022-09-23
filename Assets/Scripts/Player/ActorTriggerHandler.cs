using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Data.SqlTypes;

namespace GameDev3.Project
{
    public class ActorTriggerHandler : MonoBehaviour
    {
        [SerializeField] protected List<GameObject> m_TriggeredGameObjects = new();

        [SerializeField] protected GameObject m_Actor;

        protected virtual void Start()
        {
            if (m_Actor == null)
            {
                m_Actor = GetComponentInParent<Transform>().gameObject;
            }
        }

        protected virtual void OnCollisionEnter(Collision other)
        {
            var interactableComponents = other.gameObject.GetComponents<IInteractable>();

            if (interactableComponents != null)
            {
                foreach (var ic in interactableComponents)
                {
                    if (ic is IActorEnterExitHandler enterExitHandler)
                    {
                        enterExitHandler.ActorEnter(m_Actor);
                    }
                }

                m_TriggeredGameObjects.Add(other.gameObject);
            }
        }

        private void OnCollisionStay(Collision other)
        {

        }

        protected virtual void OnCollisionExit(Collision other)
        {
            var interactableComponents = other.gameObject.GetComponents<IInteractable>();

            if (interactableComponents != null)
            {
                foreach (var ic in interactableComponents)
                {
                    if (ic is IActorEnterExitHandler enterExitHandler)
                    {
                        enterExitHandler.ActorExit(m_Actor);
                    }
                }

                m_TriggeredGameObjects.Remove(other.gameObject);
            }

        }

        public IInteractable GetInteractable()
        {
            m_TriggeredGameObjects.RemoveAll(gameject => gameject == null);

            if (m_TriggeredGameObjects.Count == 0)
            {
                return null;
            }

            return m_TriggeredGameObjects[0].GetComponent<IInteractable>();
        }
    }
}