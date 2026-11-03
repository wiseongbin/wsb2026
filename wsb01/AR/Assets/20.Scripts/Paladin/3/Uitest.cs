using UnityEngine;
using UnityEngine.UI;

public class Uitest : MonoBehaviour
{
    [SerializeField] private Button testBtn;

    void Awake()
    {
        if (testBtn != null)
        {
            testBtn.onClick.AddListener(OnButtonClick);
        }
    }

    public void OnButtonClick()
    {
        Debug.Log("Button Clicked");
    }

    void OnDestroy() 
    {
        if (testBtn != null)
        {
            testBtn.onClick.RemoveListener(OnButtonClick);
        }
    }
}