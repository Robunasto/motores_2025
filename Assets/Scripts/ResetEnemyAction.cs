using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetEnemyAction : AIAction
{
    public override void OnEnterState()
    {
        base.OnEnterState();
        GetComponentInChildren<SpriteRenderer>().color = Color.white;
    }
    public override void PerformAction()
    {
        
    }
}
