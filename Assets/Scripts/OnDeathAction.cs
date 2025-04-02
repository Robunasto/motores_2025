using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnDeathAction : AIAction
{
    public override void OnEnterState()
    {
        base.OnEnterState();
        GetComponentInChildren<Animator>().SetBool("IsAlive", false);
        GetComponentInChildren<Animator>().SetTrigger("DeathTrigger");
    }

    public override void PerformAction()
    {
    }
}
