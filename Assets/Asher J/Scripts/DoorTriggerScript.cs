using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DoorTriggerScript : MonoBehaviour
{
    
    public GameObject player;
    public GameObject trigger;
    public float triggerProximity;
    private bool doorsOpen;

    // Start is called before the first frame update
    void Start()
    {
        doorsOpen = false;
    }

    void Update()
    {
        if(Vector3.Distance(player.transform.position, trigger.transform.position) <= triggerProximity)
        {
            if(doorsOpen == false)
            {
                GetComponent<Animation>().Play();
                doorsOpen = true;
            }
        }
    }
}
