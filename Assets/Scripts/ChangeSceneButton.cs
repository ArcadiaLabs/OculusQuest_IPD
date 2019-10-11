using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ChangeSceneButton : MonoBehaviour
{
    public string LevelToLoad;

    int sceneCount;
    int nextScene;
    int thisScene;

    public void LoadLevel()
    {
        sceneCount = SceneManager.sceneCountInBuildSettings;
        //Debug.Log("Scene Count: " + sceneCount);

        thisScene = SceneManager.GetActiveScene().buildIndex;
        //Debug.Log("This Count: " + thisScene);

        if (sceneCount - 1 == thisScene)
        {
            nextScene = 0;
        }
        else
        {
            nextScene = thisScene + 1;
        }

        //LevelToLoad = nextScene;

        Debug.Log("Loading Scene: " + nextScene);
        SceneManager.LoadScene(nextScene);
    }
}
