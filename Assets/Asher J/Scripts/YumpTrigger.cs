using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;
using UnityEngine.UI;

public class YumpTrigger : MonoBehaviour
{
    public GameObject player;
    public GameObject triggerZone;
    public GameObject yump;
    public GameObject fishingSpot;
    public GameManager gameManager;
    private bool CanYump = false;

    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

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
        gameManager.currentPickups += 1;

        if (gameManager.currentPickups >= gameManager.maxPickups)
        {
            Debug.Log("Fishing Spot");
            Instantiate(fishingSpot, new Vector3(43, 10, 8), Quaternion.Euler(0, 0, 0));
        }

        Destroy(this.gameObject);
    }

    private void YumpCheck()
    {
        if (Input.GetKeyDown(KeyCode.E) && CanYump == true)
        {
            Instantiate(yump, transform.position + new Vector3(0,2,0), Quaternion.Euler(0,0,0));
            Invoke("ZoneDestroy", 7);
        }
    }
}
