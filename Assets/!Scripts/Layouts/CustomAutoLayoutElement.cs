using UnityEngine;
using UnityEngine.UI;

public class CustomAutoLayoutElement : MonoBehaviour
{
    public float minWidth => 20;

    public float preferredWidth => 25;

    public float flexibleWidth => throw new System.NotImplementedException();

    public float minHeight => throw new System.NotImplementedException();

    public float preferredHeight => throw new System.NotImplementedException();

    public float flexibleHeight => throw new System.NotImplementedException();

    public int layoutPriority => throw new System.NotImplementedException();

    public void CalculateLayoutInputHorizontal()
    {
        
    }

    public void CalculateLayoutInputVertical()
    {
        
    }
}
