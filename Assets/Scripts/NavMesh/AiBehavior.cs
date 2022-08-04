using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameDev3.Project
{
    public class AiBehavior : MonoBehaviour
    {
        public GameObject itemSpeed;
        // Start is called before the first frame update
        void Start()
        {
            StartCoroutine(DropItem());
        }

        public IEnumerator DropItem()
        {
            yield return new WaitForSeconds(30);
            Instantiate(itemSpeed, new Vector3(transform.position.x, transform.position.y + 2, transform.position.z), transform.rotation);
            StartCoroutine(DropItem());
        }
    }
}