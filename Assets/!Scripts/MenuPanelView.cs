using UnityEngine;
using UnityEngine.UI;

public class MenuPanelView : MonoBehaviour
{
    [SerializeField] private Button _spriteThemeButton;
    [SerializeField] private GameObject _commonPanel;
    [SerializeField] private GameObject[] _objectsToShow;
    
    void Start()
    {
        _commonPanel.SetActive(false);
        _spriteThemeButton.onClick.AddListener(SpriteThemeButtonClicked);
        if (_objectsToShow != null)
        {
            foreach (var obj in _objectsToShow)
            {
                obj.SetActive(false);
            }
        }
    }

    void SpriteThemeButtonClicked(){
        _commonPanel.SetActive(true);
        if(_objectsToShow != null)
        {
            foreach(var obj in _objectsToShow)
            {
                obj.SetActive(true);
            }
        }
    }
}
