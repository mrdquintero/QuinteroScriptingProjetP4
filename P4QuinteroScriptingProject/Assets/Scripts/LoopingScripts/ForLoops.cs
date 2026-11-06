using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoops : MonoBehaviour
{

    //Creating the variables for my script
    int numEnemies = 3;
    
    // Start is called before the first frame update
    void Start()
    {

        //my for loop is going to check if there are enemies in the game and if there aren't
        //it will print a message to the console saying it created an enemy

        for (int i = 0; i < numEnemies; i++)
        {
            Debug.Log("Creating enemy number: " + i);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
