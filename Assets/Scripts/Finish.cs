using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Finish : MonoBehaviour
{
    // Start is called before the first frame update


    //UI
    public GameObject uiText; 


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            uiText.SetActive(true);
            StartCoroutine(ChangeScene()); 
           
        }
    }

    IEnumerator ChangeScene()
    {
        yield return new WaitForSeconds(2);
        SceneMan.NextLevel();
    }

}
