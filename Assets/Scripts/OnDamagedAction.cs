using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class OnDamagedAction : AIAction
{
    public override void PerformAction()
    {
        base.OnEnterState();
        GetComponentInChildren<Animator>().SetTrigger("DamagedTrigger");
    }
}
