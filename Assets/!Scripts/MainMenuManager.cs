using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuManager : MonoBehaviour
{
    private string _sceneToUnload;
    [SerializeField]
    private GameObject _mainMenu;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            _mainMenu.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            _mainMenu.SetActive(false);
        }
    }

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
