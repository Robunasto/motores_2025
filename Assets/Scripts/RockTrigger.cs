using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockTrigger : MonoBehaviour
{
    public int damage;
    private void OnTriggerEnter2D(Collider2D collision)
    {

        //Debug.Log("ENTRO " + collision.gameObject.name);
        if (collision.gameObject.tag == "Player")
        {
            //collision.gameObject.GetComponent<PlayerAttack>().animator.SetTrigger("AttackTrigger");
            //collision.gameObject.transform.GetChild(0).GetComponent<SpriteRenderer>().color = Color.red;
            collision.gameObject.GetComponent<Health>().TakeDamage(damage);
        }
    }
}
