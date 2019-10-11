
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class myManualSceneManager : MonoBehaviour
{
    [SerializeField]
    string LevelToLoad;

    void Start()
    {
        Debug.Log("Script START");
    }

    private void Update()
    {
        if (OVRInput.Get(OVRInput.Button.One))
        {
            LoadLevel();
        }
    }

    void LoadLevel()
    {
        Debug.Log("Loading Scene: " + LevelToLoad);
        SceneManager.LoadScene(LevelToLoad);
    }
}