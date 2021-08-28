using UnityEngine;
using UnityEngine.UI;

public class MenuPanelView : MonoBehaviour
{
    [SerializeField]private Button _spriteThemeButton;
    [SerializeField]private GameObject _asteroidGameObject;

    
    void Start()
    {
        _asteroidGameObject.SetActive(false);
        _spriteThemeButton.onClick.AddListener(SpriteThemeButtonClicked);
    }

    void SpriteThemeButtonClicked(){
        _asteroidGameObject.SetActive(true);
    }
}
