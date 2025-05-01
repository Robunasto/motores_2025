using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int maxHealth;
    public int currentHealth;
    public LifeBarUI lifebar;

    private void Start()
    {
        currentHealth = maxHealth;
        if (lifebar != null) lifebar.SetMaxLife(maxHealth);
    }
    public void TakeDamage(int _damagePoints)
    {
        currentHealth -= _damagePoints;
        if (currentHealth <= 0)
        {
            currentHealth = 0;
            //Die();
        }
        ChangeUI();
    }
    public void Heal(int _lifePoints)
    {
        currentHealth += _lifePoints;
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
    }
    public void Die()
    {
        Destroy(this.gameObject);
    }
    private void ChangeUI()
    {
        if (lifebar != null) lifebar.SetMaxLife(maxHealth);
    }

}