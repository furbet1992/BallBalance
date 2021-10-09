using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public SceneMan sceneMan;
    public int completeAmt;
    static public int enemiesCount; 


    void Start()
    {
        Level(completeAmt);
        enemiesCount = 0; 

    }

    // Update is called once per frame
    void Update()
    {
        Level(completeAmt); 
    }


    void Level(int pass)
    {
        if(enemiesCount >= pass)
        {
            sceneMan.NextLevel(); 
            Debug.Log("Level Completed"); 
        }
        //when the amt of enemies are killed equals the int-Pass, Level completes


    }
}
