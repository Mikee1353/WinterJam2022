using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int maxhealth = 100;
    public int _currentHealth;

    public Slider healthSlider;
    
    // Start is called before the first frame update
    void Start()
    {
        _currentHealth = maxhealth;
        healthSlider.maxValue = 100;
        healthSlider.minValue = 0;
    }

    // Update is called once per frame
    void Update()
    {
        healthSlider.value = _currentHealth;

        if(_currentHealth <= 0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        
    }
    public void TakeDamage(int damage)
    {
        _currentHealth -= damage;

    }
}
