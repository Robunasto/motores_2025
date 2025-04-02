using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [Header("Attack Settings")]
    public int damagePoints = 25;
    public float pushedbackForce = 20f;
    public Transform attackOrigin;
    [Range(0f, 2f)]
    public float attackRangeRadius;
    public LayerMask enemyLayer;

    public Animator animator;
    void Start()
    {
        animator = GetComponentInChildren<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            animator.SetTrigger("AttackTrigger");
        }
    }

    public void Attack()
    {
        Collider2D[] enemyColliders = Physics2D.OverlapCircleAll(attackOrigin.position, attackRangeRadius, enemyLayer);
        for (int i = 0; i < enemyColliders.Length; i++)
        {
            GameObject enemy = enemyColliders[i].gameObject;
            enemy.GetComponentInChildren<SpriteRenderer>().color = Color.red;
            //enemy.gameObject.GetComponent<AIBrain>().TransitionToState("Damaged");
            enemy.gameObject.GetComponent<Health>().TakeDamage(damagePoints);

            Vector2 attackDir = enemy.transform.position - this.transform.position;
            enemy.GetComponent<Rigidbody2D>().AddForce(attackDir.normalized * pushedbackForce);
        }
    }

    private void OnDrawGizmos()
    {
        if(attackOrigin != null)
        {
            Gizmos.color = Color.yellow;
            Gizmos.DrawWireSphere(attackOrigin.position, attackRangeRadius);
        }
    }
}