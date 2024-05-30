using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectiveManager : MonoBehaviour
{
    public GameObject player;
    public GameManager gameManager;

    public int BaitCollected;
    public bool YumpCollected;
    public bool RodCollected;


    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider otherObject)
    {
        if (otherObject.transform.tag == "Player")
        {
            gameManager.currentPickups += 1;
            Destroy(this.gameObject);
        }
    }

}
