using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class ClosePanelButton : MonoBehaviour
{
    [SerializeField] private GameObject _panel;
    [SerializeField] private GameObject[] _objectsToHide;

    private void Start()
    {
        var btn = GetComponent<Button>();
        btn.onClick.AddListener(onButtonClicked);
    }

    private void onButtonClicked()
    {
        if(_panel == null)
        {
            Debug.LogError("You did not provided pane to ClosePanelButton script");
        }


        if(_objectsToHide != null)
        {
            foreach(var obj in _objectsToHide)
            {
                obj.SetActive(false);
            }
        }
        _panel.SetActive(false);

    }
}
