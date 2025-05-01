using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeBarUI : MonoBehaviour
{
    public Color maxColor;
    public Color minColor;
    private Image lifeBar;
    private float maxLife;

    private void Start()
    {
        lifeBar = GetComponent<Image>();
    }
    public void ChangeFillAmount(int _amount)
    {
        lifeBar.color = Color.Lerp(minColor, maxColor, (float)_amount / maxLife);
        lifeBar.fillAmount = (float)_amount / maxLife;
    }
    public void SetMaxLife(int _maxLife)
    {
        maxLife = (float)_maxLife;
    }
}
