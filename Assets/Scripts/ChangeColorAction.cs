using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorAction : AIAction
{
    public Color newColor;
    public override void OnEnterState()
    {
        base.OnEnterState();
        GetComponentInChildren<SpriteRenderer>().color = newColor;
    }
    public override void PerformAction()
    {
        
    }
}
