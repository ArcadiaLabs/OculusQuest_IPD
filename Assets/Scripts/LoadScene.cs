using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public string LevelToLoad;


    public void LoadLevel()
    {
 
        SceneManager.LoadScene(LevelToLoad);
    }

    public void ChangeLevelToLoad(string LevelToLoad)
    {
        FindObjectOfType<LoadScene>().LevelToLoad = LevelToLoad;
    }
}
