using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace GameDev3.Project
{
    public class NavMesh : MonoBehaviour
    {

        [SerializeField] private Transform movePositionTranform1;
        [SerializeField] private Transform movePositionTranform2;
        [SerializeField] private Transform movePositionTranform3;
        [SerializeField] private Transform movePositionTranform4;
        [SerializeField] private Transform movePositionTranform5;
        [SerializeField] private Transform movePositionTranform6;
        [SerializeField] private Transform movePositionTranform7;
        [SerializeField] private Transform movePositionTranform8;
        [SerializeField] private Transform movePositionTranform9;
        [SerializeField] private Transform movePositionTranform10;

        

        public int randomSpot;
        int _randomSpot;
        private NavMeshAgent navMeshAgent;
        private Animator animator;


        void Awake()
        {
            navMeshAgent = GetComponent<NavMeshAgent>();
            animator = GetComponentInChildren<Animator>();
        }

        void Start()
        {
            randomSpot = Random.Range(1, 11);
            animator.SetTrigger("RunningTrigger");
            animator.SetBool("RunningBool", true);
            StartCoroutine(RandomSpot());
        }

        // Update is called once per frame
        void Update()
        {
            switch (randomSpot)
            {
                case 1:
                    navMeshAgent.destination = movePositionTranform1.position;
                    break;
                case 2:
                    navMeshAgent.destination = movePositionTranform2.position;
                    break;
                case 3:
                    navMeshAgent.destination = movePositionTranform3.position;
                    break;
                case 4:
                    navMeshAgent.destination = movePositionTranform4.position;
                    break;
                case 5:
                    navMeshAgent.destination = movePositionTranform5.position;
                    break;
                case 6:
                    navMeshAgent.destination = movePositionTranform6.position;
                    break;
                case 7:
                    navMeshAgent.destination = movePositionTranform7.position;
                    break;
                case 8:
                    navMeshAgent.destination = movePositionTranform8.position;
                    break;
                case 9:
                    navMeshAgent.destination = movePositionTranform9.position;
                    break;
                case 10:
                    navMeshAgent.destination = movePositionTranform10.position;
                    break;
            }

            if (!navMeshAgent.pathPending)
            {
                if (navMeshAgent.remainingDistance <= navMeshAgent.stoppingDistance)
                {
                    if (!navMeshAgent.hasPath || navMeshAgent.velocity.sqrMagnitude == 0f)
                    {
                        animator.SetBool("RunningBool", false);
                    }
                }
            }

        }

        public IEnumerator RandomSpot()
        {
            yield return new WaitForSeconds(8);
            do
            {
                _randomSpot = Random.Range(1, 11);
            } while (_randomSpot == randomSpot);
            randomSpot = _randomSpot;
            animator.SetTrigger("RunningTrigger");
            animator.SetBool("RunningBool", true);
            StartCoroutine(RandomSpot());
        }
    }
}