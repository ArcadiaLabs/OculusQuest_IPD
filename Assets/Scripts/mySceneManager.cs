using UnityEngine;
using UnityEngine.SceneManagement;



public class mySceneManager : MonoBehaviour
{
    //[SerializeField]
    //private int thisSceneNumber;

    int sceneCount;
    int nextScene;
    int thisScene;

    void Start()
    {

        //Debug.Log("This Scene Count: " + thisScene);
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

        //Debug.Log("Next Scene: " + nextScene);
    }

    private void Update()
    {
        //sceneCount = SceneManager.sceneCountInBuildSettings;
        thisScene = SceneManager.GetActiveScene().buildIndex;
        //debug.log("this scene: " + thisscene);

        if (sceneCount - 1 == thisScene)
        {
            nextScene = 0;
        }
        else
        {
            nextScene = thisScene + 1;
        }

        Debug.Log("scene count: " + sceneCount);
        Debug.Log("this scene: " + thisScene);
        Debug.Log("next scene: " + nextScene);

        //if (OVRInput.GetUp(OVRInput.RawButton.A))
        if (OVRInput.Get(OVRInput.Button.One))
        {
            //Debug.Log("Loading Scene: " + nextScene);
            LoadScene(nextScene);
        }
    }

    public void LoadScene(int sceneNumber)
    {
        //m_text.SetText("Button A pressed");
        //Debug.Log("sceneBuildIndex to load: " + sceneNumber);
        Debug.Log("Loading Scene: " + nextScene);
        SceneManager.LoadScene(sceneNumber);
        //SceneManager.LoadScene(sceneNumber);
    }
}