using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _maxHealth = 100f;
    [SerializeField] private HealthBar _healthBar;

    private float _health;

    private void Start()
    {
        _health = _maxHealth;
        _healthBar.SetMaxHealth(_maxHealth);
    }

    public void Damage(float damage)
    {
        _health -= damage;
        _health = (_health < 0) ? 0 : _health;
        _healthBar.SetHealth(_health);
    }

    public void Heal(float health)
    {
        _health += health;
        _health = (_health > _maxHealth) ? _maxHealth : _health;
        _healthBar.SetHealth(_health);
    }
}
