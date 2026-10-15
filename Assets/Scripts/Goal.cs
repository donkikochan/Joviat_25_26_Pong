using System;
using UnityEngine;

public class Goal : MonoBehaviour
{
    
    public GameManager gm;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        
        Debug.Log("Entered Goal: " + other.gameObject.name);
        if (other.gameObject.name == "Ball")
        {
            other.gameObject.GetComponent<Ball>().Reset(); 
            
            //TODO--> fent ús de name cridar a la funció addScore de gameManager.

            if (name == "Goal_Left")
            {
                gm.AddScore(1,PlayerType.PlayerRight);
            }else if (name == "Goal_Right")
            {
                gm.AddScore(1,PlayerType.PlayerLeft);
            }
        }
        
        //Destroy(other.gameObject);
        
    }
}
