using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YumpCollect : MonoBehaviour
{
    public GameObject YumpZone;

    private void OnTriggerEnter(Collider otherObject)
    {
        if (otherObject.transform.tag == "Player")
        {
            Instantiate(YumpZone, new Vector3(70,11,20), Quaternion.Euler(-90,0,0));
            Instantiate(YumpZone, new Vector3(47,11,90), Quaternion.Euler(-90,0,0));
            Instantiate(YumpZone, new Vector3(48,11,40), Quaternion.Euler(-90,0,0));
        }
    }
}
