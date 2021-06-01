using UnityEngine;
using UnityEngine.SceneManagement;

public class Quit : MonoBehaviour
{
    public void Exit()
    {
        Application.Quit();
    }

    public void SceneChange(string scene_name)
    {
        SceneManager.LoadScene(scene_name);
    }

}

