using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuPanelView : MonoBehaviour
{
    [SerializeField]private Button _spriteThemeButton;
    [SerializeField]private GameObject _commonPanel;
    // Start is called before the first frame update
    void Start()
    {
        _commonPanel.SetActive(false);
        _spriteThemeButton.onClick.AddListener(SpriteThemeButtonClicked);
    }

    void SpriteThemeButtonClicked(){
        _commonPanel.SetActive(true);
    }
}
