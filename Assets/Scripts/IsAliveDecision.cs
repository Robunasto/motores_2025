using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsAliveDecision : AIDecision
{
    public override bool Decide()
    {
        return GetComponent<Health>().currentHealth <= 0;
    }
}
