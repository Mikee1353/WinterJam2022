using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemmy : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public Transform attackPoint;
    public float attackRange = 0.5f;
    public LayerMask enemyLayers;
    public Animator animator;
    public int EnemyDamage = 10;
    public float attackRate = 2f;
    float nextAttackTime = 0f;
    private void Start()
    {
        currentHealth = maxHealth;
    }
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if(currentHealth <= 0)
        {
            Destroy(gameObject);
        }

    }
    private void EnemyAttack()
    {
        animator.SetTrigger("EnemyAttack");
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);
        foreach (Collider2D enemy in hitEnemies)
        {
            enemy.GetComponent<Health>().TakeDamage(EnemyDamage);
        }
    }
    private void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
            return;
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);

    }
    private void Update()
    {
        if(Time.time >= nextAttackTime)
        {
        EnemyAttack();
        nextAttackTime = Time.time +1f / attackRate;

        }
        
    }
}
