using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameDev3.Project
{
    public class AiBehavior : MonoBehaviour
    {
        public GameObject itemSpeed;
        public float DelayDrop;
        
        // Start is called before the first frame update
        void Start()
        {
            StartCoroutine(DropItem());
        }
        
        public IEnumerator DropItem()
        {
            yield return new WaitForSeconds(DelayDrop);
            Instantiate(itemSpeed, new Vector3(transform.position.x, transform.position.y + 2, transform.position.z), itemSpeed.transform.rotation);
            FindObjectOfType<AudioManager>().Play("SpawnItem");
            StartCoroutine(DropItem());
        }
    }
}