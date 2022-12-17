using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int maxhealth = 100;
    public int _currentHealth;
    
    // Start is called before the first frame update
    void Start()
    {
        _currentHealth = maxhealth;
    }

    // Update is called once per frame
    void Update()
    {
        if(_currentHealth <= 0)
        {
            Destroy(gameObject);
        }
        
    }
    public void TakeDamage(int damage)
    {
        _currentHealth -= damage;

    }
}
