using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dontdestroy : MonoBehaviour
{
    // Music won't stop ;)
    private Scene currentScene;
    private void Awake()
    {

        //Create array with the number of game objects with tag Music
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Music");
        //If the lenght is more then one it means there's more sounds
        currentScene = SceneManager.GetActiveScene();
        if (objs.Length > 1)
        {
            Destroy(this.gameObject);

            if(currentScene.name == "Video1" || currentScene.name == "Video2" || currentScene.name == "Video3")
            {
                foreach (GameObject go in objs)
                {
                    Destroy(go);
                }
            }
        }

        else
        {
            DontDestroyOnLoad(this.gameObject);
        }
    }

}
