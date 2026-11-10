using TMPro;
using UnityEngine;

public class DrawButtonController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public TextMeshProUGUI drawText;

    int i = 0;

    public void ChangeDrawMode()
    {
        i = (i + 1) % 2;

        if(i == 1)
        {
            drawText.text = "Stop";
            GameManager.instance.isDrawing = true;
            GameManager.instance.ShowMessage("Start Drawing");
        }
        else
        {
            drawText.text = "Draw";
            GameManager.instance.isDrawing = false;
            GameManager.instance.ShowMessage("Stop Drawing");
        }
    }
}
