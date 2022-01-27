using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guilt : MonoBehaviour
{
    public GameObject naturesWall2;
    private bool isMoving = false;
    public float speed;

    private void Update()
    {
        if (isMoving)
        {
            Vector3 position = gameObject.transform.position;
            position.y -= Time.deltaTime * speed;
            gameObject.transform.position = position;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Lighter"))
        {
            isMoving = true;
            Destroy(naturesWall2, 3f);
            GameObject[] objArr = GameObject.FindGameObjectsWithTag("Lighter");
            foreach(var obj in objArr)
            {
                Destroy(obj, 3f);
            }
        }
    }

}
