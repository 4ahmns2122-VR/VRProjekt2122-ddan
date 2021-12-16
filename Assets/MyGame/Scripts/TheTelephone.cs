using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheTelephone : MonoBehaviour
{

    public GameObject telephoneRing;
    public GameObject telephoneHello;
    private GameObject go;
    public GameObject floor;
    public GameObject door;
    public Transform ringToneposition;
    public Transform doorPosition;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("TelephoneRings"))
        {
            go = Instantiate(telephoneRing, ringToneposition.position, Quaternion.identity);
        }

        if (other.gameObject.CompareTag("TelephoneSaysHello"))
        {
            Destroy(go);
            Instantiate(telephoneHello, ringToneposition.position, Quaternion.identity);
            Destroy(floor, 8f);
            Instantiate(door, doorPosition.position, Quaternion.identity);
        }
    }

}
