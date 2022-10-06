using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dontdestroy : MonoBehaviour
{
    private Scene currentScene;
    private void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Music");
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
