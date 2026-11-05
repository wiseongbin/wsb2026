using TMPro;
using UnityEngine;

public class DrawButtonController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public TextMeshProUGUI drawText;

    public void Changebutton()
    {
        drawText.text = "그리기 시작!";
    }
}
