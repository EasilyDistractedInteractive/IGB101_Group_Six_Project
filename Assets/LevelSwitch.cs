using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSwitch : MonoBehaviour
{
    public GameManager gameManager;
    public string nextLevel;
    
    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();   
    }

    private void OnTriggerEnter(Collider otherObject)
    {
        if(otherObject.transform.tag == "Player")
        {
            print("GO");
            if(gameManager.levelComplete == true)
            {
                
                SceneManager.LoadScene(nextLevel, LoadSceneMode.Single);
            }
        }
    } 
}
