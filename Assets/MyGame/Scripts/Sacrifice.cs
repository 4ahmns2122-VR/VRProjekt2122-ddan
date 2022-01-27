using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sacrifice : MonoBehaviour
{
    public GameObject naturesWall;
    private bool isMoving = false;
    public float speed;

    private void Update()
    {
        if (isMoving) {
            Vector3 position = gameObject.transform.position;
            position.y -= Time.deltaTime * speed;
            gameObject.transform.position = position;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Crow"))
        {
            isMoving = true;
            Destroy(naturesWall, 3f);
            GameObject[] objArr = GameObject.FindGameObjectsWithTag("Crow");
            foreach (var obj in objArr)
            {
                Destroy(obj, 3f);
            }
        }
    }

}
