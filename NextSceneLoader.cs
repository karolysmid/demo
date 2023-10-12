using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextSceneLoader : MonoBehaviour
{

    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="Player")
        {
            Debug.Log("Player entered, loading scene. Current scene is "+ SceneManager.GetActiveScene().name + " from "+ SceneManager.sceneCount);
        SceneManager.LoadScene("DemoScene1", LoadSceneMode.Single);
        SceneManager.UnloadSceneAsync("DemoScene");
     // SceneManager.LoadScene(SceneManager.)
        }
    }
    
}
