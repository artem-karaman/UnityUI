using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    private string _sceneToUnload;

    public void LoadScene(string sceneName)
    {
        if(_sceneToUnload != null)
        {
            SceneManager.UnloadSceneAsync(_sceneToUnload);
            _sceneToUnload = null;
        }

        if (!string.IsNullOrEmpty(sceneName))
        {
            SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Additive);
            _sceneToUnload = sceneName;
        }
    }
}
