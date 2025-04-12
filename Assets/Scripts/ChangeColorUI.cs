using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColorUI : MonoBehaviour
{
    public Color newColor = Color.black;
    public GameObject panel;
    void update()
    {

    }
    public void BackgroundChange()
    {
        panel.GetComponent<Image>().color = newColor;
    }
}
