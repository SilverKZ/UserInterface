using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{    
    private float _maxHealth;
    private float _health;

    public event UnityAction<float> HealthChanged;

    private void Start()
    {
        _maxHealth = 100f;
        _health = _maxHealth;
    }

    public void Damage(float damage)
    {
        _health -= damage;
        _health = Mathf.Clamp(_health, 0, _maxHealth);
        HealthChanged?.Invoke(_health);
    }

    public void Heal(float health)
    {
        _health += health;
        _health = Mathf.Clamp(_health, 0, _maxHealth);
        HealthChanged?.Invoke(_health);
    }
}
