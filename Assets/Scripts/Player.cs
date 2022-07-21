using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{    
    private float _maxHealth;
    private float _health;

    public event UnityAction<float> OnSetHealth;

    private void Start()
    {
        _maxHealth = 100f;
        _health = _maxHealth;
    }

    public void Damage(float damage)
    {
        _health -= damage;
        _health = (_health < 0) ? 0 : _health;
        SetHealth();
    }

    public void Heal(float health)
    {
        _health += health;
        _health = (_health > _maxHealth) ? _maxHealth : _health;
        SetHealth();
    }

    private void SetHealth()
    {
        OnSetHealth?.Invoke(_health);
    }
}
