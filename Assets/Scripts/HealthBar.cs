using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Slider _slider;

    public void SetMaxHealth(float health)
    {
        _slider.maxValue = health;
        _slider.value = health;
    }

    public void SetHealth(float health)
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
