using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrowSpawn : MonoBehaviour
{
    public GameObject crow;
    public Transform crowSpawn;

    private void OnTriggerEnter(Collider other)
    {
       if (other.gameObject.CompareTag("Player"))
        {
            Instantiate(crow, crowSpawn.position, Quaternion.identity);
        }
    }



}
