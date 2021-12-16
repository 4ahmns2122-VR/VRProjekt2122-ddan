using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LighterSpawn : MonoBehaviour
{
    public GameObject lighter;
    public Transform lighterSpawn;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Instantiate(lighter, lighterSpawn.position, Quaternion.identity);
        }
    }



}

