using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimationEvents : MonoBehaviour
{
    public void Death()
    {
        Destroy(transform.parent.gameObject);
    }
}
