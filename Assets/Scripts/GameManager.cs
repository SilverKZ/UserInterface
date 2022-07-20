using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private HealthBar _healthBar;
    [SerializeField] private Player _player;

    private void Start()
    {
        _healthBar.SetMaxHealth(_player.MaxHealth);
    }

    public void HandleDamageButton(float value)
    {
        _player.Damage(value);
        SetHealth(_player.Health);
    }

    public void HandleHealButton(float value)
    {
        _player.Heal(value);
        SetHealth(_player.Health);
    }

    private void SetHealth(float health)
    {
        _healthBar.SetHealth(health);
    }
}
