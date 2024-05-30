using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;
using UnityEngine.UIElements;

public class YumpTrigger : MonoBehaviour
{
    public GameObject player;
    public GameObject triggerZone;
    public GameObject yump;
    private bool CanYump = false;


    // Update is called once per frame
    void Update()
    {
        YumpCheck();
    }


    private void OnTriggerEnter(Collider otherObject)
    {
        if (otherObject.transform.tag == "Player")
        {
            CanYump = true;
        }
    }
    private void OnTriggerExit(Collider otherObject)
    {
        if (otherObject.transform.tag == "Player")
        {
            CanYump = false;
        }
    }

    private void ZoneDestroy()
    {
        Destroy(this.gameObject);
    }

    private void YumpCheck()
    {
        if (Input.GetKeyDown(KeyCode.E) && CanYump == true)
        {
            Instantiate(yump, transform.position + new Vector3(0,3,0), Quaternion.Euler(0, 0, 0));
            Invoke("ZoneDestroy", 7);
        }
    }
}
