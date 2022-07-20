using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _maxHealth = 100f;
    
    private float _health;

    public float MaxHealth { get { return _maxHealth; } }
    public float Health { get { return _health; } }

    private void Start()
    {
        _health = _maxHealth;
    }

    public void Damage(float damage)
    {
        _health -= damage;
        _health = (_health < 0) ? 0 : _health;
    }

    public void Heal(float health)
    {
        _health += health;
        _health = (_health > _maxHealth) ? _maxHealth : _health;
    }
}
