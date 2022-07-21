using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private Player _player;

    private float _maxValue;

    private void Start()
    {
        _maxValue = 100f;
        _slider.maxValue = _maxValue;
        _slider.value = _maxValue;
    }

    private void OnEnable()
    {
        _player.OnSetHealth += SetHealth;
    }

    private void OnDisable()
    {
        _player.OnSetHealth -= SetHealth;
    }

    private void SetHealth(float health)
    {
        StartCoroutine(ShowHealth(health));
    }

    private IEnumerator ShowHealth(float targetHealth)
    {
        float recoveryRate = 40f;

        while (_slider.value != targetHealth)
        {
            _slider.value = Mathf.MoveTowards(_slider.value, targetHealth, recoveryRate * Time.deltaTime); 
            yield return null;
        }
    }
}
